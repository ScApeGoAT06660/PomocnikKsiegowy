using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace PomocnikKsiegowy
{
    public class DescriptionManager
    {
        public string descritpionPath { get; set; }

        public List<string> LoadDescriptons()
        {
            string[] data = File.ReadAllLines(descritpionPath);

            List<string> sortedData = new List<string>(data);
            sortedData.Sort();

            return sortedData;
        }

        public void AddDescription(string newDescription)
        {
            File.AppendAllText(descritpionPath, Environment.NewLine + newDescription);
        }

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
