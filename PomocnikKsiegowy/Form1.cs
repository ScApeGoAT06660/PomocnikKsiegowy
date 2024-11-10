using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomocnikKsiegowy
{
    public partial class Form1 : Form
    {
        PaliwoManager paliwoManager = new PaliwoManager();
        Paliwo paliwo;

        PiedziesiatProcent naPol = new PiedziesiatProcent();

        ManagerKalkulator managerKalkulator = new ManagerKalkulator();
        Kalkulator kalkulator = new Kalkulator();

        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
            txtWynikKalkulator.Focus();
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
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button klikniety = (Button)sender;

            kalkulator.operators = Convert.ToChar(klikniety.Text);
            kalkulator.storageNumber = Convert.ToDouble(txtWynikKalkulator.Text);

            txtWynikKalkulator.Text = "";
        }

        private void btnWynikKalkulator_Click(object sender, EventArgs e)
        {
            kalkulator.secondNumber = Convert.ToDouble(txtWynikKalkulator.Text);

            txtWynikKalkulator.Text =  managerKalkulator.Oblicz(kalkulator).ToString();
        }
    }
}
