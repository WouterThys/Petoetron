﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron.Classes.Helpers
{
    public static class Toolbox
    {
        #region IMAGES

        public static MemoryStream ConvertImage(Stream inputImage, ImageFormat format)
        {
            using (var outStream = new MemoryStream())
            {
                var imageStream = Image.FromStream(inputImage);
                return ConvertImage(imageStream, format);
            }
        }

        public static MemoryStream ConvertImage(Image inputImage, ImageFormat format)
        {
            using (var outStream = new MemoryStream())
            {
                inputImage.Save(outStream, format);
                outStream.Seek(0, SeekOrigin.Begin);
                return outStream;
            }
        }

        public static MemoryStream ResizeImage(Stream image, int maxSide)
        {
            using (var outStream = new MemoryStream())
            {
                var imageStream = Image.FromStream(image);
                return ResizeImage(imageStream, maxSide);
            }
        }

        public static MemoryStream ResizeImage(Image image, int maxSide)
        {
            int oldH = image.Height;
            int oldW = image.Width;
            int newH = 0;
            int newW = 0;

            if (oldH > oldW)
            {
                newH = maxSide;
                newW = (oldW / oldW) * newH;
            }
            else
            {
                newW = maxSide;
                newH = newW / (oldW / oldH);
            }

            using (var inStream = new MemoryStream())
            {
                Image thumbnail = image.GetThumbnailImage(newW, newH, null, IntPtr.Zero);
                var thumbnailStream = new MemoryStream();
                thumbnail.Save(thumbnailStream, image.RawFormat);
                thumbnailStream.Seek(0, SeekOrigin.Begin);
                return thumbnailStream;
            }
        }



        public static MemoryStream CompressImage(Image image, ImageFormat format)
        {
            var encoder = GetEncoder(format);
            var outStream = new MemoryStream();

            // if we aren't able to retrieve our encoder
            // we should just save the current image and
            // return to prevent any exceptions from happening
            if (encoder == null)
            {
                image.Save(outStream, format);
            }
            else
            {
                var qualityEncoder = System.Drawing.Imaging.Encoder.Quality;
                var encoderParameters = new EncoderParameters(1);
                encoderParameters.Param[0] = new EncoderParameter(qualityEncoder, 50L);
                image.Save(outStream, encoder, encoderParameters);
            }
            outStream.Seek(0, SeekOrigin.Begin);
            return outStream;
        }

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            var codecs = ImageCodecInfo.GetImageDecoders();
            foreach (var codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }

            return null;
        }


        #endregion

        public static void OpenBrowser(string url)
        {
            if (string.IsNullOrEmpty(url)) return;

            string BrowserName = "";
            using (RegistryKey userChoiceKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice"))
            {
                if (userChoiceKey == null)
                {
                    BrowserName = "UNKNOWN";
                }

                object progIdValue = userChoiceKey.GetValue("Progid");
                if (progIdValue == null)
                {
                    BrowserName = "UNKNOWN";
                }

                string prog = progIdValue.ToString();
                if (prog.Contains("IE.HTTP"))
                {
                    BrowserName = "INTERNETEXPLORER";
                }
                else if (prog.Contains("FirefoxURL"))
                {
                    BrowserName = "FIREFOX";
                }
                else if (prog.Contains("ChromeHTML"))
                {
                    BrowserName = "CHROME";
                }
                else 
                {
                    BrowserName = "UNKNOWN";
                }

                switch (BrowserName)
                {
                    case "INTERNETEXPLORER":
                        System.Diagnostics.Process.Start("iexplore.exe", "-private " + url);
                        break;
                    case "FIREFOX":
                        System.Diagnostics.Process.Start("firefox.exe", "-private-window " + url);
                        break;
                    case "CHROME":
                        System.Diagnostics.Process.Start("chrome.exe", "-incognito " + url);
                        break;
                    case "UNKNOWN":
                        System.Diagnostics.Process.Start("iexplore.exe", "-private " + url);
                        break;
                }
            }
        }
    }
}
