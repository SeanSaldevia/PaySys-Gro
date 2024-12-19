namespace Group2PaySys
{
    partial class frmAttendanceRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttendanceRecord));
            this.label1 = new System.Windows.Forms.Label();
            this.tmrDate = new System.Windows.Forms.Timer(this.components);
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnEditAtt = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.tmrAtt = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.txtTIn = new System.Windows.Forms.TextBox();
            this.lblED = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExEdit = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogDate = new System.Windows.Forms.TextBox();
            this.txtEID = new System.Windows.Forms.TextBox();
            this.pnlEditAcc = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlEditAcc.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Californian FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 55);
            this.label1.TabIndex = 284;
            this.label1.Text = "ATTENDANCE RECORDS";
            // 
            // tmrDate
            // 
            this.tmrDate.Tick += new System.EventHandler(this.tmrDate_Tick);
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.AllowUserToResizeColumns = false;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(12, 174);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttendance.Size = new System.Drawing.Size(1108, 507);
            this.dgvAttendance.TabIndex = 394;
            this.dgvAttendance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            this.dgvAttendance.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnEditAtt);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Location = new System.Drawing.Point(12, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 101);
            this.panel2.TabIndex = 418;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(23, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(99, 19);
            this.lblSearch.TabIndex = 379;
            this.lblSearch.Text = "Search EID";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtSearch.Location = new System.Drawing.Point(27, 52);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 26);
            this.txtSearch.TabIndex = 378;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // btnEditAtt
            // 
            this.btnEditAtt.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEditAtt.FlatAppearance.BorderSize = 0;
            this.btnEditAtt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAtt.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAtt.ForeColor = System.Drawing.Color.White;
            this.btnEditAtt.Location = new System.Drawing.Point(877, 23);
            this.btnEditAtt.Name = "btnEditAtt";
            this.btnEditAtt.Size = new System.Drawing.Size(108, 55);
            this.btnEditAtt.TabIndex = 412;
            this.btnEditAtt.Text = "EDIT\r\nATTENDANCE";
            this.btnEditAtt.UseVisualStyleBackColor = false;
            this.btnEditAtt.Visible = false;
            this.btnEditAtt.Click += new System.EventHandler(this.btnEditAtt_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(991, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 55);
            this.btnDelete.TabIndex = 413;
            this.btnDelete.Text = "DELETE\r\nATTENDANCE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(45, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 392;
            this.label8.Text = "Att. Time";
            // 
            // txtTIn
            // 
            this.txtTIn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtTIn.Location = new System.Drawing.Point(49, 170);
            this.txtTIn.Name = "txtTIn";
            this.txtTIn.Size = new System.Drawing.Size(168, 26);
            this.txtTIn.TabIndex = 393;
            // 
            // lblED
            // 
            this.lblED.AutoSize = true;
            this.lblED.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblED.ForeColor = System.Drawing.Color.White;
            this.lblED.Location = new System.Drawing.Point(-4, 0);
            this.lblED.Name = "lblED";
            this.lblED.Size = new System.Drawing.Size(215, 24);
            this.lblED.TabIndex = 394;
            this.lblED.Text = "EDIT ATTENDANCE";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(159, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 35);
            this.btnSave.TabIndex = 439;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExEdit
            // 
            this.btnExEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.btnExEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.btnExEdit.FlatAppearance.BorderSize = 0;
            this.btnExEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExEdit.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExEdit.ForeColor = System.Drawing.Color.White;
            this.btnExEdit.Location = new System.Drawing.Point(237, 0);
            this.btnExEdit.Name = "btnExEdit";
            this.btnExEdit.Size = new System.Drawing.Size(30, 44);
            this.btnExEdit.TabIndex = 440;
            this.btnExEdit.Text = "X";
            this.btnExEdit.UseVisualStyleBackColor = false;
            this.btnExEdit.Click += new System.EventHandler(this.btnExEdit_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(45, 46);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(108, 19);
            this.label24.TabIndex = 441;
            this.label24.Text = "Employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(45, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 445;
            this.label3.Text = "Att. Date";
            // 
            // txtLogDate
            // 
            this.txtLogDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtLogDate.Location = new System.Drawing.Point(49, 119);
            this.txtLogDate.Name = "txtLogDate";
            this.txtLogDate.Size = new System.Drawing.Size(168, 26);
            this.txtLogDate.TabIndex = 446;
            this.txtLogDate.TextChanged += new System.EventHandler(this.txtLogDate_TextChanged);
            // 
            // txtEID
            // 
            this.txtEID.Enabled = false;
            this.txtEID.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtEID.Location = new System.Drawing.Point(49, 68);
            this.txtEID.Name = "txtEID";
            this.txtEID.Size = new System.Drawing.Size(168, 26);
            this.txtEID.TabIndex = 447;
            this.txtEID.TextChanged += new System.EventHandler(this.txtEID_TextChanged);
            // 
            // pnlEditAcc
            // 
            this.pnlEditAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.pnlEditAcc.Controls.Add(this.txtEID);
            this.pnlEditAcc.Controls.Add(this.txtLogDate);
            this.pnlEditAcc.Controls.Add(this.label3);
            this.pnlEditAcc.Controls.Add(this.label24);
            this.pnlEditAcc.Controls.Add(this.btnExEdit);
            this.pnlEditAcc.Controls.Add(this.btnSave);
            this.pnlEditAcc.Controls.Add(this.lblED);
            this.pnlEditAcc.Controls.Add(this.txtTIn);
            this.pnlEditAcc.Controls.Add(this.label8);
            this.pnlEditAcc.Location = new System.Drawing.Point(1126, 12);
            this.pnlEditAcc.Name = "pnlEditAcc";
            this.pnlEditAcc.Size = new System.Drawing.Size(270, 259);
            this.pnlEditAcc.TabIndex = 442;
            this.pnlEditAcc.Visible = false;
            this.pnlEditAcc.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEditAcc_Paint);
            // 
            // frmAttendanceRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1132, 693);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlEditAcc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvAttendance);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAttendanceRecord";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlEditAcc.ResumeLayout(false);
            this.pnlEditAcc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmrDate;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Timer tmrAtt;
        private System.Windows.Forms.Button btnEditAtt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTIn;
        private System.Windows.Forms.Label lblED;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExEdit;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogDate;
        private System.Windows.Forms.TextBox txtEID;
        private System.Windows.Forms.Panel pnlEditAcc;
    }
}