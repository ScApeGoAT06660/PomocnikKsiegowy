using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace PomocnikKsiegowy
{
    public partial class Form1 : Form
    {
        PaliwoManager paliwoManager = new PaliwoManager();
        Paliwo paliwo;

        PiedziesiatProcent naPol = new PiedziesiatProcent();

        ManagerKalkulator managerKalkulator = new ManagerKalkulator();
        Kalkulator kalkulator = new Kalkulator();

        ManagerOpisow managerOpisow = new ManagerOpisow();

        Form2 oknoDodaj;

        BruttoNetto bruttoNetto = new BruttoNetto();

        NaDuze naDuze = new NaDuze();

        string pdfFilePath;
        string outputFilePath;

        public Form1()
        {
            InitializeComponent();

            this.TopMost = true;

            txtWynik.ReadOnly = true;
            txtWynikNaPol.ReadOnly = true;
            txtBruttoKal.ReadOnly = true;
            txtNettoKal2.ReadOnly = true;
            txtDuzeWynik.ReadOnly = true;
        }

        private void btnWczytaj(object sender, EventArgs e)
        {
            paliwo = new Paliwo();

            paliwo.vat = Convert.ToDouble(txtVAT.Text);
            paliwo.netto = Convert.ToDouble(txtNetto.Text);

            if (rb25.Checked)
                paliwo.mnoznik = 0.20;

            if (rb75.Checked)
                paliwo.mnoznik = 0.75;

            if (chbLeasing.Checked)
                paliwo.leasing = true;

            txtWynik.Text = paliwoManager.ObliczPaliwo(paliwo);
        }

        private void btnPodziel_Click(object sender, EventArgs e)
        {
            double mnoznik = 0;

            if (rb020.Checked)
                mnoznik = 0.20;
            if (rb075.Checked)
                mnoznik = 0.75;
            if (rb50.Checked)
                mnoznik = 0.50;

            txtWynikNaPol.Text = naPol.NaPol(txtLiczba.Text, mnoznik).ToString();
        }

        private void btnLiczba(object sender, EventArgs e)
        {
            txtWynikKalkulator.Text += (sender as Button).Text;
            txtWynikKalkulator.Focus();
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button klikniety = (Button)sender;

            kalkulator.operators = Convert.ToChar(klikniety.Text);
            kalkulator.storageNumber = Convert.ToDouble(txtWynikKalkulator.Text);

            txtWynikKalkulator.Text = "";
            txtWynikKalkulator.Focus();
        }

        private void btnWynikKalkulator_Click(object sender, EventArgs e)
        {
            kalkulator.secondNumber = Convert.ToDouble(txtWynikKalkulator.Text);

            txtWynikKalkulator.Text =  managerKalkulator.Oblicz(kalkulator).ToString();
            txtWynikKalkulator.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            kalkulator.operators = null;
            kalkulator.storageNumber = 0.0;
            kalkulator.storageNumber = 0.0;
            txtWynikKalkulator.Text = "";
            txtWynikKalkulator.Focus();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 0: txtVAT.Focus(); break;
                    case 1: txtLiczba.Focus(); break;
                    case 2: txtWynikKalkulator.Focus(); break;
                    case 3: txtSchowek1.Focus(); break;
                    case 5: txtNettoKal.Focus(); break;
                    case 6: txtDuzeLitery.Focus(); break;
                }
            }
        }

        public void btnWczytajOpisy_Click(object sender, EventArgs e)
        {
            List<string> dane = managerOpisow.WczytajOpisy();

            lbOpisy.Items.Clear();
            foreach (var item in dane)
            {
                lbOpisy.Items.Add(item);
            }
        }

        private void lbOpisy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                string s = lbOpisy.SelectedItem.ToString();
                Clipboard.SetData(DataFormats.StringFormat, s);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            oknoDodaj = new Form2(this, managerOpisow);
            oknoDodaj.Show();
        }

        private void btnBruttoNaNetto_Click(object sender, EventArgs e)
        {
            double mnoznik = 0;

            if (stawka23.Checked)
                mnoznik = 0.23;
            if (stawka8.Checked)
                mnoznik = 0.08;
            if (stawka5.Checked)
                mnoznik = 0.05;

            txtNettoKal2.Text = bruttoNetto.BruttoNaNetto(txtBruttoKal2.Text, mnoznik).ToString();
        }

        private void btnNettoNaBrutto_Click(object sender, EventArgs e)
        {
            double mnoznik = 0;

            if (stawka23.Checked)
                mnoznik = 0.23;
            if (stawka8.Checked)
                mnoznik = 0.08;
            if (stawka5.Checked)
                mnoznik = 0.05;

            txtBruttoKal.Text = bruttoNetto.NettoNaBrutto(txtNettoKal.Text, mnoznik).ToString();
        }

        private void btnZamien_Click(object sender, EventArgs e)
        {
            txtDuzeWynik.Text = naDuze.ZamienNaDuze(txtDuzeLitery.Text);
        }

        private void btnWczytajPlik_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Wybierz plik PDF"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               pdfFilePath = openFileDialog.FileName;
            }
        }

        private void btnZapiszPdf_Click(object sender, EventArgs e)
        {
            int x = 200;
            int y = 200;

            PdfDocument document = PdfReader.Open(pdfFilePath, PdfDocumentOpenMode.Modify);

            foreach (PdfPage page in document.Pages)
            {
                // Obecne rozmiary strony
                double originalWidth = page.Width;
                double originalHeight = page.Height;

                // Nowe granice strony xd
                page.MediaBox = new PdfRectangle( 
                    new XPoint(x, 0),                      // Lewy dolny róg
                    new XPoint(originalWidth - y, originalHeight) // Prawy górny róg
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
    }
}
