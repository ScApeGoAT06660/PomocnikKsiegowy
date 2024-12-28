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
    /// <summary>
    /// Klasa zarządzająca operacjami na plikach PDF, takimi jak otwieranie i zapisywanie przetworzonych plików.
    /// </summary>
    internal class FileManager
    {
        public string PdfFilePath { get; set; }

        private string outputFilePath;

        /// <summary>
        /// Modyfikuje wymiary stron w pliku PDF i zapisuje przetworzony plik pod nową ścieżką.
        /// </summary>
        /// <remarks>
        /// Użytkownik wybiera lokalizację zapisu za pomocą okna dialogowego.
        /// Domyślnie przycinane są marginesy stron PDF o wartości `x` i `y`.
        /// </remarks>

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

        /// <summary>
        /// Otwiera okno dialogowe umożliwiające użytkownikowi wybór pliku PDF do modyfikacji.
        /// </summary>
        /// <remarks>
        /// Plik PDF wybrany przez użytkownika jest zapisany w właściwości <see cref="PdfFilePath"/>.
        /// </remarks>
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
