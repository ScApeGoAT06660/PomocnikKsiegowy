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
                    Rok = txtRok.Text,
                    Miesiac = txtMiesiac.Text,
                    NazwaFirmy = txtNazwaFirmy.Text
                };

                if (rbDuzy.Checked)
                    grzbiet.Rozmiar = true;

                if (rbMaly.Checked)
                    grzbiet.Rozmiar = false;

                if (rbPodzial.Checked) 
                    grzbiet.Podzial = true;

                if (rbBrakPodziału.Checked)
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

                // Ustawienie wysokości wierszy
                worksheet.Row(1).Height = 13.14;
                worksheet.Row(2).Height = 64.57;
                worksheet.Row(3).Height = 13.14;

                for (int i = 0; i < grzbiety.Count; i++)
                {
                    int column = i + 1; // Określenie numeru kolumny

                    // Ustawienie szerokości kolumn w zależności od Rozmiar
                    worksheet.Column(column).Width = grzbiety[i].Rozmiar ? 31.857 : 20.29;

                    // Wpisanie danych do odpowiednich komórek
                    worksheet.Cells[1, column].Value = grzbiety[i].Rok;
                    worksheet.Cells[1, column].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells[1, column].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells[1, column].Style.Border.Bottom.Color.SetColor(System.Drawing.Color.Black);
                    worksheet.Cells[1, column].Style.Font.Bold = true;

                    worksheet.Cells[2, column].Value = grzbiety[i].NazwaFirmy;
                    worksheet.Cells[2, column].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    worksheet.Cells[3, column].Value = grzbiety[i].Miesiac;
                    worksheet.Cells[3, column].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells[3, column].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells[3, column].Style.Border.Top.Color.SetColor(System.Drawing.Color.Black);
                    worksheet.Cells[3, column].Style.Font.Bold = true;
                }

                // Zapis do pliku
                FileInfo fileInfo = new FileInfo(sciezkaPliku);
                excel.SaveAs(fileInfo);
            }
        }


    }
}
