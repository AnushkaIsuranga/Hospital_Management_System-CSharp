namespace Hospital_Management
{
    partial class ManagmentPg
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMedicine = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnWards = new System.Windows.Forms.Button();
            this.btnDoctors = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNurses = new System.Windows.Forms.Button();
            this.btnLabors = new System.Windows.Forms.Button();
            this.btnAttendants = new System.Windows.Forms.Button();
            this.pContainer = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Management \r\nDash Board\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMedicine
            // 
            this.btnMedicine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMedicine.Location = new System.Drawing.Point(3, 441);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(189, 55);
            this.btnMedicine.TabIndex = 4;
            this.btnMedicine.Text = "Medicine";
            this.btnMedicine.UseVisualStyleBackColor = true;
            this.btnMedicine.Click += new System.EventHandler(this.btnMedicine_Click);
            // 
            // btnPatients
            // 
            this.btnPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPatients.Location = new System.Drawing.Point(3, 75);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(189, 55);
            this.btnPatients.TabIndex = 1;
            this.btnPatients.Text = "Patients";
            this.btnPatients.UseVisualStyleBackColor = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnWards
            // 
            this.btnWards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWards.Location = new System.Drawing.Point(3, 197);
            this.btnWards.Name = "btnWards";
            this.btnWards.Size = new System.Drawing.Size(189, 55);
            this.btnWards.TabIndex = 3;
            this.btnWards.Text = "Wards";
            this.btnWards.UseVisualStyleBackColor = true;
            this.btnWards.Click += new System.EventHandler(this.btnWards_Click);
            // 
            // btnDoctors
            // 
            this.btnDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoctors.Location = new System.Drawing.Point(3, 136);
            this.btnDoctors.Name = "btnDoctors";
            this.btnDoctors.Size = new System.Drawing.Size(189, 55);
            this.btnDoctors.TabIndex = 2;
            this.btnDoctors.Text = "Doctors";
            this.btnDoctors.UseVisualStyleBackColor = true;
            this.btnDoctors.Click += new System.EventHandler(this.btnDoctors_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Location = new System.Drawing.Point(3, 507);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 37);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.AllowDrop = true;
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.AutoEllipsis = true;
            this.btnExit.Location = new System.Drawing.Point(107, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(79, 31);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.AllowDrop = true;
            this.btnSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignOut.AutoEllipsis = true;
            this.btnSignOut.Location = new System.Drawing.Point(3, 3);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSignOut.Size = new System.Drawing.Size(79, 31);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnPatients, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnDoctors, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnWards, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnNurses, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnLabors, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.btnMedicine, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.btnAttendants, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 9);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(195, 547);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnNurses
            // 
            this.btnNurses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNurses.Location = new System.Drawing.Point(3, 258);
            this.btnNurses.Name = "btnNurses";
            this.btnNurses.Size = new System.Drawing.Size(189, 55);
            this.btnNurses.TabIndex = 5;
            this.btnNurses.Text = "Nurses";
            this.btnNurses.UseVisualStyleBackColor = true;
            this.btnNurses.Click += new System.EventHandler(this.btnNurses_Click);
            // 
            // btnLabors
            // 
            this.btnLabors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLabors.Location = new System.Drawing.Point(3, 380);
            this.btnLabors.Name = "btnLabors";
            this.btnLabors.Size = new System.Drawing.Size(189, 55);
            this.btnLabors.TabIndex = 7;
            this.btnLabors.Text = "Labors";
            this.btnLabors.UseVisualStyleBackColor = true;
            this.btnLabors.Click += new System.EventHandler(this.btnLabors_Click);
            // 
            // btnAttendants
            // 
            this.btnAttendants.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAttendants.Location = new System.Drawing.Point(3, 319);
            this.btnAttendants.Name = "btnAttendants";
            this.btnAttendants.Size = new System.Drawing.Size(189, 55);
            this.btnAttendants.TabIndex = 6;
            this.btnAttendants.Text = "Attendants";
            this.btnAttendants.UseVisualStyleBackColor = true;
            this.btnAttendants.Click += new System.EventHandler(this.btnAttendants_Click);
            // 
            // pContainer
            // 
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pContainer.Location = new System.Drawing.Point(229, 12);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(868, 547);
            this.pContainer.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel6.Location = new System.Drawing.Point(213, 12);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 547);
            this.panel6.TabIndex = 4;
            // 
            // ManagmentPg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 571);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(1125, 610);
            this.Name = "ManagmentPg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hospital_Management_System_FormClosing);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMedicine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnWards;
        private System.Windows.Forms.Button btnDoctors;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnNurses;
        private System.Windows.Forms.Button btnLabors;
        private System.Windows.Forms.Button btnAttendants;
    }
}