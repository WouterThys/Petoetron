using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using Petoetron.Classes.Helpers;
using Petoetron.Models.Base;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;

namespace Petoetron.Models
{
    [POCOViewModel]
    public class ObjectFilesModel : BaseDocumentViewModel
    {

        public static ObjectFilesModel Create(IModuleType module)
        {
            return ViewModelSource.Create(() => new ObjectFilesModel(module));
        }
        
        public virtual IBaseObject FileEntity { get; set; }
        
        // Icons
        private Image iconToSave = null;
        public virtual Image ObjectIcon { get; set; }

        public ObjectFilesModel(IModuleType module) : base(module)
        {

        }

        #region MODEL

        public override Task Load()
        {
            IsLoading = true;

            return Task.Factory.StartNew((state) =>
            {

                // Icon
                Image im = iconToSave;
                if (im == null)
                {
                    string fileName = FileEntity.IconPath;
                    if (string.IsNullOrEmpty(fileName))
                    {
                        im = null;
                    }
                    else
                    {
                        try
                        {
                            im = Image.FromFile(fileName);
                        }
                        catch (Exception e)
                        {
                            Debug.WriteLine(e);
                        }
                    }
                }
                iconToSave = null;

               
                // Dispatch
                ((IDispatcherService)state).BeginInvoke(() =>
                {
                    // Icon
                    ObjectIcon = im;
                    OnLoaded();
                });
            }, DispatcherService);
        }


       

        public void OnLoading()
        {

        }

        public void OnLoaded()
        {
            IsLoading = false;
        }

        public void UpdateCommands()
        {

        }


        #endregion

        #region OBJECT ICON

        private int iconChangeCnt = 0;
        private readonly char[] iconChanger = new char[] { 'b', 'a', 'n', 'a', 'n', 'a' };

        public void OnObjectIconChanged()
        {
            if (IsLoading) return;
            iconToSave = ObjectIcon;
            if (FileEntity != null)
            {
                if (iconToSave != null)
                {
                    // Just change icon path to trigger property changed
                    FileEntity.IconPath += iconChanger[iconChangeCnt];
                    iconChangeCnt++;
                    if (iconChangeCnt >= iconChanger.Length)
                    {
                        iconChangeCnt = 0;
                    }
                }
                else
                {
                    FileEntity.IconPath = "";
                }
            }
        }

        public virtual void SaveImage()
        {
            if (iconToSave != null)
            {
                string dir = Path.Combine(FileEntity.TableName, "Icons");
                string name = Guid.NewGuid().ToString() + ".jpg";
                FileEntity.IconPath = Path.Combine(dir, name);

                Tuple<Image, string> saveData = new Tuple<Image, string>(iconToSave, FileEntity.IconPath);

                Task.Factory.StartNew((d) =>
                {
                    Tuple<Image, string> data = (Tuple<Image, string>)d;
                    Image image = data.Item1;
                    string path = data.Item2;
                    try
                    {
                        using (MemoryStream resized = Toolbox.ResizeImage(image, 256))
                        {
                            using (MemoryStream compressed = Toolbox.CompressImage(Image.FromStream(resized), ImageFormat.Jpeg))
                            {
                                using (var fileStream = File.Create(path))
                                {
                                    compressed.CopyTo(fileStream);
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Debug.WriteLine("SaveImage failed: " + e);
                    }

                }, saveData);
            }
            else
            {
                if (string.IsNullOrEmpty(FileEntity.IconPath))
                {

                }
            }
        }

        #endregion

        
    }
}
