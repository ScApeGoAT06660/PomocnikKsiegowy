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
    public partial class DescriptionForm : Form
    {
        DescriptionManager descriptionManager;

        MainForm mainForm;

        public DescriptionForm(MainForm mainForm, DescriptionManager descriptionManager)
        {
            this.descriptionManager = descriptionManager;

            this.mainForm = mainForm;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            descriptionManager.AddDescription(txtNewDescription.Text);

            mainForm.btnLoadDescriptions_Click(sender, e);
        }
    }
}
