using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Xml.Serialization;
using System.IO;

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

        ImageList imageList;

        string pdfFilePath;
        string outputFilePath;

        List<Grzbiety> grzbiety;

        List<DodajGrzbiety> dodaneGrzbiety = new List<DodajGrzbiety>();

        string binPath;
        string folderPath;
        string fileName;

        string filePath;

        public Form1()
        {
            InitializeComponent();

            this.TopMost = true;

            ustawIkony();

            toolStripStatusLabel.Text = "";

            txtWynik.ReadOnly = true;
            txtWynikNaPol.ReadOnly = true;
            txtBruttoKal.ReadOnly = true;
            txtNettoKal2.ReadOnly = true;
            txtDuzeWynik.ReadOnly = true;
            txtNettoNaPol.ReadOnly = true;

            binPath = AppDomain.CurrentDomain.BaseDirectory;
            folderPath = Path.Combine(binPath, "dane");

            fileName = $"PlikExcel_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
            filePath = Path.Combine(folderPath, fileName);
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
            txtNettoNaPol.Text = (paliwo.netto / 2).ToString();
            SkopiujDoSchowka(txtWynik.Text, lblWynik.Text);
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
            SkopiujDoSchowka(txtWynikNaPol.Text, lblWynikNaPol.Text);
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
            SkopiujDoSchowka(txtWynikKalkulator.Text, "Wynik");
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
                SkopiujDoSchowka(s);             
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

            txtVetKal2.Text = bruttoNetto.ustalVat(txtBruttoKal2.Text, txtNettoKal2.Text).ToString();

            SkopiujDoSchowka(txtNettoKal2.Text, lblNettoKal2.Text);
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

            txtVatKal.Text = bruttoNetto.ustalVat(txtBruttoKal.Text, txtNettoKal.Text).ToString();

            SkopiujDoSchowka(txtBruttoKal.Text, lblBruttoKal.Text);
        }

        private void btnZamien_Click(object sender, EventArgs e)
        {
            txtDuzeWynik.Text = naDuze.ZamienNaDuze(txtDuzeLitery.Text);
            SkopiujDoSchowka(txtDuzeWynik.Text);
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

            toolStripStatusLabel.Text = "Plik został wczytany.";
        }

        private void btnZapiszPdf_Click(object sender, EventArgs e)
        {
            int x = 398;
            int y = 83;

            PdfDocument document = PdfReader.Open(pdfFilePath, PdfDocumentOpenMode.Modify);

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

            toolStripStatusLabel.Text = "Plik został zapisany.";
        }

        private void ustawIkony()
        {
            imageList = new ImageList();

            imageList.Images.Add("paliwo", Properties.Resources.gas_pump_alt);
            imageList.Images.Add("paliwo_alt", Properties.Resources.gas_pump_alt__1_);
            imageList.Images.Add("kalkulator", Properties.Resources.calculator);
            imageList.Images.Add("kopiowanie", Properties.Resources.duplicate);
            imageList.Images.Add("pdf", Properties.Resources.file_pdf);
            imageList.Images.Add("brutto_netto", Properties.Resources.calculator_money);
            imageList.Images.Add("skrocona", Properties.Resources.id_badge);
            imageList.Images.Add("excel", Properties.Resources.file_excel);

            tabControl1.ImageList = imageList;

            for (int i = 0; i < imageList.Images.Count; i++)
            {
                tabControl1.TabPages[i].ImageIndex = i;
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = sender as TabControl;

            bool isActiveTab = e.Index == tabControl.SelectedIndex;

            Color backgroundColor = isActiveTab ? Color.LightBlue : Color.White;
            Color textColor = isActiveTab ? Color.Black : Color.Gray;

            using (SolidBrush backgroundBrush = new SolidBrush(backgroundColor))
            {
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
            }

            if (tabControl.ImageList != null && e.Index < tabControl.ImageList.Images.Count)
            {
                Image image = tabControl.ImageList.Images[e.Index];

                int padding = 5;

                int x = e.Bounds.Left + (e.Bounds.Width - image.Width) / 2;
                int y = e.Bounds.Top + padding + (e.Bounds.Height - image.Height - 2 * padding) / 2;

                e.Graphics.DrawImage(image, x, y);
            }

            string tabText = tabControl.TabPages[e.Index].Text;
            using (SolidBrush textBrush = new SolidBrush(textColor))
            {
                StringFormat stringFormat = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Far
                };

                Rectangle textBounds = new Rectangle(e.Bounds.Left, e.Bounds.Top + e.Bounds.Height / 2, e.Bounds.Width, e.Bounds.Height / 2);
                e.Graphics.DrawString(tabText, tabControl.Font, textBrush, textBounds, stringFormat);
            }

            e.DrawFocusRectangle();
        }

        private void SkopiujDoSchowka(string toCopy, string nazwa)
        {
            toolStripStatusLabel.Text = $"{nazwa} ({toCopy}) - dodano do schowka";

            Clipboard.SetData(DataFormats.StringFormat, toCopy);
        }

        private void SkopiujDoSchowka(string toCopy)
        {
            toolStripStatusLabel.Text = "Skopiowano.";

            Clipboard.SetData(DataFormats.StringFormat, toCopy);
        }

        private void txtSchowek1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                SkopiujDoSchowka(txtSchowek1.Text, lblSchowek.Text);
            }
        }

        private void txtSchowek2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                SkopiujDoSchowka(txtSchowek2.Text, lblSchowek.Text);
            }
        }

        private void btnGeneruj_Click(object sender, EventArgs e)
        {
            UtworzOknoGrzbiety(txtIloscGrzbietow.Text);
        }

        private void UtworzOknoGrzbiety(string liczbaKontrolek)
        {
            Form oknoGrzbiety = new Form
            {
                Text = "Dodaj Grzbiety",
                Width = 270,
                Height = 400
            };

            Panel scrollablePanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true 
            };

            oknoGrzbiety.Controls.Add(scrollablePanel);

            int controlWidth = 220;
            int controlHeight = 195;
            int offset = 10;

            int ilośćKontrolek = Convert.ToInt32(liczbaKontrolek);

            grzbiety = new List<Grzbiety>();

            for (int i = 0; i < ilośćKontrolek; i++)
            {
                DodajGrzbiety dodajGrzbiety = new DodajGrzbiety
                {
                    Size = new Size(controlWidth, controlHeight),
                    Location = new Point(10, i * (controlHeight + offset)),
                    
                };

                dodajGrzbiety.UstawNazweGroupBoxa($"Grzbiet {i + 1}");

                dodaneGrzbiety.Add(dodajGrzbiety);

                scrollablePanel.Controls.Add(dodajGrzbiety);   

                if (i == ilośćKontrolek - 1)
                {
                    int endButtonY = dodajGrzbiety.Bottom + offset;

                    Button endButton = new Button
                    {
                        Text = "Zatwierdź",
                        Size = new Size(150, 40)
                    };

                    endButton.Location = new Point((oknoGrzbiety.Width - endButton.Width - 20) / 2, endButtonY);

                    endButton.Click += (sender, e) =>
                    {
                        grzbiety = dodajGrzbiety.UtworzGrzbiety(dodaneGrzbiety);
                        dodajGrzbiety.StworzPlikExcel(filePath, grzbiety);

                    };

                    scrollablePanel.Controls.Add(endButton);
                }
            }

            oknoGrzbiety.Show();
        }

       
    }
}
