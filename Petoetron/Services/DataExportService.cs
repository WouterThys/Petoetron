using Petoetron.Classes.Helpers;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petoetron.Services
{
    public interface IDataTransportService
    {
        void ExportTo(DocumentType exportType, string fileName);
        void ImportFrom(DocumentType importType, string fileName);
        void ShowPreview();
        void ShowPrint();
    }

    public class DataTransportService : IDataTransportService
    {
        public GridControl Grid { get; }

        public DataTransportService(GridControl gridControl)
        {
            Grid = gridControl;
        }

        public void ExportTo(DocumentType exportType, string fileName)
        {
            if (Grid == null) return;

            switch (exportType)
            {
                case DocumentType.Pdf:
                    Grid.ExportToPdf(fileName);
                    break;
                case DocumentType.Image:
                    // TODO
                    break;
                case DocumentType.Text:
                    Grid.ExportToText(fileName);
                    break;
                case DocumentType.Csv:
                    Grid.ExportToCsv(fileName);
                    break;
                case DocumentType.Excel:
                    Grid.ExportToXlsx(fileName);
                    break;
            }

        }

        public void ShowPreview()
        {
            Grid.ShowRibbonPrintPreview();

        }

        public void ShowPrint()
        {
            Grid.PrintDialog();
        }

        public void ImportFrom(DocumentType importType, string fileName)
        {
            // TODO
        }
    }
}
