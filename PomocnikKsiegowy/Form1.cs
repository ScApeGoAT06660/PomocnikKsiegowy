using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public Form1()
        {
            InitializeComponent();

            this.TopMost = true;

            txtWynik.ReadOnly = true;
            txtWynikNaPol.ReadOnly = true;
        }

        private void btnWczytaj(object sender, EventArgs e)
        {
            paliwo = new Paliwo();

            paliwo.vat = Convert.ToDouble(txtVAT.Text);
            paliwo.netto = Convert.ToDouble(txtNetto.Text);

            if (rb25.Checked)
                paliwo.mnoznik = 0.25;

            if (rb75.Checked)
                paliwo.mnoznik = 0.75;

            if (chbLeasing.Checked)
                paliwo.leasing = true;

            txtWynik.Text = paliwoManager.ObliczPaliwo(paliwo);
        }

        private void btnPodziel_Click(object sender, EventArgs e)
        {
            txtWynikNaPol.Text = naPol.NaPol(txtLiczba.Text).ToString();
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
                }
            }
        }

        private void btnWczytajOpisy_Click(object sender, EventArgs e)
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
    }
}
