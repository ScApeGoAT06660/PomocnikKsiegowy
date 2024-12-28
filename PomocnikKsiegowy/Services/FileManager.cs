using PdfSharp.Drawing;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomocnikKsiegowy
{
    internal class FileManager
    {
        public string PdfFilePath { get; set; }

        private string outputFilePath;

        public void Save() 
        {
            int x = 398;
            int y = 83;

            PdfDocument document = PdfReader.Open(PdfFilePath, PdfDocumentOpenMode.Modify);

            foreach (PdfPage page in document.Pages)
            {
                double originalWidth = page.Width;

                double originalHeight = page.Height;

                page.MediaBox = new PdfRectangle(
                new XPoint(x, 0),
                new XPoint(originalWidth - y, originalHeight)
                );
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Zapisz przetworzony plik PDF"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                outputFilePath = saveFileDialog.FileName;
                document.Save(outputFilePath);
            }
        }

        public void Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Wybierz plik PDF"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PdfFilePath = openFileDialog.FileName;
            }
        }
    }
}
