using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2PaySys
{
    public partial class frmHomepage : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = PayrollSystemDatabase.accdb; Persist Security Info = True;Jet OLEDB:Database Password = jarmjpayrollsystem");
        public frmHomepage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to exit application", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void chckShowPassword_CheckedChanged(object sender, EventArgs e)
        {
   
        }

        private void frmHomepage_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdminLogin ali = new frmAdminLogin();
            ali.Show();
            this.Hide();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            btnTimeOut attendance = new btnTimeOut();
            attendance.Show();
            this.Hide();
            MessageBox.Show("Welcome to Employee Attendance!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlTitle_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
