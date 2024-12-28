using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

using OfficeOpenXml.Style;
using System.Data.Common;
using System.Diagnostics;

namespace PomocnikKsiegowy
{
    /// <summary>
    /// Klasa odpowiedzialna za tworzenie i zarządzanie grzbietami segregatorów,
    /// w tym za generowanie arkuszy Excel z danymi o grzbietach.
    /// </summary>
    /// <summary>
    /// Klasa odpowiedzialna za tworzenie i zarządzanie grzbietami segregatorów,
    /// w tym za generowanie arkuszy Excel z danymi o grzbietach.
    /// </summary>
    public partial class AddSpines : UserControl
    {
        /// <summary>
        /// Lista przechowująca dane grzbietów.
        /// </summary>
        private List<Spine> spines;

        /// <summary>
        /// Inicjalizuje komponent i ustawia zakresy dla kontrolki wyboru miesięcy.
        /// </summary>
        public AddSpines()
        {
            InitializeComponent();

            nudMonth.Minimum = 1;
            nudMonth.Maximum = 12;

            nudMonth2.Minimum = 1;
            nudMonth2.Maximum = 12;
        }

        /// <summary>
        /// Ustawia nazwę grupy dla kontrolki/>.
        /// </summary>
        /// <param name="nowaNazwa">Nowa nazwa grupy.</param>
        public void SetGroupBoxName(string nowaNazwa)
        {
            gbSpines.Text = nowaNazwa;
        }

        /// <summary>
        /// Tworzy listę grzbietów na podstawie podanej listy kontrolek <see cref="AddSpines"/>.
        /// </summary>
        /// <param name="addedSpinesList">Lista kontrolek grzbietów.</param>
        /// <returns>Lista obiektów <see cref="Spine"/>.</returns>
        public List<Spine> CreateSpines(List<AddSpines> addedSpinesList)
        {
            spines = new List<Spine>();

            foreach (var item in addedSpinesList)
            {
                Spine spine = new Spine
                {
                    Year = item.txtYear.Text,
                    Month = item.nudMonth.Text,
                    TraderName = item.txtTraderName.Text,
                    Size = item.rbBig.Checked,
                    Section = item.rbSection.Checked,
                    Parts = item.rbSection.Checked ? item.nudParts.Text : null,
                    Range = item.rbRange.Checked,
                    Month2 = item.rbRange.Checked ? item.nudMonth2.Text : null
                };

                spines.Add(spine);
            }

            return spines;
        }

        /// <summary>
        /// Tworzy plik Excel z danymi grzbietów i zapisuje go w podanej ścieżce.
        /// </summary>
        /// <param name="excelFolderPath">Ścieżka do folderu docelowego.</param>
        /// <param name="excelFilePath">Ścieżka do pliku Excel.</param>
        /// <param name="spines">Lista grzbietów do zapisania.</param>
        /// <param name="toolTip">Element UI do wyświetlenia statusu.</param>
        public void CreateExcelFile(string excelFolderPath, string excelFilePath, List<Spine> spines, ToolStripStatusLabel toolTip)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (ExcelPackage excel = new ExcelPackage())
            {
                var worksheet = excel.Workbook.Worksheets.Add("Grzbiety");

                worksheet.Row(1).Height = 80;

                worksheet.Row(2).Height = 390;

                worksheet.Row(3).Height = 80;

                for (int i = 0; i < spines.Count; i++)
                {
                    int column = i + 1;

                    worksheet.Cells[1, column].Value = spines[i].Year;

                    worksheet.Cells[2, column].Value = spines[i].TraderName.ToUpper();

                    if (string.IsNullOrEmpty(spines[i].Month))
                    {
                        worksheet.Cells[3, column].Value = "";
                    }
                    else
                    {
                        string rzymskaM = RomanNumeralsMonth(Convert.ToInt32(spines[i].Month));

                        if (spines[i].Range)
                        {
                            string rzymskaM2 = RomanNumeralsMonth(Convert.ToInt32(spines[i].Month2));

                            rzymskaM += " - " + rzymskaM2;
                        }

                        worksheet.Cells[3, column].Value = spines[i].Section
                            ? $"{rzymskaM.ToUpper()} cz. {spines[i].Parts}"
                            : rzymskaM.ToUpper();
                    }

                    SpineStyle(worksheet, column, spines[i].Size);
                }

                FileInfo fileInfo = new FileInfo(excelFilePath);

                excel.SaveAs(fileInfo);

                Process.Start("explorer.exe", excelFolderPath);

                toolTip.Text = "Plik został zapisany.";

                this.FindForm()?.Close();
            }
        }

        /// <summary>
        /// Ustawia styl dla grzbietu w arkuszu Excel.
        /// </summary>
        /// <param name="worksheet">Arkusz Excel.</param>
        /// <param name="column">Numer kolumny dla grzbietu.</param>
        /// <param name="Rozmiar">Określa, czy grzbiet jest duży.</param>
        public void SpineStyle(ExcelWorksheet worksheet, int column, bool Rozmiar)
        {
            worksheet.Column(column).Width = Rozmiar ? 31.857 : 20.29;
            worksheet.Cells[2, column].Style.TextRotation = Rozmiar ? 0 : 90;

            worksheet.Cells[1, column].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            worksheet.Cells[1, column].Style.Border.Bottom.Color.SetColor(Color.Black);
            worksheet.Cells[1, column].Style.Font.Bold = true;

            worksheet.Cells[3, column].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            worksheet.Cells[3, column].Style.Border.Top.Color.SetColor(Color.Black);
            worksheet.Cells[3, column].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            worksheet.Cells[3, column].Style.Border.Bottom.Color.SetColor(Color.LightGray);
            worksheet.Cells[3, column].Style.Font.Bold = true;

            for (int row = 1; row <= 3; row++)
            {
                var cell = worksheet.Cells[row, column];
                cell.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                cell.Style.Border.Left.Color.SetColor(Color.LightGray);
                cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                cell.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                cell.Style.Font.Name = "Oswald";
                cell.Style.Font.Size = 24;
            }
        }

        /// <summary>
        /// Konwertuje numer miesiąca na jego odpowiednik w liczbach rzymskich.
        /// </summary>
        /// <param name="month">Numer miesiąca (1-12).</param>
        /// <returns>Miesiąc w formacie rzymskim (np. "I", "II").</returns>
        public string RomanNumeralsMonth(int month)
        {
            string[] romanMonths = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XII" };
            
            return romanMonths[month - 1];
        }
    }
}
