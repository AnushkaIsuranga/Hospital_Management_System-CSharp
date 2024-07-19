namespace Hospital_Management
{
    partial class Medicine
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
            this.dgvMedicine = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnM_update = new System.Windows.Forms.Button();
            this.btnM_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtM_name = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtM_isbn = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtM_stock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dpM_expdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbM_Type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnM_return = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtM_searchID = new System.Windows.Forms.TextBox();
            this.btnM_delete = new System.Windows.Forms.Button();
            this.btnM_search = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtM_searchISBN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMedicine
            // 
            this.dgvMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedicine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicine.Location = new System.Drawing.Point(279, 12);
            this.dgvMedicine.Name = "dgvMedicine";
            this.dgvMedicine.Size = new System.Drawing.Size(589, 515);
            this.dgvMedicine.TabIndex = 36;
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
            this.panel9.TabIndex = 35;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel10, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 4);
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
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel10.Controls.Add(this.btnM_update);
            this.panel10.Controls.Add(this.btnM_save);
            this.panel10.Location = new System.Drawing.Point(3, 258);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(249, 30);
            this.panel10.TabIndex = 26;
            // 
            // btnM_update
            // 
            this.btnM_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnM_update.Location = new System.Drawing.Point(169, 3);
            this.btnM_update.Name = "btnM_update";
            this.btnM_update.Size = new System.Drawing.Size(75, 23);
            this.btnM_update.TabIndex = 28;
            this.btnM_update.Text = "Update";
            this.btnM_update.UseVisualStyleBackColor = true;
            this.btnM_update.Click += new System.EventHandler(this.btnM_update_Click);
            // 
            // btnM_save
            // 
            this.btnM_save.Location = new System.Drawing.Point(3, 4);
            this.btnM_save.Name = "btnM_save";
            this.btnM_save.Size = new System.Drawing.Size(75, 23);
            this.btnM_save.TabIndex = 27;
            this.btnM_save.Text = "Save";
            this.btnM_save.UseVisualStyleBackColor = true;
            this.btnM_save.Click += new System.EventHandler(this.btnM_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Dashboard";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtM_name);
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 39);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name :";
            // 
            // txtM_name
            // 
            this.txtM_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtM_name.Location = new System.Drawing.Point(6, 16);
            this.txtM_name.Name = "txtM_name";
            this.txtM_name.Size = new System.Drawing.Size(241, 20);
            this.txtM_name.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtM_isbn);
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
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ISBN :";
            // 
            // txtM_isbn
            // 
            this.txtM_isbn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtM_isbn.Location = new System.Drawing.Point(6, 17);
            this.txtM_isbn.Name = "txtM_isbn";
            this.txtM_isbn.Size = new System.Drawing.Size(241, 20);
            this.txtM_isbn.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.txtM_stock);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Location = new System.Drawing.Point(3, 213);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(249, 39);
            this.panel6.TabIndex = 20;
            // 
            // txtM_stock
            // 
            this.txtM_stock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtM_stock.Location = new System.Drawing.Point(6, 17);
            this.txtM_stock.Name = "txtM_stock";
            this.txtM_stock.Size = new System.Drawing.Size(241, 20);
            this.txtM_stock.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Stock :";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.dpM_expdate);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(3, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 39);
            this.panel3.TabIndex = 17;
            // 
            // dpM_expdate
            // 
            this.dpM_expdate.CustomFormat = "MM-dd-yyyy";
            this.dpM_expdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpM_expdate.Location = new System.Drawing.Point(6, 17);
            this.dpM_expdate.Name = "dpM_expdate";
            this.dpM_expdate.Size = new System.Drawing.Size(240, 20);
            this.dpM_expdate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Expiery Date :";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.cmbM_Type);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(3, 168);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 39);
            this.panel4.TabIndex = 18;
            // 
            // cmbM_Type
            // 
            this.cmbM_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbM_Type.FormattingEnabled = true;
            this.cmbM_Type.Items.AddRange(new object[] {
            "Paracitamole",
            "Acitromisin",
            "Peretin"});
            this.cmbM_Type.Location = new System.Drawing.Point(5, 15);
            this.cmbM_Type.Name = "cmbM_Type";
            this.cmbM_Type.Size = new System.Drawing.Size(242, 21);
            this.cmbM_Type.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type : ";
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
            this.groupBox1.Controls.Add(this.btnM_return);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtM_searchID);
            this.groupBox1.Controls.Add(this.btnM_delete);
            this.groupBox1.Controls.Add(this.btnM_search);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtM_searchISBN);
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 127);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Medicine";
            // 
            // btnM_return
            // 
            this.btnM_return.Location = new System.Drawing.Point(4, 90);
            this.btnM_return.Name = "btnM_return";
            this.btnM_return.Size = new System.Drawing.Size(75, 23);
            this.btnM_return.TabIndex = 55;
            this.btnM_return.Text = "Return";
            this.btnM_return.UseVisualStyleBackColor = true;
            this.btnM_return.Click += new System.EventHandler(this.btnM_return_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 53;
            this.label10.Text = "ID :";
            // 
            // txtM_searchID
            // 
            this.txtM_searchID.Location = new System.Drawing.Point(26, 66);
            this.txtM_searchID.Name = "txtM_searchID";
            this.txtM_searchID.Size = new System.Drawing.Size(185, 20);
            this.txtM_searchID.TabIndex = 54;
            this.txtM_searchID.Text = "0";
            // 
            // btnM_delete
            // 
            this.btnM_delete.Location = new System.Drawing.Point(156, 90);
            this.btnM_delete.Name = "btnM_delete";
            this.btnM_delete.Size = new System.Drawing.Size(75, 23);
            this.btnM_delete.TabIndex = 52;
            this.btnM_delete.Text = "Delete";
            this.btnM_delete.UseVisualStyleBackColor = true;
            this.btnM_delete.Click += new System.EventHandler(this.btnM_delete_Click);
            // 
            // btnM_search
            // 
            this.btnM_search.Location = new System.Drawing.Point(80, 90);
            this.btnM_search.Name = "btnM_search";
            this.btnM_search.Size = new System.Drawing.Size(75, 23);
            this.btnM_search.TabIndex = 51;
            this.btnM_search.Text = "Search";
            this.btnM_search.UseVisualStyleBackColor = true;
            this.btnM_search.Click += new System.EventHandler(this.btnM_search_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "ISBN :";
            // 
            // txtM_searchISBN
            // 
            this.txtM_searchISBN.Location = new System.Drawing.Point(26, 29);
            this.txtM_searchISBN.Name = "txtM_searchISBN";
            this.txtM_searchISBN.Size = new System.Drawing.Size(185, 20);
            this.txtM_searchISBN.TabIndex = 50;
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 556);
            this.ControlBox = false;
            this.Controls.Add(this.dgvMedicine);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Medicine";
            this.Text = "Medicine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedicine;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnM_update;
        private System.Windows.Forms.Button btnM_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtM_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtM_isbn;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtM_stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dpM_expdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbM_Type;
        private System.Windows.Forms.Button btnM_return;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtM_searchID;
        private System.Windows.Forms.Button btnM_delete;
        private System.Windows.Forms.Button btnM_search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtM_searchISBN;
    }
}