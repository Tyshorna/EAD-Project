using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EADProject
{
    public partial class FrmCitizen_Report : Form
    {
        private FrmSign_In FrmSign_In;
        public FrmCitizen_Report()
        {
            InitializeComponent();
        }

        private void lblCrime_Click(object sender, EventArgs e)
        {

        }

        private void cboCrime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cboCrimeCommitted.Text == "")
            {
                MessageBox.Show("Please enter the crime committed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtLocation.Text == "")
            {
                MessageBox.Show("Please enter the location.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rtxtDescription.Text == "")
            {
                MessageBox.Show("Please enter the description.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your report is submitted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FrmSign_In = new FrmSign_In();
                FrmSign_In.Show();
            }
            else if (result == DialogResult.No)
            {
                
            }
            else if (result == DialogResult.Cancel)
            {
                
            }

            /* if (System.Windows.Forms.Application.MessageLoop)
             {
                 System.Windows.Forms.Application.Exit();
             }
             else
             {
                 System.Environment.Exit(1);
             }*/
        }
    }
}
