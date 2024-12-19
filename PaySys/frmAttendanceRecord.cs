using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;



namespace Group2PaySys
{
    public partial class frmAttendanceRecord : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = PayrollSystemDatabase.accdb; Persist Security Info = True;Jet OLEDB:Database Password = payrollsystem");
        public frmAttendanceRecord()
        {
            InitializeComponent();
            tmrDate.Start();
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from Employee_Information";
            command.CommandText = query;
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtEID.Text = reader["EID"].ToString();
            }
            connection.Close();
        }
        void text_clear()
        {
            txtEID.Clear();
        }
        private void frmAttendance_Load(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from Attendance_Records";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAttendance.DataSource = dt;
            connection.Close();
        }

        private void tmrDate_Tick(object sender, EventArgs e)
        {

        }
        private void btnEnter_Click(object sender, EventArgs e)
        {

        }
        private void txtEmployeeId_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }
        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index > -1)
            {
                DataGridViewRow selectedRow = dgvAttendance.Rows[index];
                txtEID.Text = selectedRow.Cells[0].Value.ToString();
                txtLogDate.Text = selectedRow.Cells[1].Value.ToString();
                txtTIn.Text = selectedRow.Cells[2].Value.ToString();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand commandDelete = new OleDbCommand();
                commandDelete.Connection = connection;
                string delete = "DELETE FROM Attendance_Records WHERE [EID]=@EID";
                commandDelete.CommandText = delete;
                commandDelete.Parameters.AddWithValue("@EID", txtEID.Text);
                commandDelete.ExecuteNonQuery();


                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Attendance_Records";
                command.CommandText = query;
                MessageBox.Show("Deleted Successfull!");
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAttendance.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        private void txtEmployeeId_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        private void btnAddAtt_Click(object sender, EventArgs e)
        {

        }
        private void btnExAdd_Click(object sender, EventArgs e)
        {

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand commandShow = new OleDbCommand();
                commandShow.Connection = connection;
                string qshow = "select * from Attendance_Records where EID like('" + txtSearch.Text + "%')";
                commandShow.CommandText = qshow;
                OleDbDataAdapter da = new OleDbDataAdapter(commandShow);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAttendance.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        private void btnEditAtt_Click(object sender, EventArgs e)
        {
            pnlEditAcc.Visible = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string update = "UPDATE Attendance_Records SET [LogDate]=@LogDate,[Attendance]=@Attendance WHERE [EID]=@EID";
                command.CommandText = update;
                command.Parameters.AddWithValue("LogDate", txtLogDate.Text);
                command.Parameters.AddWithValue("Attendance", txtTIn.Text);
                command.Parameters.AddWithValue("@EID", txtEID.Text);

                command.ExecuteNonQuery();

                string query = "select * from Attendance_Records";
                command.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAttendance.DataSource = dt;
                pnlEditAcc.Visible = false;
                MessageBox.Show("Save Successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
        private void btnExEdit_Click(object sender, EventArgs e)
        {
            pnlEditAcc.Visible = false;
        }
        private void pnlEditAcc_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txtEID_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtLogDate_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
