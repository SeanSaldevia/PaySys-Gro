namespace Group2PaySys
{
    partial class frmAccountSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountSettings));
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAccountSettings = new System.Windows.Forms.DataGridView();
            this.btnDelAcc = new System.Windows.Forms.Button();
            this.btnEditAcc = new System.Windows.Forms.Button();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pnlAddAcc = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtAddAcc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlEditAcc = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExEdit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEditPass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountSettings)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlAddAcc.SuspendLayout();
            this.pnlEditAcc.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Californian FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(507, 55);
            this.label2.TabIndex = 284;
            this.label2.Text = "ACCOUNT SETTINGS";
            // 
            // dgvAccountSettings
            // 
            this.dgvAccountSettings.AllowUserToAddRows = false;
            this.dgvAccountSettings.AllowUserToDeleteRows = false;
            this.dgvAccountSettings.AllowUserToResizeRows = false;
            this.dgvAccountSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccountSettings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountSettings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvAccountSettings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.dgvAccountSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountSettings.Location = new System.Drawing.Point(12, 174);
            this.dgvAccountSettings.Name = "dgvAccountSettings";
            this.dgvAccountSettings.ReadOnly = true;
            this.dgvAccountSettings.Size = new System.Drawing.Size(1108, 507);
            this.dgvAccountSettings.TabIndex = 391;
            this.dgvAccountSettings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccountSettings_CellClick);
            this.dgvAccountSettings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccountSettings_CellContentClick);
            // 
            // btnDelAcc
            // 
            this.btnDelAcc.BackColor = System.Drawing.Color.Maroon;
            this.btnDelAcc.FlatAppearance.BorderSize = 0;
            this.btnDelAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelAcc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAcc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelAcc.Location = new System.Drawing.Point(986, 25);
            this.btnDelAcc.Name = "btnDelAcc";
            this.btnDelAcc.Size = new System.Drawing.Size(108, 55);
            this.btnDelAcc.TabIndex = 396;
            this.btnDelAcc.Text = "DELETE\r\nACCOUNT";
            this.btnDelAcc.UseVisualStyleBackColor = false;
            this.btnDelAcc.Click += new System.EventHandler(this.btnDelAcc_Click);
            // 
            // btnEditAcc
            // 
            this.btnEditAcc.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditAcc.FlatAppearance.BorderSize = 0;
            this.btnEditAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAcc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAcc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditAcc.Location = new System.Drawing.Point(872, 25);
            this.btnEditAcc.Name = "btnEditAcc";
            this.btnEditAcc.Size = new System.Drawing.Size(108, 55);
            this.btnEditAcc.TabIndex = 395;
            this.btnEditAcc.Text = "EDIT ACCOUNT";
            this.btnEditAcc.UseVisualStyleBackColor = false;
            this.btnEditAcc.Click += new System.EventHandler(this.btnEditAcc_Click);
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAddAcc.FlatAppearance.BorderSize = 0;
            this.btnAddAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAcc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAcc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddAcc.Location = new System.Drawing.Point(758, 25);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(108, 55);
            this.btnAddAcc.TabIndex = 394;
            this.btnAddAcc.Text = "ADD ACCOUNT";
            this.btnAddAcc.UseVisualStyleBackColor = false;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.btnDelAcc);
            this.panel2.Controls.Add(this.btnEditAcc);
            this.panel2.Controls.Add(this.btnAddAcc);
            this.panel2.Location = new System.Drawing.Point(12, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1108, 101);
            this.panel2.TabIndex = 441;
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
            // pnlAddAcc
            // 
            this.pnlAddAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.pnlAddAcc.Controls.Add(this.btnExit);
            this.pnlAddAcc.Controls.Add(this.txtAddAcc);
            this.pnlAddAcc.Controls.Add(this.label5);
            this.pnlAddAcc.Controls.Add(this.txtAddUser);
            this.pnlAddAcc.Controls.Add(this.label1);
            this.pnlAddAcc.Controls.Add(this.txtAddPass);
            this.pnlAddAcc.Controls.Add(this.label4);
            this.pnlAddAcc.Location = new System.Drawing.Point(443, 197);
            this.pnlAddAcc.Name = "pnlAddAcc";
            this.pnlAddAcc.Size = new System.Drawing.Size(270, 238);
            this.pnlAddAcc.TabIndex = 438;
            this.pnlAddAcc.Visible = false;
            this.pnlAddAcc.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddAcc_Paint);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(237, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 44);
            this.btnExit.TabIndex = 440;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtAddAcc
            // 
            this.txtAddAcc.BackColor = System.Drawing.Color.DarkGreen;
            this.txtAddAcc.FlatAppearance.BorderSize = 0;
            this.txtAddAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtAddAcc.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddAcc.ForeColor = System.Drawing.Color.White;
            this.txtAddAcc.Location = new System.Drawing.Point(190, 200);
            this.txtAddAcc.Name = "txtAddAcc";
            this.txtAddAcc.Size = new System.Drawing.Size(77, 35);
            this.txtAddAcc.TabIndex = 439;
            this.txtAddAcc.Text = "ADD";
            this.txtAddAcc.UseVisualStyleBackColor = false;
            this.txtAddAcc.Click += new System.EventHandler(this.txtAddAcc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 26);
            this.label5.TabIndex = 394;
            this.label5.Text = "ADD ACCOUNT";
            // 
            // txtAddUser
            // 
            this.txtAddUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtAddUser.Location = new System.Drawing.Point(52, 80);
            this.txtAddUser.MaxLength = 12;
            this.txtAddUser.Name = "txtAddUser";
            this.txtAddUser.Size = new System.Drawing.Size(165, 27);
            this.txtAddUser.TabIndex = 393;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 392;
            this.label1.Text = "Enter Username";
            // 
            // txtAddPass
            // 
            this.txtAddPass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtAddPass.Location = new System.Drawing.Point(52, 132);
            this.txtAddPass.MaxLength = 12;
            this.txtAddPass.Name = "txtAddPass";
            this.txtAddPass.Size = new System.Drawing.Size(165, 27);
            this.txtAddPass.TabIndex = 391;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 390;
            this.label4.Text = "Enter Password";
            // 
            // pnlEditAcc
            // 
            this.pnlEditAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.pnlEditAcc.Controls.Add(this.label3);
            this.pnlEditAcc.Controls.Add(this.btnExEdit);
            this.pnlEditAcc.Controls.Add(this.btnSubmit);
            this.pnlEditAcc.Controls.Add(this.label7);
            this.pnlEditAcc.Controls.Add(this.txtEditUser);
            this.pnlEditAcc.Controls.Add(this.label8);
            this.pnlEditAcc.Controls.Add(this.txtEditPass);
            this.pnlEditAcc.Controls.Add(this.label9);
            this.pnlEditAcc.Location = new System.Drawing.Point(435, 200);
            this.pnlEditAcc.Name = "pnlEditAcc";
            this.pnlEditAcc.Size = new System.Drawing.Size(270, 238);
            this.pnlEditAcc.TabIndex = 441;
            this.pnlEditAcc.Visible = false;
            this.pnlEditAcc.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEditAcc_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 15);
            this.label3.TabIndex = 441;
            this.label3.Text = "* Only password can be changed.";
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
            this.btnExEdit.Location = new System.Drawing.Point(237, 3);
            this.btnExEdit.Name = "btnExEdit";
            this.btnExEdit.Size = new System.Drawing.Size(30, 41);
            this.btnExEdit.TabIndex = 440;
            this.btnExEdit.Text = "X";
            this.btnExEdit.UseVisualStyleBackColor = false;
            this.btnExEdit.Click += new System.EventHandler(this.btnExEdit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkGreen;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(190, 200);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(77, 35);
            this.btnSubmit.TabIndex = 439;
            this.btnSubmit.Text = "SAVE";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 26);
            this.label7.TabIndex = 394;
            this.label7.Text = "EDIT ACCOUNT";
            // 
            // txtEditUser
            // 
            this.txtEditUser.Enabled = false;
            this.txtEditUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtEditUser.Location = new System.Drawing.Point(51, 81);
            this.txtEditUser.MaxLength = 12;
            this.txtEditUser.Name = "txtEditUser";
            this.txtEditUser.Size = new System.Drawing.Size(165, 27);
            this.txtEditUser.TabIndex = 393;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(47, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 19);
            this.label8.TabIndex = 392;
            this.label8.Text = "Username";
            // 
            // txtEditPass
            // 
            this.txtEditPass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.txtEditPass.Location = new System.Drawing.Point(51, 133);
            this.txtEditPass.MaxLength = 12;
            this.txtEditPass.Name = "txtEditPass";
            this.txtEditPass.Size = new System.Drawing.Size(165, 27);
            this.txtEditPass.TabIndex = 391;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(47, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 19);
            this.label9.TabIndex = 390;
            this.label9.Text = "Password";
            // 
            // frmAccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(1132, 693);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlAddAcc);
            this.Controls.Add(this.pnlEditAcc);
            this.Controls.Add(this.dgvAccountSettings);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAccountSettings";
            this.Text = "frmAccountSettings";
            this.Load += new System.EventHandler(this.frmAccountSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountSettings)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlAddAcc.ResumeLayout(false);
            this.pnlAddAcc.PerformLayout();
            this.pnlEditAcc.ResumeLayout(false);
            this.pnlEditAcc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelAcc;
        private System.Windows.Forms.Button btnEditAcc;
        private System.Windows.Forms.Button btnAddAcc;
        public System.Windows.Forms.DataGridView dgvAccountSettings;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel pnlAddAcc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button txtAddAcc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlEditAcc;
        private System.Windows.Forms.Button btnExEdit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEditUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEditPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
    }
}