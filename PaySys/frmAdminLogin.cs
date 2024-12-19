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
    public partial class frmAdminLogin : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = PayrollSystemDatabase.accdb; Persist Security Info = True;Jet OLEDB:Database Password = jarmjpayrollsystem");
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                if (txtUsername.Text == "" || txtUsername.Text == "Type your Username" || txtPassword.Text == "" || txtPassword.Text == "Type your password")
                {
                    MessageBox.Show("Fill up empty textbox!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    connection.Close();
                }
                else
                {
                    command.CommandText = "select * from Admin_Login where Username='" + txtUsername.Text + "' and Password='" + txtPassword.Text + "'";
                    OleDbDataReader reader = command.ExecuteReader();
                    int count = 0;

                    while (reader.Read())
                    {
                        count++;
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("Welcome to Admin Dashboard!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmDashboard ad = new frmDashboard();
                        ad.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmHomepage hp = new frmHomepage();
            hp.Show();
            this.Hide();
        }

        private void chckShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chckShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void frmAdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbxUser_Click(object sender, EventArgs e)
        {

        }

        private void pbxPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
