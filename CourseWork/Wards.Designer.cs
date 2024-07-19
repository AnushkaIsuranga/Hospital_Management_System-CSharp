namespace Hospital_Management
{
    partial class Wards
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
            this.dgvWards = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbW_type = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtW_Lname = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtW_master = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtW_doctor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnW_update = new System.Windows.Forms.Button();
            this.btnW_save = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnW_return = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtW_searchID = new System.Windows.Forms.TextBox();
            this.btnW_delete = new System.Windows.Forms.Button();
            this.btnW_search = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtW_searchLable = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWards)).BeginInit();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvWards
            // 
            this.dgvWards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWards.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWards.Location = new System.Drawing.Point(279, 12);
            this.dgvWards.Name = "dgvWards";
            this.dgvWards.Size = new System.Drawing.Size(589, 515);
            this.dgvWards.TabIndex = 28;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel9.Controls.Add(this.tableLayoutPanel1);
            this.panel9.Controls.Add(this.panel8);
            this.panel9.Location = new System.Drawing.Point(12, 12);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(261, 515);
            this.panel9.TabIndex = 27;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 0, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 362);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wards Dashboard";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cmbW_type);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 39);
            this.panel1.TabIndex = 15;
            // 
            // cmbW_type
            // 
            this.cmbW_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbW_type.FormattingEnabled = true;
            this.cmbW_type.Items.AddRange(new object[] {
            "ICU",
            "Children\'s",
            "Eye"});
            this.cmbW_type.Location = new System.Drawing.Point(6, 16);
            this.cmbW_type.Name = "cmbW_type";
            this.cmbW_type.Size = new System.Drawing.Size(240, 21);
            this.cmbW_type.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type :";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtW_Lname);
            this.panel2.Location = new System.Drawing.Point(3, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 39);
            this.panel2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lable Name :";
            // 
            // txtW_Lname
            // 
            this.txtW_Lname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtW_Lname.Location = new System.Drawing.Point(6, 17);
            this.txtW_Lname.Name = "txtW_Lname";
            this.txtW_Lname.Size = new System.Drawing.Size(241, 20);
            this.txtW_Lname.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.txtW_master);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(3, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 39);
            this.panel3.TabIndex = 17;
            // 
            // txtW_master
            // 
            this.txtW_master.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtW_master.Location = new System.Drawing.Point(6, 17);
            this.txtW_master.Name = "txtW_master";
            this.txtW_master.Size = new System.Drawing.Size(241, 20);
            this.txtW_master.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ward Master :";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.txtW_doctor);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(3, 168);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 39);
            this.panel4.TabIndex = 18;
            // 
            // txtW_doctor
            // 
            this.txtW_doctor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtW_doctor.Location = new System.Drawing.Point(6, 17);
            this.txtW_doctor.Name = "txtW_doctor";
            this.txtW_doctor.Size = new System.Drawing.Size(241, 20);
            this.txtW_doctor.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Doctor In Charge : ";
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.Controls.Add(this.btnW_update);
            this.panel10.Controls.Add(this.btnW_save);
            this.panel10.Location = new System.Drawing.Point(3, 213);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(249, 30);
            this.panel10.TabIndex = 26;
            // 
            // btnW_update
            // 
            this.btnW_update.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnW_update.Location = new System.Drawing.Point(169, 3);
            this.btnW_update.Name = "btnW_update";
            this.btnW_update.Size = new System.Drawing.Size(75, 23);
            this.btnW_update.TabIndex = 28;
            this.btnW_update.Text = "Update";
            this.btnW_update.UseVisualStyleBackColor = true;
            this.btnW_update.Click += new System.EventHandler(this.btnW_update_Click);
            // 
            // btnW_save
            // 
            this.btnW_save.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnW_save.Location = new System.Drawing.Point(3, 4);
            this.btnW_save.Name = "btnW_save";
            this.btnW_save.Size = new System.Drawing.Size(75, 23);
            this.btnW_save.TabIndex = 27;
            this.btnW_save.Text = "Save";
            this.btnW_save.UseVisualStyleBackColor = true;
            this.btnW_save.Click += new System.EventHandler(this.btnW_save_Click);
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel8.Controls.Add(this.groupBox1);
            this.panel8.Location = new System.Drawing.Point(2, 371);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(256, 140);
            this.panel8.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnW_return);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtW_searchID);
            this.groupBox1.Controls.Add(this.btnW_delete);
            this.groupBox1.Controls.Add(this.btnW_search);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtW_searchLable);
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 127);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Ward";
            // 
            // btnW_return
            // 
            this.btnW_return.Location = new System.Drawing.Point(4, 90);
            this.btnW_return.Name = "btnW_return";
            this.btnW_return.Size = new System.Drawing.Size(75, 23);
            this.btnW_return.TabIndex = 41;
            this.btnW_return.Text = "Return";
            this.btnW_return.UseVisualStyleBackColor = true;
            this.btnW_return.Click += new System.EventHandler(this.btnW_return_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "ID :";
            // 
            // txtW_searchID
            // 
            this.txtW_searchID.Location = new System.Drawing.Point(26, 66);
            this.txtW_searchID.Name = "txtW_searchID";
            this.txtW_searchID.Size = new System.Drawing.Size(185, 20);
            this.txtW_searchID.TabIndex = 40;
            this.txtW_searchID.Text = "0";
            // 
            // btnW_delete
            // 
            this.btnW_delete.Location = new System.Drawing.Point(156, 90);
            this.btnW_delete.Name = "btnW_delete";
            this.btnW_delete.Size = new System.Drawing.Size(75, 23);
            this.btnW_delete.TabIndex = 38;
            this.btnW_delete.Text = "Delete";
            this.btnW_delete.UseVisualStyleBackColor = true;
            this.btnW_delete.Click += new System.EventHandler(this.btnW_delete_Click);
            // 
            // btnW_search
            // 
            this.btnW_search.Location = new System.Drawing.Point(80, 90);
            this.btnW_search.Name = "btnW_search";
            this.btnW_search.Size = new System.Drawing.Size(75, 23);
            this.btnW_search.TabIndex = 37;
            this.btnW_search.Text = "Search";
            this.btnW_search.UseVisualStyleBackColor = true;
            this.btnW_search.Click += new System.EventHandler(this.btnW_search_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Lable :";
            // 
            // txtW_searchLable
            // 
            this.txtW_searchLable.Location = new System.Drawing.Point(26, 29);
            this.txtW_searchLable.Name = "txtW_searchLable";
            this.txtW_searchLable.Size = new System.Drawing.Size(185, 20);
            this.txtW_searchLable.TabIndex = 36;
            // 
            // Wards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 556);
            this.ControlBox = false;
            this.Controls.Add(this.dgvWards);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Wards";
            this.Text = "Wards";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvWards)).EndInit();
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWards;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnW_update;
        private System.Windows.Forms.Button btnW_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtW_Lname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtW_master;
        private System.Windows.Forms.ComboBox cmbW_type;
        private System.Windows.Forms.TextBox txtW_doctor;
        private System.Windows.Forms.Button btnW_return;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtW_searchID;
        private System.Windows.Forms.Button btnW_delete;
        private System.Windows.Forms.Button btnW_search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtW_searchLable;
    }
}