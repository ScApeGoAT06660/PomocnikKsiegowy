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
    public partial class NowyOpisForm : Form
    {
        ManagerOpisow managerOpisow;
        MainForm oknoGlowne;

        public NowyOpisForm(MainForm oknoGlowne, ManagerOpisow managerOpisow)
        {
            this.managerOpisow = managerOpisow;

            this.oknoGlowne = oknoGlowne;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            InitializeComponent();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            managerOpisow.Dodaj(txtNowyOpis.Text);
            oknoGlowne.btnWczytajOpisy_Click(sender, e);
        }
    }
}
