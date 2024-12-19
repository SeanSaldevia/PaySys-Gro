using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Group2PaySys
{
    public partial class btnTimeOut : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = PayrollSystemDatabase.accdb; Persist Security Info = True;Jet OLEDB:Database Password = jarmjpayrollsystem");
        public btnTimeOut()
        {
            InitializeComponent();
            tmrDateTime.Start();


        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmHomepage hp = new frmHomepage();
            hp.Show();
            this.Hide();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            lblDay.Text = DateTime.Now.ToString("dddd");
            lblDate.Text = DateTime.Now.ToString("MMM dd, yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss:tt");

            
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {

        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {

        }

        private void btnTimeIn_Click(object sender, EventArgs e)
        {
            pnlIn.Visible = true;
            pnlOut.Visible = false;
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoadAtt_Click(object sender, EventArgs e)
        {

        }

        private void txtEmployeeId_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbEID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {

        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnterEID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnterEID_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtEID_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnTimeOut_Click(object sender, EventArgs e)
        {
            pnlIn.Visible = false;
            pnlOut.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;

            if (txtEIDIN.Text == "")
            {
                MessageBox.Show("Please enter Employee ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connection.Close();
            }
            else
            {
                command.CommandText = "select * from Employee_Information where [EID]='" + txtEIDIN.Text + "' AND [Password]='" + txtPass.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {

                    reader.Close();
                    command.CommandText = "select * from Attendance_Records where [EID]='" + txtEIDIN.Text + "' and AttDate='" + DateTime.Now.ToShortDateString() + "'";

                    OleDbDataReader reader1 = command.ExecuteReader();
                    int count1 = 0;
                    while (reader1.Read())
                    {
                        count1++;
                    }
                    if (count1 == 1)
                    {
                        MessageBox.Show("You have already Time In today!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        reader1.Close();
                        string t1 = DateTime.Now.ToShortTimeString();
                        string late = "9:00:00 am";

                        if (DateTime.Parse(t1) > DateTime.Parse("8:00:00 am") && DateTime.Parse(t1) < DateTime.Parse("9:00:00 am"))
                        {

                            string query = "INSERT INTO Attendance_Records([EID],[AttDay],[AttDate],[InTime],[Late],[Absent]) VALUES" + "(@EID,@Day,@AttDate,@InTime,@Late,@Absent)";
                            OleDbCommand command2 = new OleDbCommand(query, connection);
                            command2.Parameters.AddWithValue("@EID", txtEIDIN.Text);
                            command2.Parameters.AddWithValue("@AttDay", lblDay.Text);
                            command2.Parameters.AddWithValue("@AttDate", DateTime.Now.ToShortDateString());
                            command2.Parameters.AddWithValue("@InTime", lblTime.Text);
                            command2.Parameters.AddWithValue("@Late", "No");
                            command2.Parameters.AddWithValue("@Absent", "No");

                            command2.ExecuteNonQuery();
                            MessageBox.Show("Time In Success!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            pnlIn.Visible = false;
                            string query1 = "select * from Attendance_Records";
                            command2.CommandText = query1;

                            OleDbDataAdapter da = new OleDbDataAdapter(command2);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvAttendance.DataSource = dt;

                        }
                        else if (DateTime.Parse(t1) >= DateTime.Parse("9:00:00 am") && DateTime.Parse(t1) < DateTime.Parse("10:00:00 am"))
                        {

                            string query = "INSERT INTO Attendance_Records([EID],[AttDay],[AttDate],[InTime],[Late],[Absent]) VALUES" + "(@EID,@Day,@AttDate,@InTime,@Late,@Absent)";
                            OleDbCommand command2 = new OleDbCommand(query, connection);
                            command2.Parameters.AddWithValue("@EID", txtEIDIN.Text);
                            command2.Parameters.AddWithValue("@AttDay", lblDay.Text);
                            command2.Parameters.AddWithValue("@AttDate", DateTime.Now.ToShortDateString());
                            command2.Parameters.AddWithValue("@InTime", lblTime.Text);
                            command2.Parameters.AddWithValue("@Late", "Yes");
                            command2.Parameters.AddWithValue("@Absent", "No");
                            command2.ExecuteNonQuery();
                            MessageBox.Show("Time In Success!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show("You are late!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            pnlIn.Visible = false;
                            string query1 = "select * from Attendance_Records";
                            command2.CommandText = query1;
                            OleDbDataAdapter da = new OleDbDataAdapter(command2);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvAttendance.DataSource = dt;
                        }
                        else if (DateTime.Parse(t1) >= DateTime.Parse("10:00:00 am") && DateTime.Parse(t1) < DateTime.Parse("8:00:00 pm"))
                        {
                            string query = "INSERT INTO Attendance_Records([EID],[AttDay],[AttDate],[InTime],[Late],[Absent]) VALUES" + "(@EID,@Day,@AttDate,@InTime,@Late,@Absent)";
                            OleDbCommand command2 = new OleDbCommand(query, connection);
                            command2.Parameters.AddWithValue("@EID", txtEIDIN.Text);
                            command2.Parameters.AddWithValue("@AttDay", lblDay.Text);
                            command2.Parameters.AddWithValue("@AttDate", DateTime.Now.ToShortDateString());
                            command2.Parameters.AddWithValue("@InTime", lblTime.Text);
                            command2.Parameters.AddWithValue("@Late", "No Attendance");
                            command2.Parameters.AddWithValue("@Absent", "Yes");
                            command2.ExecuteNonQuery();
                            MessageBox.Show("Time In Success!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show("You are Absent!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            pnlIn.Visible = false;
                            string query1 = "select * from Attendance_Records";
                            command2.CommandText = query1;
                            OleDbDataAdapter da = new OleDbDataAdapter(command2);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvAttendance.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Attendance Closed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect EID or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            connection.Close(); 
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;

            if (txtEIDOUT.Text == "")
            {
                MessageBox.Show("Please enter Employee ID!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                connection.Close();
            }
            else
            {
                command.CommandText = "select * from Employee_Information where [EID]='" + txtEIDOUT.Text + "' AND [Password]='" + txtPass2.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
                while (reader.Read())
                {
                    count++;
                }
                if (count == 1)
                {


                    reader.Close();
                    command.CommandText = "select * from Attendance_Records where [EID]='" + txtEIDOUT.Text + "' and AttDate='" + DateTime.Now.ToShortDateString() + "'";

                    OleDbDataReader reader1 = command.ExecuteReader();
                    int count1 = 0;
                    while (reader1.Read())
                    {
                        count1++;
                    }
                    if (count1 == 1)
                    {
                        reader1.Close();

                        OleDbCommand commandUpdateVoterCan = new OleDbCommand();
                        commandUpdateVoterCan.Connection = connection;
                        string updateVoterCan = "UPDATE Attendance_Records SET [OutTime]=@OutTime WHERE [EID]=@EID AND [AttDate]=@AttDate";
                        commandUpdateVoterCan.CommandText = updateVoterCan;
                        commandUpdateVoterCan.Parameters.AddWithValue("@OutTime", DateTime.Now.ToLongTimeString());
                        commandUpdateVoterCan.Parameters.AddWithValue("@EID", txtEIDOUT.Text);
                        commandUpdateVoterCan.Parameters.AddWithValue("@AttDate", DateTime.Now.ToShortDateString());
                        commandUpdateVoterCan.ExecuteNonQuery();
                        MessageBox.Show("Time Out Success!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pnlOut.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("You have Time In first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Employee ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            connection.Close();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            pnlIn.Visible = false;

        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            pnlOut.Visible = false;
        }

        private void txtEIDIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtEIDOUT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
