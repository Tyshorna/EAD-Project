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
    public partial class FrmRespond : Form
    {
        public FrmRespond()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (rtxtRespond.Text == "")
            {
                MessageBox.Show("Please enter a response.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Your information is posted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblRespond_Click(object sender, EventArgs e)
        {

        }

        private void rtxtRespond_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
