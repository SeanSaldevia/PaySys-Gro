using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group2PaySys
{
    public partial class frmDashboard : Form
    {
        OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = PayrollSystemDatabase.accdb; Persist Security Info = True;Jet OLEDB:Database Password = payrollsystem");
        public Point mouseLocation;
        public frmDashboard()
        {
            InitializeComponent();
            tmrDateTime.Start();    
        }
        [StructLayout(LayoutKind.Sequential)]
        private struct KBDLLHOOKSTRUCT
        {
            public Keys key;
            public int scanCode;
            public int flags;
            public int time;
            public IntPtr extra;
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hook);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string name);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern short GetAsyncKeyState(Keys key);
        //Declaring Global objects     
        private IntPtr ptrHook;
        private LowLevelKeyboardProc objKeyboardProcess;

        private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp)
        {
            if (nCode >= 0)
            {
                KBDLLHOOKSTRUCT objKeyInfo = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));

                // Disabling Windows keys 

                if (objKeyInfo.key == Keys.RWin || objKeyInfo.key == Keys.LWin || objKeyInfo.key == Keys.Tab && HasAltModifier(objKeyInfo.flags) || objKeyInfo.key == Keys.Escape && (ModifierKeys & Keys.Control) == Keys.Control)
                {
                    return (IntPtr)1; // if 0 is returned then All the above keys will be enabled
                }
            }
            return CallNextHookEx(ptrHook, nCode, wp, lp);
        }

        bool HasAltModifier(int flags)
        {
            return (flags & 0x20) == 0x20;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to exit application", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEmployee());
            pnlH.Visible = false;
            pnlA.Visible = false;
            pnlW.Visible = false;
            pnlE.Visible = true;
            pnlAS.Visible = false;
            pnlL.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                frmHomepage homepage = new frmHomepage();
                homepage.Show();
                this.Close();
                pnlH.Visible = false;
                pnlA.Visible = false;
                pnlW.Visible = false;
                pnlE.Visible = false;
                pnlAS.Visible = false;
                pnlL.Visible = true;
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new frmHome());
            pnlH.Visible = true;
            pnlA.Visible = false;
            pnlW.Visible = false;
            pnlE.Visible = false;
            pnlAS.Visible = false;
            pnlL.Visible = false;
        }
        private void mouseDown(object sender, MouseEventArgs e)
        {

        }
        private void mouseMove(object sender, MouseEventArgs e)
        {

        }
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAttendanceRecord());
            pnlH.Visible = false;
            pnlA.Visible = true;
            pnlW.Visible = false;
            pnlE.Visible = false;
            pnlAS.Visible = false;
            pnlL.Visible = false;
        }
        private void pnlDashboard_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }
        private void btnSalary_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSalaryRecord());
            pnlH.Visible = false;
            pnlA.Visible = false;
            pnlW.Visible = true;
            pnlE.Visible = false;
            pnlAS.Visible = false;
            pnlL.Visible = false;
        }
        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void frmDashboard_Load(object sender, EventArgs e)
        {
            openChildForm(new frmHome());
            ProcessModule objCurrentModule = Process.GetCurrentProcess().MainModule;
            objKeyboardProcess = new LowLevelKeyboardProc(captureKey);
            ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0);
           
          
        }
        private void btnAccountSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAccountSettings());
            pnlH.Visible = false;
            pnlA.Visible = false;
            pnlW.Visible = false;
            pnlE.Visible = false;
            pnlAS.Visible = true;
            pnlL.Visible = false;
        }
        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pnlChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            lblDay.Text = DateTime.Now.ToString("dddd");
        }
    }
}
