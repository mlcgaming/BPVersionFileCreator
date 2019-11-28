using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuddyPalVersionFileCreator
{
    public partial class ForgeDataForm : Form
    {
        private MainForm MainForm;
        public bool IsDataEntered { get; private set; }

        public ForgeDataForm(MainForm form)
        {
            InitializeComponent();
            MainForm = form;
            IsDataEntered = false;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(txtInstallationName.Text != "" && txtVersion.Text != "")
            {
                MainForm.EnterForgeDataEntry(txtVersion.Text, txtInstallationName.Text);
                IsDataEntered = true;
                Close();
            }
            else
            {
                MessageBox.Show("Fields are both Required!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
