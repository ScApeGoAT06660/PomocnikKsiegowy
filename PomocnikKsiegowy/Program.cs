using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomocnikKsiegowy
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            string excelFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Excel");

            // Utwórz folder, jeśli nie istnieje
            if (!Directory.Exists(excelFolderPath))
            {
                Directory.CreateDirectory(excelFolderPath);
            }

            Application.Run(new MainForm());

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }
    }
}
