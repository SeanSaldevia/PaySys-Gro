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
    public partial class frmHome : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = PayrollSystemDatabase.accdb; Persist Security Info = True;Jet OLEDB:Database Password = payrollsystem");
        public frmHome()
        {
            InitializeComponent();

            double count;
            double count2;
            double count3;
            double count4;
            double count5;

            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            
            string allemployee = "SELECT COUNT(*) FROM Employee_Information";
            command.CommandText = allemployee;
            count = System.Convert.ToDouble(command.ExecuteScalar());
            lblTotEm.Text = count.ToString();

            string alltimein = "SELECT COUNT(InTime) FROM Attendance_Records";
            command.CommandText = alltimein;
            count2 = System.Convert.ToDouble(command.ExecuteScalar());
            lblIn.Text = count2.ToString();

            string alltimeout = "SELECT COUNT(OutTime) FROM Attendance_Records";
            command.CommandText = alltimeout;
            count3 = System.Convert.ToDouble(command.ExecuteScalar());
            lblOut.Text = count3.ToString();

            string allatt = "SELECT COUNT(*) FROM Attendance_Records";
            command.CommandText = allatt;
            count4 = System.Convert.ToDouble(command.ExecuteScalar());
            lblAtt.Text = count4.ToString();

            string allacc = "SELECT COUNT(*) FROM Admin_Login";
            command.CommandText = allacc;
            count5 = System.Convert.ToDouble(command.ExecuteScalar());
            lblAcc.Text = count5.ToString();


            connection.Close();
        }
        private void countIn()
        {
       
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


