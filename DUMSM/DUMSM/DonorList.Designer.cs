namespace DUMSM
{
    partial class DonorList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonorList));
            this.Donordgv = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dUMSMDataBaseDataSet = new DUMSM.DUMSMDataBaseDataSet();
            this.donorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donorsTableAdapter = new DUMSM.DUMSMDataBaseDataSetTableAdapters.DonorsTableAdapter();
            this.DonorTypetxt = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Addresstxt = new System.Windows.Forms.TextBox();
            this.DonationAmmounttxt = new System.Windows.Forms.TextBox();
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MobileNumbertxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DonorNametxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donorType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donationAmmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Donordgv)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUMSMDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.donorName,
            this.Mobile,
            this.donorType,
            this.donationAmmount,
            this.Address});
            this.Donordgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Donordgv.GridColor = System.Drawing.SystemColors.Window;
            this.Donordgv.Location = new System.Drawing.Point(3, 3);
            this.Donordgv.Name = "Donordgv";
            this.Donordgv.Size = new System.Drawing.Size(946, 256);
            this.Donordgv.TabIndex = 0;
            this.Donordgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            //this.Donordgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 126);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 304);
            this.tabControl1.TabIndex = 66;
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
            this.tabPage1.Text = "স্থায়ী দাতা সদস্যের বিস্তারিত বিবরণ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(373, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 25);
            this.label2.TabIndex = 64;
            this.label2.Text = "খোয়াজপুর, বেগমগঞ্জ, নোয়াখালী";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::DUMSM.Properties.Resources.logo1;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(179, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(-200, -4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1390, 107);
            this.textBox1.TabIndex = 61;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RosyBrown;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(279, 608);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(217, 41);
            this.button4.TabIndex = 70;
            this.button4.Text = "আপডেট করুন";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Backbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Backbtn.Location = new System.Drawing.Point(741, 117);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(231, 41);
            this.Backbtn.TabIndex = 65;
            this.Backbtn.Text = "পূর্বের পাতায় ফিরে যান";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(725, 608);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 41);
            this.button2.TabIndex = 69;
            this.button2.Text = "ব্যাকআপ ";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(34, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 41);
            this.button1.TabIndex = 68;
            this.button1.Text = "ডিলিট করুন";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.RosyBrown;
            this.button29.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button29.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button29.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button29.Location = new System.Drawing.Point(502, 608);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(217, 41);
            this.button29.TabIndex = 67;
            this.button29.Text = "প্রিন্ট করুন";
            this.button29.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(303, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 39);
            this.label1.TabIndex = 63;
            this.label1.Text = "দারুল উলূম মুহিউস সুন্নাহ মাদরাসা\r\n";
            // 
            // dUMSMDataBaseDataSet
            // 
            this.dUMSMDataBaseDataSet.DataSetName = "DUMSMDataBaseDataSet";
            this.dUMSMDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // donorsBindingSource
            // 
            this.donorsBindingSource.DataMember = "Donors";
            this.donorsBindingSource.DataSource = this.dUMSMDataBaseDataSet;
            // 
            // donorsTableAdapter
            // 
            this.donorsTableAdapter.ClearBeforeFill = true;
            // 
            // DonorTypetxt
            // 
            this.DonorTypetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorTypetxt.FormattingEnabled = true;
            this.DonorTypetxt.Items.AddRange(new object[] {
            "মাসিক দাতা",
            "বাৎসরিক দাতা"});
            this.DonorTypetxt.Location = new System.Drawing.Point(443, 47);
            this.DonorTypetxt.Name = "DonorTypetxt";
            this.DonorTypetxt.Size = new System.Drawing.Size(135, 32);
            this.DonorTypetxt.TabIndex = 71;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Addresstxt);
            this.groupBox1.Controls.Add(this.DonationAmmounttxt);
            this.groupBox1.Controls.Add(this.Idtxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.MobileNumbertxt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DonorNametxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DonorTypetxt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 436);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 85);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "নতুন দাতা নিবন্ধন";
            // 
            // Addresstxt
            // 
            this.Addresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Addresstxt.Location = new System.Drawing.Point(739, 50);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(157, 29);
            this.Addresstxt.TabIndex = 79;
            // 
            // DonationAmmounttxt
            // 
            this.DonationAmmounttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DonationAmmounttxt.Location = new System.Drawing.Point(584, 50);
            this.DonationAmmounttxt.Name = "DonationAmmounttxt";
            this.DonationAmmounttxt.Size = new System.Drawing.Size(149, 29);
            this.DonationAmmounttxt.TabIndex = 80;
            // 
            // Idtxt
            // 
            this.Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtxt.Location = new System.Drawing.Point(10, 50);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.Size = new System.Drawing.Size(83, 29);
            this.Idtxt.TabIndex = 81;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(748, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 82;
            this.label8.Text = "ঠিকানা ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // MobileNumbertxt
            // 
            this.MobileNumbertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.MobileNumbertxt.Location = new System.Drawing.Point(263, 50);
            this.MobileNumbertxt.Name = "MobileNumbertxt";
            this.MobileNumbertxt.Size = new System.Drawing.Size(174, 29);
            this.MobileNumbertxt.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(584, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 81;
            this.label7.Text = "ধার্যকৃত অনুদান ";
            // 
            // DonorNametxt
            // 
            this.DonorNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorNametxt.Location = new System.Drawing.Point(105, 50);
            this.DonorNametxt.Name = "DonorNametxt";
            this.DonorNametxt.Size = new System.Drawing.Size(152, 29);
            this.DonorNametxt.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(268, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 80;
            this.label6.Text = "মোবাইল";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "দাতার ধরণ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "দাতার নাম";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 77;
            this.label3.Text = "আইডি ";
            // 
            // Resetbtn
            // 
            this.Resetbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Resetbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Resetbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Resetbtn.Location = new System.Drawing.Point(553, 527);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(188, 41);
            this.Resetbtn.TabIndex = 74;
            this.Resetbtn.Text = "তথ্য মুছুন";
            this.Resetbtn.UseVisualStyleBackColor = false;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // Registerbtn
            // 
            this.Registerbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Registerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Registerbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Registerbtn.Location = new System.Drawing.Point(756, 527);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(181, 41);
            this.Registerbtn.TabIndex = 73;
            this.Registerbtn.Text = "নিবন্ধন করুন";
            this.Registerbtn.UseVisualStyleBackColor = false;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.HeaderText = "ডিলিট";
            this.Delete.MinimumWidth = 7;
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
            this.Update.MinimumWidth = 7;
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
            // donorName
            // 
            this.donorName.DataPropertyName = "DonorName";
            this.donorName.HeaderText = "দাতার নাম ";
            this.donorName.Name = "donorName";
            this.donorName.Width = 150;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "MobileNumber";
            this.Mobile.HeaderText = "মোবাইল ";
            this.Mobile.Name = "Mobile";
            this.Mobile.Width = 150;
            // 
            // donorType
            // 
            this.donorType.DataPropertyName = "DonorType";
            this.donorType.HeaderText = "দাতার ধরন ";
            this.donorType.Name = "donorType";
            this.donorType.Width = 130;
            // 
            // donationAmmount
            // 
            this.donationAmmount.DataPropertyName = "DonationAmmount";
            this.donationAmmount.HeaderText = "ধার্যকৃত অনুদান";
            this.donationAmmount.Name = "donationAmmount";
            this.donationAmmount.Width = 130;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "ঠিকানা ";
            this.Address.Name = "Address";
            this.Address.Width = 140;
            // 
            // DonorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.Registerbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DonorList";
            this.Text = "DonorList";
            this.Activated += new System.EventHandler(this.DonorList_Activated);
            this.Load += new System.EventHandler(this.DonorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Donordgv)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dUMSMDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donorsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Donordgv;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Label label1;
        private DUMSMDataBaseDataSet dUMSMDataBaseDataSet;
        private System.Windows.Forms.BindingSource donorsBindingSource;
        private DUMSMDataBaseDataSetTableAdapters.DonorsTableAdapter donorsTableAdapter;
        private System.Windows.Forms.ComboBox DonorTypetxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.Button Registerbtn;
        private System.Windows.Forms.TextBox Idtxt;
        private System.Windows.Forms.TextBox DonorNametxt;
        private System.Windows.Forms.TextBox DonationAmmounttxt;
        private System.Windows.Forms.TextBox Addresstxt;
        private System.Windows.Forms.TextBox MobileNumbertxt;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn donorType;
        private System.Windows.Forms.DataGridViewTextBoxColumn donationAmmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}