namespace DUMSM.Forms.Salary
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.donorsTableAdapter = new DUMSM.DUMSMDataBaseDataSetTableAdapters.DonorsTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ProvidentFundtxt = new System.Windows.Forms.TextBox();
            this.Loantxt = new System.Windows.Forms.TextBox();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.Duetxt = new System.Windows.Forms.TextBox();
            this.Advancetxt = new System.Windows.Forms.TextBox();
            this.Bonoustxt = new System.Windows.Forms.TextBox();
            this.ExtraHonoriumtxt = new System.Windows.Forms.TextBox();
            this.TotalLeavetxt = new System.Windows.Forms.TextBox();
            this.TotalAbsenttxt = new System.Windows.Forms.TextBox();
            this.TotalPresenttxt = new System.Windows.Forms.TextBox();
            this.MonthList = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BaseSalarytxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameList = new System.Windows.Forms.ComboBox();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.donorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dUMSMDataBaseDataSet = new DUMSM.DUMSMDataBaseDataSet();
            this.Donordgv = new System.Windows.Forms.DataGridView();
            this.Backbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Backupbtn = new System.Windows.Forms.Button();
            this.DeleteAllbtn = new System.Windows.Forms.Button();
            this.Printbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TotalAmmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Paybtn = new System.Windows.Forms.Button();
            this.DateTimetxt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.NetPayableAmmounttxt = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaseSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPresent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAbsent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLeave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAmmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtraHonorium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Due = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bonous = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Advance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvidentFund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetPayableAmmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUMSMDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Donordgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // donorsTableAdapter
            // 
            this.donorsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.ProvidentFundtxt);
            this.groupBox1.Controls.Add(this.Loantxt);
            this.groupBox1.Controls.Add(this.Registerbtn);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.Duetxt);
            this.groupBox1.Controls.Add(this.Advancetxt);
            this.groupBox1.Controls.Add(this.Bonoustxt);
            this.groupBox1.Controls.Add(this.ExtraHonoriumtxt);
            this.groupBox1.Controls.Add(this.TotalLeavetxt);
            this.groupBox1.Controls.Add(this.TotalAbsenttxt);
            this.groupBox1.Controls.Add(this.TotalPresenttxt);
            this.groupBox1.Controls.Add(this.MonthList);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.BaseSalarytxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NameList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 148);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "মাসিক তথ্য নিবন্ধন";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(121, 28);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 28);
            this.radioButton2.TabIndex = 103;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "স্টাফ";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(22, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 28);
            this.radioButton1.TabIndex = 102;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "শিক্ষক";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ProvidentFundtxt
            // 
            this.ProvidentFundtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ProvidentFundtxt.Location = new System.Drawing.Point(706, 108);
            this.ProvidentFundtxt.Name = "ProvidentFundtxt";
            this.ProvidentFundtxt.Size = new System.Drawing.Size(89, 29);
            this.ProvidentFundtxt.TabIndex = 101;
            // 
            // Loantxt
            // 
            this.Loantxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Loantxt.Location = new System.Drawing.Point(706, 67);
            this.Loantxt.Name = "Loantxt";
            this.Loantxt.Size = new System.Drawing.Size(89, 29);
            this.Loantxt.TabIndex = 100;
            // 
            // Registerbtn
            // 
            this.Registerbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Registerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Registerbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Registerbtn.Location = new System.Drawing.Point(817, 76);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(126, 66);
            this.Registerbtn.TabIndex = 97;
            this.Registerbtn.Text = "প্রাপ্য বেতন হিসাব";
            this.Registerbtn.UseVisualStyleBackColor = false;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(801, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 20);
            this.label14.TabIndex = 88;
            this.label14.Text = "বকেয়া";
            // 
            // Duetxt
            // 
            this.Duetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Duetxt.Location = new System.Drawing.Point(854, 28);
            this.Duetxt.Name = "Duetxt";
            this.Duetxt.Size = new System.Drawing.Size(89, 29);
            this.Duetxt.TabIndex = 97;
            // 
            // Advancetxt
            // 
            this.Advancetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Advancetxt.Location = new System.Drawing.Point(706, 30);
            this.Advancetxt.Name = "Advancetxt";
            this.Advancetxt.Size = new System.Drawing.Size(89, 29);
            this.Advancetxt.TabIndex = 99;
            // 
            // Bonoustxt
            // 
            this.Bonoustxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Bonoustxt.Location = new System.Drawing.Point(493, 111);
            this.Bonoustxt.Name = "Bonoustxt";
            this.Bonoustxt.Size = new System.Drawing.Size(89, 29);
            this.Bonoustxt.TabIndex = 98;
            // 
            // ExtraHonoriumtxt
            // 
            this.ExtraHonoriumtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ExtraHonoriumtxt.Location = new System.Drawing.Point(493, 76);
            this.ExtraHonoriumtxt.Name = "ExtraHonoriumtxt";
            this.ExtraHonoriumtxt.Size = new System.Drawing.Size(89, 29);
            this.ExtraHonoriumtxt.TabIndex = 96;
            // 
            // TotalLeavetxt
            // 
            this.TotalLeavetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TotalLeavetxt.Location = new System.Drawing.Point(493, 28);
            this.TotalLeavetxt.Name = "TotalLeavetxt";
            this.TotalLeavetxt.Size = new System.Drawing.Size(89, 29);
            this.TotalLeavetxt.TabIndex = 95;
            // 
            // TotalAbsenttxt
            // 
            this.TotalAbsenttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TotalAbsenttxt.Location = new System.Drawing.Point(281, 108);
            this.TotalAbsenttxt.Name = "TotalAbsenttxt";
            this.TotalAbsenttxt.Size = new System.Drawing.Size(89, 29);
            this.TotalAbsenttxt.TabIndex = 94;
            // 
            // TotalPresenttxt
            // 
            this.TotalPresenttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TotalPresenttxt.Location = new System.Drawing.Point(281, 64);
            this.TotalPresenttxt.Name = "TotalPresenttxt";
            this.TotalPresenttxt.Size = new System.Drawing.Size(89, 29);
            this.TotalPresenttxt.TabIndex = 93;
            // 
            // MonthList
            // 
            this.MonthList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthList.FormattingEnabled = true;
            this.MonthList.Items.AddRange(new object[] {
            "জানুয়ারী",
            "ফেব্রুয়ারী",
            "মার্চ",
            "এপ্রিল",
            "মে",
            "জুন",
            "জুলাই",
            "আগস্ট",
            "সেপ্টেম্বর",
            "অক্টোবর",
            "নভেম্বর",
            "ডিসেম্বর "});
            this.MonthList.Location = new System.Drawing.Point(94, 105);
            this.MonthList.Name = "MonthList";
            this.MonthList.Size = new System.Drawing.Size(89, 32);
            this.MonthList.TabIndex = 92;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(601, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 20);
            this.label17.TabIndex = 91;
            this.label17.Text = "অগ্রীম নিয়েছেন";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(639, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 20);
            this.label16.TabIndex = 90;
            this.label16.Text = "ঋণ কর্তণ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(606, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 20);
            this.label15.TabIndex = 89;
            this.label15.Text = "প্রভিডেন্ট ফান্ড";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(385, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 87;
            this.label13.Text = "অতিরিক্ত সম্মানী";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(438, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 86;
            this.label12.Text = "বোনাস";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(213, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 85;
            this.label11.Text = "মূল বেতন";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(456, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 20);
            this.label10.TabIndex = 84;
            this.label10.Text = "ছুটি";
            // 
            // BaseSalarytxt
            // 
            this.BaseSalarytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BaseSalarytxt.Location = new System.Drawing.Point(281, 25);
            this.BaseSalarytxt.Name = "BaseSalarytxt";
            this.BaseSalarytxt.Size = new System.Drawing.Size(89, 29);
            this.BaseSalarytxt.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(206, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 82;
            this.label8.Text = "অনুপস্থিতি";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(217, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 81;
            this.label7.Text = "উপস্থিতি";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "মাসের নাম";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "নাম";
            // 
            // NameList
            // 
            this.NameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameList.FormattingEnabled = true;
            this.NameList.Location = new System.Drawing.Point(94, 67);
            this.NameList.Name = "NameList";
            this.NameList.Size = new System.Drawing.Size(89, 32);
            this.NameList.TabIndex = 71;
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
            this.id,
            this.EmployeeName,
            this.EmployeeType,
            this.MonthName,
            this.BaseSalary,
            this.TotalPresent,
            this.TotalAbsent,
            this.TotalLeave,
            this.TAmmount,
            this.ExtraHonorium,
            this.Due,
            this.Bonous,
            this.Advance,
            this.Loan,
            this.ProvidentFund,
            this.NetPayableAmmount,
            this.PaymentDate,
            this.IsPaid});
            this.Donordgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Donordgv.GridColor = System.Drawing.SystemColors.Window;
            this.Donordgv.Location = new System.Drawing.Point(3, 3);
            this.Donordgv.Name = "Donordgv";
            this.Donordgv.Size = new System.Drawing.Size(946, 216);
            this.Donordgv.TabIndex = 0;
            this.Donordgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Donordgv_CellContentClick);
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Backbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Backbtn.Location = new System.Drawing.Point(9, 616);
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
            this.label2.Location = new System.Drawing.Point(360, 56);
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
            this.pictureBox1.Location = new System.Drawing.Point(166, 12);
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
            this.Backupbtn.Location = new System.Drawing.Point(722, 616);
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
            this.DeleteAllbtn.Location = new System.Drawing.Point(248, 616);
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
            this.Printbtn.Location = new System.Drawing.Point(499, 616);
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
            this.label1.Location = new System.Drawing.Point(290, 17);
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
            this.textBox1.Location = new System.Drawing.Point(-213, -4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1390, 107);
            this.textBox1.TabIndex = 87;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(9, 346);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 264);
            this.tabControl1.TabIndex = 92;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Donordgv);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(952, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "মাসিক তথ্য ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TotalAmmount);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Paybtn);
            this.groupBox2.Controls.Add(this.DateTimetxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NetPayableAmmounttxt);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(953, 62);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "বেতন তথ্য ";
            // 
            // TotalAmmount
            // 
            this.TotalAmmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.TotalAmmount.Location = new System.Drawing.Point(121, 22);
            this.TotalAmmount.Name = "TotalAmmount";
            this.TotalAmmount.Size = new System.Drawing.Size(105, 29);
            this.TotalAmmount.TabIndex = 94;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 93;
            this.label6.Text = "চলতি মাসের বেতন";
            // 
            // Paybtn
            // 
            this.Paybtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Paybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Paybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Paybtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Paybtn.Location = new System.Drawing.Point(774, 15);
            this.Paybtn.Name = "Paybtn";
            this.Paybtn.Size = new System.Drawing.Size(172, 41);
            this.Paybtn.TabIndex = 92;
            this.Paybtn.Text = "পরিশোধ করুন";
            this.Paybtn.UseVisualStyleBackColor = false;
            this.Paybtn.Click += new System.EventHandler(this.Paybtn_Click);
            // 
            // DateTimetxt
            // 
            this.DateTimetxt.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimetxt.Location = new System.Drawing.Point(539, 21);
            this.DateTimetxt.Name = "DateTimetxt";
            this.DateTimetxt.Size = new System.Drawing.Size(229, 26);
            this.DateTimetxt.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(422, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 82;
            this.label3.Text = "পরিশোধের তারিখ";
            // 
            // NetPayableAmmounttxt
            // 
            this.NetPayableAmmounttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.NetPayableAmmounttxt.Location = new System.Drawing.Point(311, 21);
            this.NetPayableAmmounttxt.Name = "NetPayableAmmounttxt";
            this.NetPayableAmmounttxt.Size = new System.Drawing.Size(105, 29);
            this.NetPayableAmmounttxt.TabIndex = 81;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(232, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 20);
            this.label20.TabIndex = 78;
            this.label20.Text = "প্রাপ্য বেতন";
            this.label20.Click += new System.EventHandler(this.label20_Click);
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
            // Update
            // 
            this.Update.DataPropertyName = "Update";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Update.DefaultCellStyle = dataGridViewCellStyle3;
            this.Update.HeaderText = "আপডেট";
            this.Update.Name = "Update";
            this.Update.Text = "আপডেট";
            this.Update.UseColumnTextForButtonValue = true;
            this.Update.Width = 70;
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "আইডি ";
            this.id.Name = "id";
            this.id.Width = 60;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "নাম ";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Width = 150;
            // 
            // EmployeeType
            // 
            this.EmployeeType.DataPropertyName = "EmployeeType";
            this.EmployeeType.HeaderText = "ধরণ";
            this.EmployeeType.Name = "EmployeeType";
            // 
            // MonthName
            // 
            this.MonthName.DataPropertyName = "MonthName";
            this.MonthName.HeaderText = "মাসের নাম";
            this.MonthName.Name = "MonthName";
            this.MonthName.Width = 150;
            // 
            // BaseSalary
            // 
            this.BaseSalary.DataPropertyName = "BaseSalary";
            this.BaseSalary.HeaderText = "মুল বেতন";
            this.BaseSalary.Name = "BaseSalary";
            // 
            // TotalPresent
            // 
            this.TotalPresent.DataPropertyName = "TotalPresent";
            this.TotalPresent.HeaderText = "উপস্থিতি";
            this.TotalPresent.Name = "TotalPresent";
            this.TotalPresent.Width = 80;
            // 
            // TotalAbsent
            // 
            this.TotalAbsent.DataPropertyName = "TotalAbsent";
            this.TotalAbsent.HeaderText = "অনুপস্থিতি";
            this.TotalAbsent.Name = "TotalAbsent";
            this.TotalAbsent.Width = 80;
            // 
            // TotalLeave
            // 
            this.TotalLeave.DataPropertyName = "TotalLeave";
            this.TotalLeave.HeaderText = "ছুটি";
            this.TotalLeave.Name = "TotalLeave";
            this.TotalLeave.Width = 50;
            // 
            // TAmmount
            // 
            this.TAmmount.DataPropertyName = "TotalAmmount";
            this.TAmmount.HeaderText = "চলতি মাসের প্রাপ্ত বেতন ";
            this.TAmmount.Name = "TAmmount";
            // 
            // ExtraHonorium
            // 
            this.ExtraHonorium.DataPropertyName = "ExtraHonorium";
            this.ExtraHonorium.HeaderText = "অতিরিক্ত সম্মানী ";
            this.ExtraHonorium.Name = "ExtraHonorium";
            // 
            // Due
            // 
            this.Due.DataPropertyName = "Due";
            this.Due.HeaderText = "বকেয়া";
            this.Due.Name = "Due";
            // 
            // Bonous
            // 
            this.Bonous.DataPropertyName = "Bonous";
            this.Bonous.HeaderText = "বোনাস";
            this.Bonous.Name = "Bonous";
            // 
            // Advance
            // 
            this.Advance.DataPropertyName = "Advance";
            this.Advance.HeaderText = "অগ্রীম";
            this.Advance.Name = "Advance";
            // 
            // Loan
            // 
            this.Loan.DataPropertyName = "Loan";
            this.Loan.HeaderText = "ঋণ কর্তণ ";
            this.Loan.Name = "Loan";
            // 
            // ProvidentFund
            // 
            this.ProvidentFund.DataPropertyName = "ProvidentFund";
            this.ProvidentFund.HeaderText = "প্রভিডেন্ট ফান্ড";
            this.ProvidentFund.Name = "ProvidentFund";
            // 
            // NetPayableAmmount
            // 
            this.NetPayableAmmount.DataPropertyName = "NetPayableAmmount";
            this.NetPayableAmmount.HeaderText = "প্রাপ্ত বেতন ";
            this.NetPayableAmmount.Name = "NetPayableAmmount";
            // 
            // PaymentDate
            // 
            this.PaymentDate.DataPropertyName = "PaymentDate";
            this.PaymentDate.HeaderText = "পরিশোধের তারিখ";
            this.PaymentDate.Name = "PaymentDate";
            // 
            // IsPaid
            // 
            this.IsPaid.DataPropertyName = "IsPaid";
            this.IsPaid.HeaderText = "পরিশোধ";
            this.IsPaid.Name = "IsPaid";
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Backupbtn);
            this.Controls.Add(this.DeleteAllbtn);
            this.Controls.Add(this.Printbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Salary";
            this.Text = "বেতন তথ্য";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUMSMDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Donordgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DUMSMDataBaseDataSetTableAdapters.DonorsTableAdapter donorsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox BaseSalarytxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox NameList;
        private System.Windows.Forms.Button Registerbtn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox ProvidentFundtxt;
        private System.Windows.Forms.TextBox Loantxt;
        private System.Windows.Forms.TextBox Advancetxt;
        private System.Windows.Forms.TextBox Bonoustxt;
        private System.Windows.Forms.TextBox Duetxt;
        private System.Windows.Forms.TextBox ExtraHonoriumtxt;
        private System.Windows.Forms.TextBox TotalLeavetxt;
        private System.Windows.Forms.TextBox TotalAbsenttxt;
        private System.Windows.Forms.TextBox TotalPresenttxt;
        private System.Windows.Forms.ComboBox MonthList;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NetPayableAmmounttxt;
        private System.Windows.Forms.Button Paybtn;
        private System.Windows.Forms.DateTimePicker DateTimetxt;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox TotalAmmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPresent;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAbsent;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLeave;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAmmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtraHonorium;
        private System.Windows.Forms.DataGridViewTextBoxColumn Due;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bonous;
        private System.Windows.Forms.DataGridViewTextBoxColumn Advance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProvidentFund;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetPayableAmmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPaid;
    }
}