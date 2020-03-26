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
    public partial class FrmSign_In : Form
    {
        private FrmCreate_Account FrmCreate_Account;
        private FrmCitizen_Report FrmCitizen_Report;

        public FrmSign_In()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCreate_Account = new FrmCreate_Account();
            FrmCreate_Account.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtId_Number.Text == "")
            {
                MessageBox.Show("Please enter your id number.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You are logged in to your account. This will also bring you to the  Citizen Report form.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FrmCitizen_Report = new FrmCitizen_Report();
                FrmCitizen_Report.Show();
            }
        }
    }
}
