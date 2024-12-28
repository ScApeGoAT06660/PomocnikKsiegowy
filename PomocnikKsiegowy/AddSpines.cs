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
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Data.Common;
using System.Diagnostics;

namespace PomocnikKsiegowy
{
    public partial class AddSpines : UserControl
    {
        List<Spine> spines;   

        public AddSpines()
        {
            InitializeComponent();

            nudMonth.Minimum = 1;
            nudMonth.Maximum = 12;

            nudMonth2.Minimum = 1;
            nudMonth2.Maximum = 12;
        }

        public void SetGroupBoxName(string nowaNazwa)
        {
            gbSpines.Text = nowaNazwa;
        }

        public List<Spine> CreateSpines(List<AddSpines> addedSpinesList)
        {
            spines = new List<Spine>();

            foreach (var item in addedSpinesList)
            {
                Spine spine = new Spine
                {
                    Year = item.txtYear.Text,
                    Month = item.nudMonth.Text,
                    TraderName = item.txtTraderName.Text
                };

                if (item.rbBig.Checked)
                    spine.Size = true;

                if (item.rbSmall.Checked)
                    spine.Size = false;

                if (item.rbSection.Checked)
                {
                    spine.Section = true;

                    spine.Parts = item.nudParts.Text;
                }

                if(item.rbRange.Checked)
                {
                    spine.Range = true;

                    spine.Month2 = item.nudMonth2.Text;
                }
                    
                    
                if (item.rbNoSection.Checked)
                    spine.Section = false;

                spines.Add(spine);
            }

            return spines;
        }

        private void rbSection_CheckedChanged(object sender, EventArgs e)
        {
            nudParts.Enabled = true;
        }

        private void rbNoSection_CheckedChanged(object sender, EventArgs e)
        {
            nudParts.Enabled = false;
        }

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

                    if (spines[i].Month == "")
                    {
                        worksheet.Cells[3, column].Value = "";
                    }
                    else
                    {
                        string rzymskaM = RomanNumeralsMonth(Convert.ToInt32(spines[i].Month));

                        if(spines[i].Range)
                        {
                            string rzymskaM2 = RomanNumeralsMonth(Convert.ToInt32(spines[i].Month2));

                            rzymskaM = rzymskaM + " - " + rzymskaM2;
                        }

                        if (spines[i].Section)
                        {
                            string czesc = "cz. " + spines[i].Parts;

                            worksheet.Cells[3, column].Value = rzymskaM.ToUpper() + " " + czesc;
                        }
                        else
                        {
                            worksheet.Cells[3, column].Value = rzymskaM.ToUpper();
                        }
                    }               

                    SpineStyle(worksheet, column, spines[i].Size);
                }

                FileInfo fileInfo = new FileInfo(excelFilePath);

                excel.SaveAs(fileInfo);

                Process.Start("explorer.exe", excelFolderPath);

                toolTip.Text = "Plik został zapisany.";

                Form parentForm = this.FindForm();

                parentForm.Close();
            }
        }

        public void SpineStyle(ExcelWorksheet worksheet, int column, bool Rozmiar)
        {
            //bottom
            worksheet.Column(column).Width = Rozmiar ? 31.857 : 20.29;

            worksheet.Cells[2, column].Style.TextRotation = Rozmiar ? 0 : 90;

            //top         
            worksheet.Cells[1, column].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;

            worksheet.Cells[1, column].Style.Border.Bottom.Color.SetColor(Color.Black);

            worksheet.Cells[1, column].Style.Font.Bold = true;

            //bottom
            worksheet.Cells[3, column].Style.Border.Top.Style = ExcelBorderStyle.Thin;

            worksheet.Cells[3, column].Style.Border.Top.Color.SetColor(Color.Black);

            worksheet.Cells[3, column].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;

            worksheet.Cells[3, column].Style.Border.Bottom.Color.SetColor(Color.LightGray);

            worksheet.Cells[3, column].Style.Font.Bold = true;

            //szarta linia oddzielająca, wyrównanie na środku, czcionka
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

        public string RomanNumeralsMonth(int month)
        {
            string[] romanMonths = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XII" };

            return romanMonths[month - 1];
        }

        private void rbRange_CheckedChanged(object sender, EventArgs e)
        {
            if(rbRange.Checked)
                nudMonth2.Enabled = true;
            else
            {
                nudMonth2.Enabled = false;

                nudMonth2.Text = string.Empty;
            }
        }

    }
}
