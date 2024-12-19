namespace Group2PaySys
{
    partial class frmSalaryRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalaryRecord));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSalaryRecords = new System.Windows.Forms.DataGridView();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddSal = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.pnlAddSal = new System.Windows.Forms.Panel();
            this.lblDay = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAbsent = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.cmbEID = new System.Windows.Forms.ComboBox();
            this.txtTotSalperday = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTotSal = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtTotLate = new System.Windows.Forms.TextBox();
            this.txtEID = new System.Windows.Forms.TextBox();
            this.txtLate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNodays = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExAdd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.txtSalperday = new System.Windows.Forms.TextBox();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.lblDash = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryRecords)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlAddSal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Californian FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 55);
            this.label2.TabIndex = 284;
            this.label2.Text = "WAGE RECORDS";
            // 
            // dgvSalaryRecords
            // 
            this.dgvSalaryRecords.AllowUserToAddRows = false;
            this.dgvSalaryRecords.AllowUserToDeleteRows = false;
            this.dgvSalaryRecords.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalaryRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalaryRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalaryRecords.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalaryRecords.Location = new System.Drawing.Point(12, 233);
            this.dgvSalaryRecords.Name = "dgvSalaryRecords";
            this.dgvSalaryRecords.ReadOnly = true;
            this.dgvSalaryRecords.RowHeadersWidth = 51;
            this.dgvSalaryRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalaryRecords.Size = new System.Drawing.Size(1108, 448);
            this.dgvSalaryRecords.TabIndex = 320;
            this.dgvSalaryRecords.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalaryRecords_CellClick);
            this.dgvSalaryRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalaryRecords_CellContentClick);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Tomato;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Location = new System.Drawing.Point(876, 25);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(108, 55);
            this.btnPrint.TabIndex = 398;
            this.btnPrint.Text = "PRINT PAYSLIP";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnAddSal);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Location = new System.Drawing.Point(12, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 99);
            this.panel2.TabIndex = 419;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 379;
            this.label8.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtSearch.Location = new System.Drawing.Point(26, 54);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 26);
            this.txtSearch.TabIndex = 378;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // btnAddSal
            // 
            this.btnAddSal.BackColor = System.Drawing.Color.Gold;
            this.btnAddSal.FlatAppearance.BorderSize = 0;
            this.btnAddSal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnAddSal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSal.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddSal.Location = new System.Drawing.Point(762, 25);
            this.btnAddSal.Name = "btnAddSal";
            this.btnAddSal.Size = new System.Drawing.Size(108, 55);
            this.btnAddSal.TabIndex = 411;
            this.btnAddSal.Text = "ADD WAGE";
            this.btnAddSal.UseVisualStyleBackColor = false;
            this.btnAddSal.Click += new System.EventHandler(this.btnAddSal_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Maroon;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDel.Location = new System.Drawing.Point(990, 25);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(108, 55);
            this.btnDel.TabIndex = 413;
            this.btnDel.Text = "DELETE WAGE";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // pnlAddSal
            // 
            this.pnlAddSal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.pnlAddSal.Controls.Add(this.lblDay);
            this.pnlAddSal.Controls.Add(this.label10);
            this.pnlAddSal.Controls.Add(this.label7);
            this.pnlAddSal.Controls.Add(this.txtPosition);
            this.pnlAddSal.Controls.Add(this.label1);
            this.pnlAddSal.Controls.Add(this.txtAbsent);
            this.pnlAddSal.Controls.Add(this.txtDate);
            this.pnlAddSal.Controls.Add(this.txtTime);
            this.pnlAddSal.Controls.Add(this.cmbEID);
            this.pnlAddSal.Controls.Add(this.txtTotSalperday);
            this.pnlAddSal.Controls.Add(this.label3);
            this.pnlAddSal.Controls.Add(this.label19);
            this.pnlAddSal.Controls.Add(this.txtTotSal);
            this.pnlAddSal.Controls.Add(this.label25);
            this.pnlAddSal.Controls.Add(this.txtTotLate);
            this.pnlAddSal.Controls.Add(this.txtEID);
            this.pnlAddSal.Controls.Add(this.txtLate);
            this.pnlAddSal.Controls.Add(this.label11);
            this.pnlAddSal.Controls.Add(this.label21);
            this.pnlAddSal.Controls.Add(this.lblTime);
            this.pnlAddSal.Controls.Add(this.lblDate);
            this.pnlAddSal.Controls.Add(this.label12);
            this.pnlAddSal.Controls.Add(this.label6);
            this.pnlAddSal.Controls.Add(this.txtLname);
            this.pnlAddSal.Controls.Add(this.label5);
            this.pnlAddSal.Controls.Add(this.txtFname);
            this.pnlAddSal.Controls.Add(this.label4);
            this.pnlAddSal.Controls.Add(this.txtNodays);
            this.pnlAddSal.Controls.Add(this.label18);
            this.pnlAddSal.Controls.Add(this.label9);
            this.pnlAddSal.Controls.Add(this.btnExAdd);
            this.pnlAddSal.Controls.Add(this.btnAdd);
            this.pnlAddSal.Controls.Add(this.label23);
            this.pnlAddSal.Controls.Add(this.txtSalperday);
            this.pnlAddSal.Location = new System.Drawing.Point(229, 233);
            this.pnlAddSal.Name = "pnlAddSal";
            this.pnlAddSal.Size = new System.Drawing.Size(653, 299);
            this.pnlAddSal.TabIndex = 420;
            this.pnlAddSal.Visible = false;
            this.pnlAddSal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddSal_Paint);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.lblDay.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.Location = new System.Drawing.Point(348, 6);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(36, 19);
            this.lblDay.TabIndex = 426;
            this.lblDay.Text = "{?}";
            this.lblDay.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(240, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 425;
            this.label10.Text = "Absent";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 424;
            this.label7.Text = "Position";
            // 
            // txtPosition
            // 
            this.txtPosition.Enabled = false;
            this.txtPosition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.ForeColor = System.Drawing.Color.Black;
            this.txtPosition.Location = new System.Drawing.Point(41, 218);
            this.txtPosition.MaxLength = 11;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(168, 27);
            this.txtPosition.TabIndex = 423;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(240, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 422;
            // 
            // txtAbsent
            // 
            this.txtAbsent.Enabled = false;
            this.txtAbsent.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbsent.ForeColor = System.Drawing.Color.Black;
            this.txtAbsent.Location = new System.Drawing.Point(244, 65);
            this.txtAbsent.MaxLength = 11;
            this.txtAbsent.Name = "txtAbsent";
            this.txtAbsent.Size = new System.Drawing.Size(168, 27);
            this.txtAbsent.TabIndex = 421;
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.Black;
            this.txtDate.Location = new System.Drawing.Point(233, 218);
            this.txtDate.MaxLength = 5;
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(61, 26);
            this.txtDate.TabIndex = 420;
            this.txtDate.Visible = false;
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.ForeColor = System.Drawing.Color.Black;
            this.txtTime.Location = new System.Drawing.Point(307, 218);
            this.txtTime.MaxLength = 5;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(77, 26);
            this.txtTime.TabIndex = 419;
            this.txtTime.Visible = false;
            // 
            // cmbEID
            // 
            this.cmbEID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEID.FormattingEnabled = true;
            this.cmbEID.Location = new System.Drawing.Point(42, 65);
            this.cmbEID.Name = "cmbEID";
            this.cmbEID.Size = new System.Drawing.Size(168, 27);
            this.cmbEID.TabIndex = 408;
            this.cmbEID.SelectedIndexChanged += new System.EventHandler(this.cmbEID_SelectedIndexChanged);
            this.cmbEID.SelectionChangeCommitted += new System.EventHandler(this.cmbEID_SelectionChangeCommitted);
            // 
            // txtTotSalperday
            // 
            this.txtTotSalperday.Enabled = false;
            this.txtTotSalperday.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotSalperday.ForeColor = System.Drawing.Color.Black;
            this.txtTotSalperday.Location = new System.Drawing.Point(445, 167);
            this.txtTotSalperday.MaxLength = 5;
            this.txtTotSalperday.Name = "txtTotSalperday";
            this.txtTotSalperday.Size = new System.Drawing.Size(167, 27);
            this.txtTotSalperday.TabIndex = 393;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(442, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 401;
            this.label3.Text = "Total Wage";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(444, 146);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(171, 19);
            this.label19.TabIndex = 392;
            this.label19.Text = "Total Wage per day";
            // 
            // txtTotSal
            // 
            this.txtTotSal.Enabled = false;
            this.txtTotSal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotSal.ForeColor = System.Drawing.Color.Black;
            this.txtTotSal.Location = new System.Drawing.Point(444, 219);
            this.txtTotSal.MaxLength = 11;
            this.txtTotSal.Name = "txtTotSal";
            this.txtTotSal.Size = new System.Drawing.Size(168, 27);
            this.txtTotSal.TabIndex = 402;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(240, 148);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(189, 19);
            this.label25.TabIndex = 384;
            this.label25.Text = "Total Amount of Late";
            // 
            // txtTotLate
            // 
            this.txtTotLate.Enabled = false;
            this.txtTotLate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotLate.ForeColor = System.Drawing.Color.Black;
            this.txtTotLate.Location = new System.Drawing.Point(244, 169);
            this.txtTotLate.MaxLength = 11;
            this.txtTotLate.Name = "txtTotLate";
            this.txtTotLate.Size = new System.Drawing.Size(168, 27);
            this.txtTotLate.TabIndex = 396;
            // 
            // txtEID
            // 
            this.txtEID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtEID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEID.Enabled = false;
            this.txtEID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtEID.Location = new System.Drawing.Point(307, 6);
            this.txtEID.MaxLength = 11;
            this.txtEID.Name = "txtEID";
            this.txtEID.Size = new System.Drawing.Size(105, 19);
            this.txtEID.TabIndex = 418;
            this.txtEID.Visible = false;
            this.txtEID.TextChanged += new System.EventHandler(this.txtEID_TextChanged);
            // 
            // txtLate
            // 
            this.txtLate.Enabled = false;
            this.txtLate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLate.ForeColor = System.Drawing.Color.Black;
            this.txtLate.Location = new System.Drawing.Point(244, 119);
            this.txtLate.MaxLength = 2;
            this.txtLate.Name = "txtLate";
            this.txtLate.Size = new System.Drawing.Size(168, 27);
            this.txtLate.TabIndex = 397;
            this.txtLate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLate_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(147, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 19);
            this.label11.TabIndex = 412;
            this.label11.Text = "Time:";
            this.label11.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(240, 95);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 19);
            this.label21.TabIndex = 381;
            this.label21.Text = "Late";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.lblTime.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(207, 23);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 19);
            this.lblTime.TabIndex = 414;
            this.lblTime.Text = "{?}";
            this.lblTime.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.lblDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(207, 1);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 19);
            this.lblDate.TabIndex = 411;
            this.lblDate.Text = "{?}";
            this.lblDate.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.label12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(147, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 19);
            this.label12.TabIndex = 413;
            this.label12.Text = "Date:";
            this.label12.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 407;
            this.label6.Text = "Employee ID";
            // 
            // txtLname
            // 
            this.txtLname.Enabled = false;
            this.txtLname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.ForeColor = System.Drawing.Color.Black;
            this.txtLname.Location = new System.Drawing.Point(42, 166);
            this.txtLname.MaxLength = 11;
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(168, 27);
            this.txtLname.TabIndex = 406;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 405;
            this.label5.Text = "Lastname";
            // 
            // txtFname
            // 
            this.txtFname.Enabled = false;
            this.txtFname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.ForeColor = System.Drawing.Color.Black;
            this.txtFname.Location = new System.Drawing.Point(42, 116);
            this.txtFname.MaxLength = 11;
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(168, 27);
            this.txtFname.TabIndex = 404;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 403;
            this.label4.Text = "Firstname";
            // 
            // txtNodays
            // 
            this.txtNodays.Enabled = false;
            this.txtNodays.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNodays.ForeColor = System.Drawing.Color.Black;
            this.txtNodays.Location = new System.Drawing.Point(445, 66);
            this.txtNodays.MaxLength = 2;
            this.txtNodays.Name = "txtNodays";
            this.txtNodays.Size = new System.Drawing.Size(167, 27);
            this.txtNodays.TabIndex = 380;
            this.txtNodays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNodays_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(442, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(171, 19);
            this.label18.TabIndex = 378;
            this.label18.Text = "No. of Work day(s)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 24);
            this.label9.TabIndex = 395;
            this.label9.Text = "ADD WAGE";
            // 
            // btnExAdd
            // 
            this.btnExAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.btnExAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.btnExAdd.FlatAppearance.BorderSize = 0;
            this.btnExAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExAdd.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExAdd.ForeColor = System.Drawing.Color.White;
            this.btnExAdd.Location = new System.Drawing.Point(620, 3);
            this.btnExAdd.Name = "btnExAdd";
            this.btnExAdd.Size = new System.Drawing.Size(30, 44);
            this.btnExAdd.TabIndex = 394;
            this.btnExAdd.Text = "X";
            this.btnExAdd.UseVisualStyleBackColor = false;
            this.btnExAdd.Click += new System.EventHandler(this.btnExAdd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(542, 261);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 35);
            this.btnAdd.TabIndex = 378;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(444, 96);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(117, 19);
            this.label23.TabIndex = 386;
            this.label23.Text = "Wage per day";
            // 
            // txtSalperday
            // 
            this.txtSalperday.Enabled = false;
            this.txtSalperday.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalperday.ForeColor = System.Drawing.Color.Black;
            this.txtSalperday.Location = new System.Drawing.Point(445, 116);
            this.txtSalperday.MaxLength = 3;
            this.txtSalperday.Name = "txtSalperday";
            this.txtSalperday.Size = new System.Drawing.Size(167, 27);
            this.txtSalperday.TabIndex = 385;
            this.txtSalperday.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalperday_KeyPress);
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDate_Tick);
            // 
            // lblDash
            // 
            this.lblDash.AutoSize = true;
            this.lblDash.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDash.Location = new System.Drawing.Point(309, 8);
            this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(1260, 38);
            this.lblDash.TabIndex = 422;
            this.lblDash.Text = "---------------------------------------------------------------------------------" +
    "----------------------------------------------------------\r\n\r\n";
            this.lblDash.Visible = false;
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.Gold;
            this.btnCash.FlatAppearance.BorderSize = 0;
            this.btnCash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCash.Location = new System.Drawing.Point(126, 172);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(108, 55);
            this.btnCash.TabIndex = 415;
            this.btnCash.Text = "CASHIER";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(240, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 55);
            this.button2.TabIndex = 423;
            this.button2.Text = "SALES CLERK";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Gold;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAll.Location = new System.Drawing.Point(12, 172);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(108, 55);
            this.btnAll.TabIndex = 424;
            this.btnAll.Text = "ALL";
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // frmSalaryRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1132, 693);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.pnlAddSal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDash);
            this.Controls.Add(this.dgvSalaryRecords);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalaryRecord";
            this.Load += new System.EventHandler(this.frmSalaryRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryRecords)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlAddSal.ResumeLayout(false);
            this.pnlAddSal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSalaryRecords;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddSal;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel pnlAddSal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTotSalperday;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNodays;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtSalperday;
        private System.Windows.Forms.TextBox txtTotSal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer tmrDateTime;
        private System.Windows.Forms.TextBox txtEID;
        private System.Windows.Forms.Label lblDash;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtTotLate;
        private System.Windows.Forms.TextBox txtLate;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAbsent;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDay;
    }
}