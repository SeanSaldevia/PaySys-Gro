using System;
using System.Data;
using System.Data.OleDb;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Group2PaySys
{
    public partial class frmEmployee : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = PayrollSystemDatabase.accdb; Persist Security Info = True;Jet OLEDB:Database Password = payrollsystem");
        public frmEmployee()
        {
            InitializeComponent();

        }
        void text_clear()
        {
            txtEmployeeId.Clear();
            txtFname.Clear();
            txtLname.Clear();
            txtAddress.Clear();
            txtContactNo.Clear();
            cmbSex.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            txtPass.Clear();

            txtBSal.Clear();
        }
        void text_clear2()
        {
            txtEID.Clear();
            txtFname2.Clear();
            txtLname2.Clear();
            txtAddress2.Clear();
            txtCn.Clear();
            cmbSex.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
            txtPass2.Clear();

            txtBSal2.Clear();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from Employee_Information";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEmployee.DataSource = dt;
            connection.Close();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            pnlAddEm.Visible = true;
            pnlEdit.Visible = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from Employee_Information";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEmployee.DataSource = dt;
            connection.Close();
        }   

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
          

        }   

        private void dgvEmployee_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnEditEm_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = true;
            pnlAddEm.Visible = false;
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;

            if (index > -1)
            {
                DataGridViewRow selectedRow = dgvEmployee.Rows[index];
                txtEID.Text = selectedRow.Cells[0].Value.ToString();
                txtFname2.Text = selectedRow.Cells[1].Value.ToString();
                txtLname2.Text = selectedRow.Cells[2].Value.ToString();
                txtAddress2.Text = selectedRow.Cells[3].Value.ToString();
                txtCn.Text = selectedRow.Cells[4].Value.ToString();
                cmbSex2.SelectedItem = selectedRow.Cells[5].Value.ToString();
                cmbPosition2.SelectedItem = selectedRow.Cells[6].Value.ToString();
                txtBSal2.Text = selectedRow.Cells[7].Value.ToString();
                txtPass2.Text = selectedRow.Cells[8].Value.ToString();
            }
          }
      
        

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            text_clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var hasMiniMaxChars = new Regex(@".{11,30}");
                var hasNumber = new Regex(@"[0-9]+");
                var hasUpperChar = new Regex(@"[A-Z]+");
                var hasLowerChar = new Regex(@"[a-z]+");
                var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

                if (!hasMiniMaxChars.IsMatch(txtCn.Text))
                {
                    MessageBox.Show("Contact Number must be exactly 11 numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!hasLowerChar.IsMatch(txtPass2.Text))
                {
                    MessageBox.Show("Password should contain At least one lower case letter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!hasUpperChar.IsMatch(txtPass2.Text))
                {
                    MessageBox.Show("Password should contain At least one upper case letter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!hasMiniMaxChars.IsMatch(txtPass2.Text))
                {
                    MessageBox.Show("Password should not be less than or greater than 12 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!hasNumber.IsMatch(txtPass2.Text))
                {
                    MessageBox.Show("Password should contain At least one numeric value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!hasSymbols.IsMatch(txtPass2.Text))
                {
                    MessageBox.Show("Password should contain At least one special case characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtFname2.Text == "" || txtLname2.Text == "" || txtAddress2.Text == "" || txtEID.Text == "" || txtCn.Text == "" || cmbSex2.SelectedItem == "" || cmbPosition2.SelectedItem == "" || txtBSal2.Text == "" || txtPass2.Text == "")
                {

                    MessageBox.Show("Fill up empty textbox!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    string update = "UPDATE Employee_Information SET [Fname]=@Fname,[Lname]=@Lname,[Address]=@Address,[ContactNo]=@ContactNo,[Sex]=@Sex,[Position]=@Position,[BasicWage]=@BasicWage,[Password]=@Password WHERE [EID]=@EID";
                    command.CommandText = update;
                    command.Parameters.AddWithValue("@Fname", txtFname2.Text);
                    command.Parameters.AddWithValue("@Lname", txtLname2.Text);
                    command.Parameters.AddWithValue("@Address", txtAddress2.Text);
                    command.Parameters.AddWithValue("@ContactNo", txtCn.Text);
                    command.Parameters.AddWithValue("@Sex", cmbSex2.SelectedItem);
                    command.Parameters.AddWithValue("@Position", cmbPosition2.SelectedItem);
                    command.Parameters.AddWithValue("@BasicWage", txtBSal2.Text);
                    command.Parameters.AddWithValue("@Password", txtPass2.Text);
                    command.Parameters.AddWithValue("@EID", txtEID.Text);
                    command.ExecuteNonQuery();

                    string query = "select * from Employee_Information";
                    command.CommandText = query;
                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvEmployee.DataSource = dt;
                    pnlEdit.Visible = false;
                    MessageBox.Show("Employee data update Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        private void btnExEdit_Click(object sender, EventArgs e)
        {
             pnlEdit.Visible = false;
        }

        private void dtpDOB2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            connection.Open();
            OleDbCommand commandShow = new OleDbCommand();
            commandShow.Connection = connection;
            string qshow = "select * from Employee_Information where EID like('" + txtSearch.Text + "%')";
            commandShow.CommandText = qshow;
            OleDbDataAdapter da = new OleDbDataAdapter(commandShow);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEmployee.DataSource = dt;
            connection.Close();
        }

        private void upPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtEmployeeId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddEm_Click(object sender, EventArgs e)
        {
            var hasMiniMaxChars = new Regex(@".{11,30}");
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
            try
            {
                
                if (!hasMiniMaxChars.IsMatch(txtContactNo.Text))
                {
                    MessageBox.Show("Contact Number must be exactly 11 numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(!hasLowerChar.IsMatch(txtPass.Text))
                {
                    MessageBox.Show("Password should contain At least one lower case letter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!hasUpperChar.IsMatch(txtPass.Text))
                {
                    MessageBox.Show("Password should contain At least one upper case letter!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!hasMiniMaxChars.IsMatch(txtPass.Text))
                {
                    MessageBox.Show("Password should not be less than or greater than 12 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!hasNumber.IsMatch(txtPass.Text))
                {
                    MessageBox.Show("Password should contain At least one numeric value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!hasSymbols.IsMatch(txtPass.Text))
                {
                    MessageBox.Show("Password should contain At least one special case characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtFname.Text == "" || txtLname.Text == "" || txtAddress.Text == "" || txtEmployeeId.Text == "" || txtContactNo.Text == "" || cmbSex.SelectedItem == "" || cmbPosition.SelectedItem == ""|| txtBSal.Text == "" || txtPass.Text == "")
                {

                    MessageBox.Show("Fill up empty textbox!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    connection.Open();
                    OleDbCommand command1 = new OleDbCommand();
                    command1.Connection = connection;

                    command1.CommandText = "select * from Employee_Information where EID='" + txtEmployeeId.Text + "'";
                    OleDbDataReader reader = command1.ExecuteReader();
                    int count = 0;

                    while (reader.Read())
                    {
                        count++;
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("Employee ID already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string query = "INSERT INTO Employee_Information([EID],[Fname],[Lname],[Address],[ContactNo],[Sex],[Position],[BasicWage],[Password]) VALUES" + "(@EID,@Fname,@Lname,@Adress,@ContactNo,@Sex,@Position,@BasicWage,@Password)";
                        OleDbCommand command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("@EID", txtEmployeeId.Text);
                        command.Parameters.AddWithValue("@Fname", txtFname.Text);
                        command.Parameters.AddWithValue("@Lname", txtLname.Text);
                        command.Parameters.AddWithValue("@Address", txtAddress.Text);
                        command.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                        command.Parameters.AddWithValue("@Sex", cmbSex.SelectedItem);
                        command.Parameters.AddWithValue("@Position", cmbPosition.SelectedItem);
                        command.Parameters.AddWithValue("@BasicWage", txtBSal.Text);
                        command.Parameters.AddWithValue("@Password", txtPass.Text);

                        MessageBox.Show("Employee Data Added!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        command.ExecuteNonQuery();

                        string query1 = "select * from Employee_Information";
                        command.CommandText = query1;

                        OleDbDataAdapter da = new OleDbDataAdapter(command);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvEmployee.DataSource = dt;
                        text_clear();
                        pnlAddEm.Visible = false;
                    }


                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

        }

        private void btnExAdd_Click(object sender, EventArgs e)
        {
            pnlAddEm.Visible = false;
        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtContactNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnClear2_Click_1(object sender, EventArgs e)
        {
            text_clear2();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand commandDelete = new OleDbCommand();
                commandDelete.Connection = connection;
                string delete = "DELETE FROM Employee_Information WHERE [EID]=@EID";
                commandDelete.CommandText = delete;
                commandDelete.Parameters.AddWithValue("@EID", txtEID.Text);
                commandDelete.ExecuteNonQuery();


                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Employee_Information";
                command.CommandText = query;
                MessageBox.Show("Employee data Deleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEmployee.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void pnlAddEm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cmbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cashier = 450;
            int salesclerk = 400;
            int trustedworkers = 500;
            if (cmbPosition.Text == "Cashier")
            {
                txtBSal.Text = cashier.ToString();
            }
            else if (cmbPosition.Text == "Sales Clerk")
            {
                txtBSal.Text = salesclerk.ToString();
            }
            else if (cmbPosition.Text == "Trusted Workers")
            {
                txtBSal.Text = trustedworkers.ToString();
            }
        }

        private void txtBSal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmployeeId_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmployeeId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtEID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
