using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Files_Renamer.NET
{
    public partial class FormWarrenty : Form
    {
        public FormWarrenty()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkAccept_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAccept.Checked)
                buttonOK.Enabled = true;
            else
                buttonOK.Enabled = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}