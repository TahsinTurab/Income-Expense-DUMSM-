﻿namespace DUMSM.Forms.ExpenseForm
{
    partial class ExpenseDetailsGoraba
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DeleteAllbtn = new System.Windows.Forms.Button();
            this.searchNametxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Donordgv = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoucherNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpenseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Field = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ammount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Donordgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteAllbtn
            // 
            this.DeleteAllbtn.BackColor = System.Drawing.Color.RosyBrown;
            this.DeleteAllbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteAllbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.DeleteAllbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DeleteAllbtn.Location = new System.Drawing.Point(403, 612);
            this.DeleteAllbtn.Name = "DeleteAllbtn";
            this.DeleteAllbtn.Size = new System.Drawing.Size(245, 41);
            this.DeleteAllbtn.TabIndex = 112;
            this.DeleteAllbtn.Text = "সকল তথ্য ডিলিট করুন";
            this.DeleteAllbtn.UseVisualStyleBackColor = false;
            this.DeleteAllbtn.Click += new System.EventHandler(this.DeleteAllbtn_Click);
            // 
            // searchNametxt
            // 
            this.searchNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNametxt.Location = new System.Drawing.Point(102, 619);
            this.searchNametxt.Name = "searchNametxt";
            this.searchNametxt.Size = new System.Drawing.Size(120, 29);
            this.searchNametxt.TabIndex = 110;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 622);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 24);
            this.label9.TabIndex = 111;
            this.label9.Text = "ভাউচার";
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Searchbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Searchbtn.Location = new System.Drawing.Point(228, 611);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(167, 41);
            this.Searchbtn.TabIndex = 109;
            this.Searchbtn.Text = "অনুসন্ধান করুন";
            this.Searchbtn.UseVisualStyleBackColor = false;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(300, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 39);
            this.label1.TabIndex = 104;
            this.label1.Text = "দারুল উলূম মুহিউস সুন্নাহ মাদরাসা\r\n";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(10, 185);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(962, 424);
            this.tabControl1.TabIndex = 108;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Donordgv);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(954, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "সাধারণ অনুদানের বিস্তারিত বিবরণ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Donordgv
            // 
            this.Donordgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Donordgv.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Donordgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Donordgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Donordgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.id,
            this.VoucherNumber,
            this.ExpenseDate,
            this.Field,
            this.Ammount,
            this.MonthName,
            this.Year});
            this.Donordgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Donordgv.GridColor = System.Drawing.SystemColors.Window;
            this.Donordgv.Location = new System.Drawing.Point(3, 3);
            this.Donordgv.Name = "Donordgv";
            this.Donordgv.Size = new System.Drawing.Size(948, 376);
            this.Donordgv.TabIndex = 0;
            this.Donordgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Donordgv_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(669, 612);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 41);
            this.button2.TabIndex = 107;
            this.button2.Text = "ব্যাকআপ ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button35.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button35.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button35.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button35.Location = new System.Drawing.Point(739, 117);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(231, 41);
            this.button35.TabIndex = 106;
            this.button35.Text = "পূর্বের পাতায় ফিরে যান";
            this.button35.UseVisualStyleBackColor = false;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(365, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 25);
            this.label2.TabIndex = 105;
            this.label2.Text = "খোয়াজপুর, বেগমগঞ্জ, নোয়াখালী";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(-201, -5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1390, 107);
            this.textBox1.TabIndex = 102;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::DUMSM.Properties.Resources.logo1;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(164, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.HeaderText = "ডিলিট";
            this.Delete.Name = "Delete";
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "ডিলিট";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 70;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "আইডি ";
            this.id.Name = "id";
            this.id.Width = 60;
            // 
            // VoucherNumber
            // 
            this.VoucherNumber.DataPropertyName = "VoucherNumber";
            this.VoucherNumber.HeaderText = "ভাউচার নাম্বার";
            this.VoucherNumber.Name = "VoucherNumber";
            this.VoucherNumber.Width = 150;
            // 
            // ExpenseDate
            // 
            this.ExpenseDate.DataPropertyName = "ExpenseDate";
            this.ExpenseDate.HeaderText = "তারিখ";
            this.ExpenseDate.Name = "ExpenseDate";
            this.ExpenseDate.Width = 140;
            // 
            // Field
            // 
            this.Field.DataPropertyName = "Field";
            this.Field.HeaderText = "খরচের খাত";
            this.Field.Name = "Field";
            this.Field.Width = 150;
            // 
            // Ammount
            // 
            this.Ammount.DataPropertyName = "Ammount";
            this.Ammount.HeaderText = "খরচের পরিমাণ";
            this.Ammount.Name = "Ammount";
            this.Ammount.Width = 150;
            // 
            // MonthName
            // 
            this.MonthName.HeaderText = "মাস ";
            this.MonthName.Name = "MonthName";
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "বছর ";
            this.Year.Name = "Year";
            // 
            // ExpenseDetailsGoraba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.DeleteAllbtn);
            this.Controls.Add(this.searchNametxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.Name = "ExpenseDetailsGoraba";
            this.Text = "ExpenseDetailsGoraba";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExpenseDetailsGoraba_FormClosing);
            this.Load += new System.EventHandler(this.ExpenseDetailsGoraba_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Donordgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteAllbtn;
        private System.Windows.Forms.TextBox searchNametxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView Donordgv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Field;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ammount;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
    }
}