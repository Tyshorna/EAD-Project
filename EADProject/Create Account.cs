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
    public partial class FrmCreate_Account : Form
    {
        private FrmSign_In FrmSign_In;

        public FrmCreate_Account()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
                    }

        private void btnCreate_Account_Click(object sender, EventArgs e)
        {
            if (txtFirst_Name.Text == "")
            {
                MessageBox.Show("Please enter your first name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFirst_Name.Focus();
            }
            else if (txtLast_Name.Text == "")
            {
                MessageBox.Show("Please enter your last name.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLast_Name.Focus();
            }
            else if (txtId_Number.Text == "")
            {
                MessageBox.Show("Please enter your id number.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtId_Number.Focus();
            }
            else if (txtEmail_Address.Text == "")
            {
                MessageBox.Show("Please enter your email address.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail_Address.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
            }
            else if (txtConfirm_Password.Text == "")
            {
                MessageBox.Show("Please enter your password again for confirmation.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtConfirm_Password.Focus();
            }
            else
            {
            this.Hide();
            FrmSign_In = new FrmSign_In();
            FrmSign_In.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtConfirm_Password.Text = "";
            txtEmail_Address.Text = "";
            txtFirst_Name.Text = "";
            txtLast_Name.Text = "";
            txtId_Number.Text = "";
            txtPassword.Text = "";
        }

        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
