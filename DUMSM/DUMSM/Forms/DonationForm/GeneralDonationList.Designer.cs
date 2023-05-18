namespace DUMSM.Forms.DonationForm
{
    partial class GeneralDonationList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralDonationList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.donorsTableAdapter = new DUMSM.DUMSMDataBaseDataSetTableAdapters.DonorsTableAdapter();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.donorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dUMSMDataBaseDataSet = new DUMSM.DUMSMDataBaseDataSet();
            this.Donordgv = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SlipNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonationAmmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonationField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Backbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Backupbtn = new System.Windows.Forms.Button();
            this.DeleteAllbtn = new System.Windows.Forms.Button();
            this.Printbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchNametxt = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUMSMDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Donordgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // donorsTableAdapter
            // 
            this.donorsTableAdapter.ClearBeforeFill = true;
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
            // Searchbtn
            // 
            this.Searchbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Searchbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Searchbtn.Location = new System.Drawing.Point(725, 130);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(209, 41);
            this.Searchbtn.TabIndex = 99;
            this.Searchbtn.Text = "অনুসন্ধান করুন";
            this.Searchbtn.UseVisualStyleBackColor = false;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(371, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 24);
            this.label9.TabIndex = 101;
            this.label9.Text = "দাতার নাম";
            // 
            // donorsBindingSource
            // 
            this.donorsBindingSource.DataMember = "Donors";
            this.donorsBindingSource.DataSource = this.dUMSMDataBaseDataSet;
            // 
            // dUMSMDataBaseDataSet
            // 
            this.dUMSMDataBaseDataSet.DataSetName = "DUMSMDataBaseDataSet";
            this.dUMSMDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.Update,
            this.Id,
            this.SlipNumber,
            this.DonorName,
            this.DonationAmmount,
            this.DonationType,
            this.DonationField,
            this.DonationDate});
            this.Donordgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Donordgv.GridColor = System.Drawing.SystemColors.Window;
            this.Donordgv.Location = new System.Drawing.Point(3, 3);
            this.Donordgv.Name = "Donordgv";
            this.Donordgv.Size = new System.Drawing.Size(946, 256);
            this.Donordgv.TabIndex = 0;
            this.Donordgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Donordgv_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "ডিলিট";
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.HeaderText = "ডিলিট";
            this.Delete.Name = "Delete";
            this.Delete.Text = "ডিলিট";
            // 
            // Update
            // 
            this.Update.DataPropertyName = "Update";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "আপডেট";
            this.Update.DefaultCellStyle = dataGridViewCellStyle3;
            this.Update.HeaderText = "আপডেট";
            this.Update.Name = "Update";
            this.Update.Text = "আপডেট";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "আই ডি";
            this.Id.Name = "Id";
            // 
            // SlipNumber
            // 
            this.SlipNumber.DataPropertyName = "SlipNumber";
            this.SlipNumber.HeaderText = "রশিদ নাম্বার ";
            this.SlipNumber.Name = "SlipNumber";
            // 
            // DonorName
            // 
            this.DonorName.DataPropertyName = "DonorName";
            this.DonorName.HeaderText = "দাতার নাম";
            this.DonorName.Name = "DonorName";
            // 
            // DonationAmmount
            // 
            this.DonationAmmount.DataPropertyName = "DonationAmmount";
            this.DonationAmmount.HeaderText = "অনুদানের পরিমাণ ";
            this.DonationAmmount.Name = "DonationAmmount";
            // 
            // DonationType
            // 
            this.DonationType.DataPropertyName = "DonationType";
            this.DonationType.HeaderText = "অনুদানের ধরন";
            this.DonationType.Name = "DonationType";
            // 
            // DonationField
            // 
            this.DonationField.DataPropertyName = "DonationField";
            this.DonationField.HeaderText = "দানের খাত";
            this.DonationField.Name = "DonationField";
            // 
            // DonationDate
            // 
            this.DonationDate.DataPropertyName = "DonationDate";
            this.DonationDate.HeaderText = "দানের তারিখ";
            this.DonationDate.Name = "DonationDate";
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Backbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Backbtn.Location = new System.Drawing.Point(9, 539);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(231, 41);
            this.Backbtn.TabIndex = 91;
            this.Backbtn.Text = "পূর্বের পাতায় ফিরে যান";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(370, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 25);
            this.label2.TabIndex = 90;
            this.label2.Text = "খোয়াজপুর, বেগমগঞ্জ, নোয়াখালী";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::DUMSM.Properties.Resources.logo1;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(176, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // Backupbtn
            // 
            this.Backupbtn.BackColor = System.Drawing.Color.RosyBrown;
            this.Backupbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Backupbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Backupbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Backupbtn.Location = new System.Drawing.Point(725, 539);
            this.Backupbtn.Name = "Backupbtn";
            this.Backupbtn.Size = new System.Drawing.Size(216, 41);
            this.Backupbtn.TabIndex = 95;
            this.Backupbtn.Text = "ব্যাকআপ ";
            this.Backupbtn.UseVisualStyleBackColor = false;
            this.Backupbtn.Click += new System.EventHandler(this.Backupbtn_Click);
            // 
            // DeleteAllbtn
            // 
            this.DeleteAllbtn.BackColor = System.Drawing.Color.RosyBrown;
            this.DeleteAllbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteAllbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.DeleteAllbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DeleteAllbtn.Location = new System.Drawing.Point(246, 539);
            this.DeleteAllbtn.Name = "DeleteAllbtn";
            this.DeleteAllbtn.Size = new System.Drawing.Size(245, 41);
            this.DeleteAllbtn.TabIndex = 94;
            this.DeleteAllbtn.Text = "সকল তথ্য ডিলিট করুন";
            this.DeleteAllbtn.UseVisualStyleBackColor = false;
            this.DeleteAllbtn.Click += new System.EventHandler(this.DeleteAllbtn_Click);
            // 
            // Printbtn
            // 
            this.Printbtn.BackColor = System.Drawing.Color.RosyBrown;
            this.Printbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Printbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Printbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Printbtn.Location = new System.Drawing.Point(499, 539);
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.Size = new System.Drawing.Size(217, 41);
            this.Printbtn.TabIndex = 93;
            this.Printbtn.Text = "প্রিন্ট করুন";
            this.Printbtn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(300, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 39);
            this.label1.TabIndex = 89;
            this.label1.Text = "দারুল উলূম মুহিউস সুন্নাহ মাদরাসা\r\n";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(-203, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1390, 107);
            this.textBox1.TabIndex = 87;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // searchNametxt
            // 
            this.searchNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchNametxt.Location = new System.Drawing.Point(466, 137);
            this.searchNametxt.Name = "searchNametxt";
            this.searchNametxt.Size = new System.Drawing.Size(250, 29);
            this.searchNametxt.TabIndex = 100;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(9, 172);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 304);
            this.tabControl1.TabIndex = 92;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Donordgv);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(952, 262);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "সাধারণ দানের বিস্তারিত বিবরণ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GeneralDonationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Backupbtn);
            this.Controls.Add(this.DeleteAllbtn);
            this.Controls.Add(this.Printbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchNametxt);
            this.Controls.Add(this.tabControl1);
            this.Name = "GeneralDonationList";
            this.Text = "সাধারণ দানের তথ্য";
            this.Activated += new System.EventHandler(this.GeneralDonationList_Activated);
            this.Load += new System.EventHandler(this.GeneralDonationList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUMSMDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Donordgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DUMSMDataBaseDataSetTableAdapters.DonorsTableAdapter donorsTableAdapter;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource donorsBindingSource;
        private DUMSMDataBaseDataSet dUMSMDataBaseDataSet;
        private System.Windows.Forms.DataGridView Donordgv;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Backupbtn;
        private System.Windows.Forms.Button DeleteAllbtn;
        private System.Windows.Forms.Button Printbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox searchNametxt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SlipNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonationAmmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonationField;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonationDate;
    }
}