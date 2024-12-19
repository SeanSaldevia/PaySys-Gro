using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Group2PaySys
{
    public partial class frmSalaryRecord : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = PayrollSystemDatabase.accdb; Persist Security Info = True;Jet OLEDB:Database Password = jpayrollsystem");
        public frmSalaryRecord()
        {
            InitializeComponent();
            tmrDateTime.Start();
            
        }

        private void frmSalaryRecord_Load(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from Wage_Records";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSalaryRecords.DataSource = dt;
            connection.Close();
            try
            {
                connection.Open();
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;
                string query1 = "select * from Employee_Information";
                command.CommandText = query1;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbEID.Items.Add(reader["EID"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Error " + ex);
            }

        }
        private void text_clear()
        {
            cmbEID.SelectedIndex = -1;
            txtEID.Clear();
            txtFname.Clear();
            txtLname.Clear();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
                //Title
                e.Graphics.DrawString("Pay Slip", new System.Drawing.Font("Arial", 30, FontStyle.Bold), Brushes.Black, new System.Drawing.Point(330, 50));
                //Time&Date
                e.Graphics.DrawString("Time: ", new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 310));
                e.Graphics.DrawString("Date: ", new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(50, 350));
                e.Graphics.DrawString(lblDash.Text, new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(30, 390));
                //Information
                e.Graphics.DrawString("Employee ID: ", new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 430));
                e.Graphics.DrawString("Firstname: ", new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 470));
                e.Graphics.DrawString("Lastname: ", new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 510));
                e.Graphics.DrawString(lblDash.Text, new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(30, 550));
                //Salary
                e.Graphics.DrawString("No. of work day(s): ", new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 590));
                e.Graphics.DrawString("Wage per day: ", new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 630));
                e.Graphics.DrawString("Total Wage per day: ", new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 670));
                e.Graphics.DrawString(lblDash.Text, new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(30, 710));


                e.Graphics.DrawString("Absent: ", new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 750));
                //Deduction           
                e.Graphics.DrawString("Late: ", new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 790));
                e.Graphics.DrawString("Total amount of late: ", new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 830));
                e.Graphics.DrawString(lblDash.Text, new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(30, 870));
                //Total Salary
                e.Graphics.DrawString("Total Wage: ", new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(50, 910));
                e.Graphics.DrawString(lblDash.Text, new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(30, 950));


                //Time&Date
                e.Graphics.DrawString(lblTime.Text, new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 310));
                e.Graphics.DrawString(lblDate.Text, new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new Point(300, 350));

                //Information
                e.Graphics.DrawString(txtEID.Text, new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 430));
                e.Graphics.DrawString(txtFname.Text, new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 470));
                e.Graphics.DrawString(txtLname.Text, new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 510));

                //Salary
                e.Graphics.DrawString(txtNodays.Text, new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 590));
                e.Graphics.DrawString(txtSalperday.Text, new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 630));
                e.Graphics.DrawString(txtTotSalperday.Text, new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 670));


                e.Graphics.DrawString(txtAbsent.Text, new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 750));
                //Deduction
                e.Graphics.DrawString(txtLate.Text, new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 790));
                e.Graphics.DrawString(txtTotLate.Text, new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 830));

                //Total Salary
                e.Graphics.DrawString(txtTotSal.Text, new System.Drawing.Font("Arial", 16, FontStyle.Regular), Brushes.Black, new System.Drawing.Point(300, 910));
           

            

        }
        private void btnLoad_Click(object sender, EventArgs e)
        {

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
       
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
           
        }
   
        private void btnCompute_Click(object sender, EventArgs e)
        {

        }
        private void btnExAdd_Click(object sender, EventArgs e)
        {
            pnlAddSal.Visible = false;
            txtTotSalperday.Text = "";
            txtTotLate.Text = "";
            txtNodays.Text = "";
            txtLate.Text = "";
            txtTotSal.Text = "";
            txtAbsent.Text = "";
            cmbEID.SelectedItem = -1;
            txtEID.Text = "";
        }
        private void btnAddSal_Click(object sender, EventArgs e)
        {
            pnlAddSal.Visible = true;          
        }
        private void pnlAddSal_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
 
        }
        private void cmbEID_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }
        private void cmbEID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTotSalperday.Text = "";
            txtTotLate.Text = "";
            txtNodays.Text = "";
            txtLate.Text = "";
            txtTotSal.Text = "";
            txtAbsent.Text = "";
            cmbEID.SelectedItem = -1;
            txtEID.Text = "";



            if (connection.State == ConnectionState.Closed)
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Employee_Information where EID='" + cmbEID.Text + "'";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtEID.Text = reader["EID"].ToString();
                    txtFname.Text = reader["Fname"].ToString();
                    txtLname.Text = reader["Lname"].ToString();
                    txtPosition.Text = reader["Position"].ToString();
                    txtSalperday.Text = reader["BasicWage"].ToString();
                }
                reader.Close();
                string query2 = "select * from Attendance_Records where EID='" + cmbEID.Text + "'";
                command.CommandText = query2;
                OleDbDataReader reader2 = command.ExecuteReader();
                if (reader2.Read())
                {
                    reader2.Close();
                    string daysCount = "SELECT COUNT(*) FROM Attendance_Records where EID='" + cmbEID.Text + "'";
                    command.CommandText = daysCount;
                    int wd = System.Convert.ToInt32(command.ExecuteScalar());

                    string lates = "SELECT COUNT(*) FROM Attendance_Records where [EID]='" + cmbEID.Text + "' and [Late]='" + "Yes" + "'";
                    command.CommandText = lates;               
                    int i = System.Convert.ToInt32(command.ExecuteScalar());

                    string lates2 = "SELECT COUNT(*) FROM Attendance_Records where [EID]='" + cmbEID.Text + "' and [Absent]='" + "Yes" + "'";
                    command.CommandText = lates2;               
                    int a = System.Convert.ToInt32(command.ExecuteScalar());


                    int lated = i * 20;

                    int basic = Convert.ToInt32(txtSalperday.Text);
                    int total = wd * basic;

                    int totalwage = total - lated;

                    txtTotSalperday.Text = total.ToString();
                    txtTotLate.Text = lated.ToString();
                    txtAbsent.Text = a.ToString();
                    txtNodays.Text = wd.ToString();
                    txtLate.Text = i.ToString();
                    txtTotSal.Text = totalwage.ToString();
                }
                connection.Close();   
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = connection;

            command1.CommandText = "select * from Wage_Records where EID='" + txtEID.Text + "'";
            OleDbDataReader reader = command1.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count++;
            }
            if (count == 1)
            {
                MessageBox.Show("Wage already added!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            else
            {       
                    if(txtNodays.Text == ""||txtSalperday.Text==""|| txtTotSalperday.Text==""|| txtTotSal.Text=="")
                    {
                        MessageBox.Show("Employeee does not have an attendance record yet!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string query = "INSERT INTO Wage_Records([TimeAdd],[DateAdd],[EID],[Fname],[Lname],[NoWorkingDays],[Wageperday],[Totwageperday],[Absent],[Late],[TotAmountLate],[TotWage],[Position]) VALUES" + "(@TimeAdd,@DateAdd,@EID,@Fname,@Lname,@NoWorkingDays,@Wageperday,@TotWageperday,@Absent,@Late,@TotAmountLate,@TotWage,@Position)";
                        OleDbCommand command = new OleDbCommand(query, connection);
                        command.Parameters.AddWithValue("@TimeAdd", lblTime.Text);
                        command.Parameters.AddWithValue("@DateAdd", lblDate.Text);
                        command.Parameters.AddWithValue("@EID", txtEID.Text);
                        command.Parameters.AddWithValue("@Fname", txtFname.Text);
                        command.Parameters.AddWithValue("@Lname", txtLname.Text);
                        command.Parameters.AddWithValue("@NoWorkingDays", txtNodays.Text);
                        command.Parameters.AddWithValue("@Wageperday", txtSalperday.Text);
                        command.Parameters.AddWithValue("@TotWageperday", txtTotSalperday.Text);
                        command.Parameters.AddWithValue("@Absent", txtAbsent.Text);
                        command.Parameters.AddWithValue("@Late", txtLate.Text);
                        command.Parameters.AddWithValue("@TotAmountLate", txtTotLate.Text);
                        command.Parameters.AddWithValue("@TotWage", txtTotSal.Text);
                        command.Parameters.AddWithValue("@Position", txtPosition.Text);
                        MessageBox.Show("Employee wage added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        command.ExecuteNonQuery();

                        string query1 = "select * from Wage_Records";
                        command.CommandText = query1;

                        OleDbDataAdapter da = new OleDbDataAdapter(command);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvSalaryRecords.DataSource = dt;
                        pnlAddSal.Visible = false;
                        text_clear();
                    }
                }
                connection.Close();
        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:tt");
            lblDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }
 
        private void tmrDate_Tick(object sender, EventArgs e)
        {
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblTime.Text = DateTime.Now.ToString("hh:mm:tt");
            lblDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }

        private void txtNodays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtSalperday_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtRegOT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtLate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dgvSalaryRecords_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index > -1)
            {
                DataGridViewRow selectedRow = dgvSalaryRecords.Rows[index];
                txtTime.Text = selectedRow.Cells[0].Value.ToString();
                txtDate.Text = selectedRow.Cells[1].Value.ToString();
                txtEID.Text = selectedRow.Cells[2].Value.ToString(); 
                txtFname.Text = selectedRow.Cells[3].Value.ToString();
                txtLname.Text = selectedRow.Cells[4].Value.ToString();
                txtNodays.Text = selectedRow.Cells[5].Value.ToString();
                txtSalperday.Text = selectedRow.Cells[6].Value.ToString();
                txtTotSalperday.Text = selectedRow.Cells[7].Value.ToString();
                txtAbsent.Text = selectedRow.Cells[8].Value.ToString();
                txtLate.Text = selectedRow.Cells[9].Value.ToString();
                txtTotLate.Text = selectedRow.Cells[10].Value.ToString();
                txtTotSal.Text = selectedRow.Cells[11].Value.ToString();
                txtPosition.Text = selectedRow.Cells[12].Value.ToString();
            }
        }
            private void btnDel_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand commandDelete = new OleDbCommand();
            commandDelete.Connection = connection;
            string delete = "DELETE FROM Wage_Records WHERE [EID]=@EID";
            commandDelete.CommandText = delete;
            commandDelete.Parameters.AddWithValue("@EID", txtEID.Text);
            commandDelete.ExecuteNonQuery();


            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from Wage_Records";
            command.CommandText = query;
            MessageBox.Show("Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSalaryRecords.DataSource = dt;
            connection.Close();
        }

        private void btnEditSal_Click(object sender, EventArgs e)
        {
            pnlAddSal.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCompute2_Click(object sender, EventArgs e)
        {
          
        }

        private void txtNoDays2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtSalaryPerDay2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtRegOT2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtLate2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {

        }

        private void btnExitEdit_Click(object sender, EventArgs e)
        {
  
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from Wage_Records";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSalaryRecords.DataSource = dt;
            connection.Close();
        }

        private void cmbEID2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pnlEditSal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            connection.Open();
            OleDbCommand commandShow = new OleDbCommand();
            commandShow.Connection = connection;
            string qshow = "select * from Wage_Records where EID like('" + txtSearch.Text + "%')";
            commandShow.CommandText = qshow;
            OleDbDataAdapter da = new OleDbDataAdapter(commandShow);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSalaryRecords.DataSource = dt;
            connection.Close();
        }

        private void pnlEditSal2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnExEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditSal2_Click(object sender, EventArgs e)
        {

        }

        private void btnComputeSal_Click(object sender, EventArgs e)
        {

        }

        private void btnClear3_Click(object sender, EventArgs e)
        {

        }

        private void txtTotLate3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotSal3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {

        }

        private void txtAbsent_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblT_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvSalaryRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtEID3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();

                command.Connection = connection;

                string query = "select * from Wage_Records";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSalaryRecords.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", "");
            }
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();

            command.Connection = connection;

            string query = "select * from Wage_Records where [Position]='" + "Cashier" + "'";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSalaryRecords.DataSource = dt;
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();

            command.Connection = connection;

            string query = "select * from Wage_Records where [Position]='" + "Sales Clerk" + "'";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSalaryRecords.DataSource = dt;
            connection.Close();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
          
        }
    }
}
