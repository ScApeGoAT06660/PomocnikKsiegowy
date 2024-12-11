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

namespace PomocnikKsiegowy
{
    public partial class DodajGrzbiety : UserControl
    {
        List<Grzbiety> grzbiety;   

        public DodajGrzbiety()
        {
            InitializeComponent();
        }

        public void UstawNazweGroupBoxa(string nowaNazwa)
        {
            gbGrzbiety.Text = nowaNazwa;
        }

        public List<Grzbiety> UtworzGrzbiety(List<DodajGrzbiety> listaDodanychGrzbietow)
        {
            grzbiety = new List<Grzbiety>();

            foreach (var item in listaDodanychGrzbietow)
            {
                Grzbiety grzbiet = new Grzbiety
                {
                    Rok = item.txtRok.Text,
                    Miesiac = item.txtMiesiac.Text,
                    NazwaFirmy = item.txtNazwaFirmy.Text
                };

                if (item.rbDuzy.Checked)
                    grzbiet.Rozmiar = true;

                if (item.rbMaly.Checked)
                    grzbiet.Rozmiar = false;

                if (item.rbPodzial.Checked)
                {
                    grzbiet.Podzial = true;
                    grzbiet.Czesci = item.nudCzesc.Text;
                }

                if(item.rbZakres.Checked)
                {
                    grzbiet.Zakres = true;
                    grzbiet.Miesiac2 = item.txtMiesiac2.Text;
                }
                    
                    

                if (item.rbBrakPodziału.Checked)
                    grzbiet.Podzial = false;

                grzbiety.Add(grzbiet);
            }

            return grzbiety;
        }

        private void rbPodzial_CheckedChanged(object sender, EventArgs e)
        {
            nudCzesc.Enabled = true;
        }

        private void rbBrakPodziału_CheckedChanged(object sender, EventArgs e)
        {
            nudCzesc.Enabled = false;
        }

        public void StworzPlikExcel(string sciezkaPliku, List<Grzbiety> grzbiety)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (ExcelPackage excel = new ExcelPackage())
            {
                var worksheet = excel.Workbook.Worksheets.Add("Grzbiety");

                worksheet.Row(1).Height = 80;
                worksheet.Row(2).Height = 390;
                worksheet.Row(3).Height = 80;

                for (int i = 0; i < grzbiety.Count; i++)
                {
                    int column = i + 1;

                    worksheet.Cells[1, column].Value = grzbiety[i].Rok;
                    worksheet.Cells[2, column].Value = grzbiety[i].NazwaFirmy.ToUpper();

                    if (grzbiety[i].Miesiac == "")
                    {
                        worksheet.Cells[3, column].Value = "";
                    }
                    else
                    {
                        string rzymskaM = MiesiacRzymska(Convert.ToInt32(grzbiety[i].Miesiac));

                        if(grzbiety[i].Zakres)
                        {
                            string rzymskaM2 = MiesiacRzymska(Convert.ToInt32(grzbiety[i].Miesiac2));
                            rzymskaM = rzymskaM + " - " + rzymskaM2;
                        }

                        if (grzbiety[i].Podzial)
                        {
                            string czesc = "cz. " + grzbiety[i].Czesci;
                            worksheet.Cells[3, column].Value = rzymskaM.ToUpper() + " " + czesc;
                        }
                        else
                        {
                            worksheet.Cells[3, column].Value = rzymskaM.ToUpper();
                        }
                    }               

                    UtworzStylGrzbietu(worksheet, column, grzbiety[i].Rozmiar);
                }

                FileInfo fileInfo = new FileInfo(sciezkaPliku);
                excel.SaveAs(fileInfo);
            }
        }

        public void UtworzStylGrzbietu(ExcelWorksheet worksheet, int column, bool Rozmiar)
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

        public string MiesiacRzymska(int month)
        {
            string[] romanMonths = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XII" };

            return romanMonths[month - 1];
        }

        private void rbZakres_CheckedChanged(object sender, EventArgs e)
        {
            if(rbZakres.Checked)
                txtMiesiac2.Enabled = true;
            else
            {
                txtMiesiac2.Enabled = false;
                txtMiesiac2.Text = string.Empty;
            }
        }

    }
}
