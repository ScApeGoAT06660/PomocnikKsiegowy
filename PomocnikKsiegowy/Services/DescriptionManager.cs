using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PomocnikKsiegowy
{
    /// <summary>
    /// Klasa zarządzająca operacjami na opisach, takimi jak wczytywanie, dodawanie oraz wybieranie ścieżki pliku z opisami.
    /// </summary>
    public class DescriptionManager
    {
        public string descritpionPath { get; set; }

        /// <summary>
        /// Wczytuje opisy z pliku znajdującego się w ścieżce <see cref="descritpionPath"/>.
        /// </summary>
        /// <returns>
        /// Posortowana lista ciągów znaków reprezentujących wczytane opisy.
        /// </returns>
        /// <exception cref="FileNotFoundException">Rzucane, jeśli plik w podanej ścieżce nie istnieje.</exception>
        public List<string> LoadDescriptons()
        {
            string[] data = File.ReadAllLines(descritpionPath);

            List<string> sortedData = new List<string>(data);
            sortedData.Sort();

            return sortedData;
        }

        /// <summary>
        /// Dodaje nowy opis do pliku znajdującego się w ścieżce <see cref="descritpionPath"/>.
        /// </summary>
        /// <param name="newDescription">Tekst nowego opisu do dodania.</param>
        /// <exception cref="IOException">Rzucane, jeśli wystąpi problem z zapisem do pliku.</exception>
        public void AddDescription(string newDescription)
        {
            File.AppendAllText(descritpionPath, Environment.NewLine + newDescription);
        }

        /// <summary>
        /// Otwiera okno dialogowe umożliwiające użytkownikowi wybór ścieżki do pliku z opisami.
        /// </summary>
        /// <remarks>
        /// Domyślnie otwiera katalog "Data" znajdujący się w folderze aplikacji.
        /// </remarks>
        public void OpenFile()
        {
            string dataFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");


            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Wybierz ścieżkę pliku z opisami",
                InitialDirectory = dataFolderPath
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                descritpionPath = openFileDialog.FileName;
            }
        }
    }
}
