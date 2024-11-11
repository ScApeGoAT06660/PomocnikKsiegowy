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
    public partial class Form2 : Form
    {
        ManagerOpisow managerOpisów;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            managerOpisów.Dodaj(txtNowyOpis.Text);
        }
    }
}
