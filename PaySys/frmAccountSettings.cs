using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2PaySys
{
    public partial class frmAccountSettings : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = PayrollSystemDatabase.accdb; Persist Security Info = True;Jet OLEDB:Database Password = payrollsystem");
        public frmAccountSettings()
        {
            InitializeComponent();
        }
        void text_clear()
        {
            txtEditUser.Clear();
            txtEditPass.Clear();
        }
        void text_clear2()
        {
            txtAddUser.Clear();
            txtAddPass.Clear();
        }
            private void btnLoad_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from Admin_Login";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAccountSettings.DataSource = dt;
            connection.Close();
        }

        private void btnClearAcc_Click(object sender, EventArgs e)
        {
            text_clear();
        }

        private void txtAddAcc_Click(object sender, EventArgs e)
        {
            var hasMiniMaxChars = new Regex(@".{11,30}");
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            
            if (!hasLowerChar.IsMatch(txtAddPass.Text))
            {
                MessageBox.Show("Password should contain At least one lower case letter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!hasUpperChar.IsMatch(txtAddPass.Text))
            {
                MessageBox.Show("Password should contain At least one upper case letter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!hasMiniMaxChars.IsMatch(txtAddPass.Text))
            {
                MessageBox.Show("Password should not be less than or greater than 12 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!hasNumber.IsMatch(txtAddPass.Text))
            {
                MessageBox.Show("Password should contain At least one numeric value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!hasSymbols.IsMatch(txtAddPass.Text))
            {
                MessageBox.Show("Password should contain At least one special case characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if (txtAddUser.Text == "" || txtAddPass.Text == "")
            {

                MessageBox.Show("Fill up empty textbox!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connection.Open();
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;
                command1.CommandText = "select * from Admin_Login where Username='" + txtAddUser.Text + "' and Password='" + txtAddPass.Text + "'";

                OleDbDataReader reader = command1.ExecuteReader();
                int count = 0;

                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("Account already Registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    string query = "INSERT INTO Admin_Login([Username],[Password]) VALUES" + "(@Username,@Password)";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", txtAddUser.Text);
                    command.Parameters.AddWithValue("@Password", txtAddPass.Text);
                    MessageBox.Show("Account Added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    command.ExecuteNonQuery();

                    string query1 = "select * from Admin_Login";
                    command.CommandText = query1;

                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvAccountSettings.DataSource = dt;
                    pnlAddAcc.Visible = false;
                    text_clear();
                }


                connection.Close();
            }
        }

        private void btnAddAcc_Click(object sender, EventArgs e)
        {
            pnlAddAcc.Visible = true;
            pnlEditAcc.Visible = false;
            text_clear2();
        }

        private void pnlAddAcc_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pnlAddAcc.Visible = false;
        }

        private void btnDelAcc_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand commandDelete = new OleDbCommand();
            commandDelete.Connection = connection;
            string delete = "DELETE FROM Admin_Login WHERE [Username]=@Username and [Password]=@Password";
            commandDelete.CommandText = delete;
            commandDelete.Parameters.AddWithValue("@Username", txtEditUser.Text);
            commandDelete.Parameters.AddWithValue("@Password", txtEditPass.Text);
            commandDelete.ExecuteNonQuery();


            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from Admin_Login";
            command.CommandText = query;
            MessageBox.Show("Account Deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAccountSettings.DataSource = dt;
            connection.Close();
        }

        private void btnEditAcc_Click(object sender, EventArgs e)
        {
            pnlEditAcc.Visible = true;
            pnlAddAcc.Visible = false;
        }

        private void frmAccountSettings_Load(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from Admin_Login";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAccountSettings.DataSource = dt;
            connection.Close();
        }

        private void dgvAccountSettings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index > -1)
            {
                DataGridViewRow selectedRow = dgvAccountSettings.Rows[index];
                txtEditUser.Text = selectedRow.Cells[0].Value.ToString();
                txtEditPass.Text = selectedRow.Cells[1].Value.ToString();


            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void btnExEdit_Click(object sender, EventArgs e)
        {
            pnlEditAcc.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var hasMiniMaxChars = new Regex(@".{11,30}");
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(txtEditPass.Text))
            {
                MessageBox.Show("Password should contain At least one lower case letter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!hasUpperChar.IsMatch(txtEditPass.Text))
            {
                MessageBox.Show("Password should contain At least one upper case letter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!hasMiniMaxChars.IsMatch(txtEditPass.Text))
            {
                MessageBox.Show("Password should not be less than or greater than 12 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!hasNumber.IsMatch(txtEditPass.Text))
            {
                MessageBox.Show("Password should contain At least one numeric value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!hasSymbols.IsMatch(txtEditPass.Text))
            {
                MessageBox.Show("Password should contain At least one special case characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtEditUser.Text == "" || txtEditPass.Text == "")
            {

                MessageBox.Show("Fill up empty textbox!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string update = "UPDATE Admin_Login SET [Password]=@Password WHERE [Username]=@Username";
                command.CommandText = update;
                command.Parameters.AddWithValue("@Password", txtEditPass.Text);
                command.Parameters.AddWithValue("@Username", txtEditUser.Text);



                command.ExecuteNonQuery();

                string query = "select * from Admin_Login";
                command.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAccountSettings.DataSource = dt;
                pnlEditAcc.Visible = false;
                MessageBox.Show("Account changed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pnlEditAcc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvAccountSettings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
