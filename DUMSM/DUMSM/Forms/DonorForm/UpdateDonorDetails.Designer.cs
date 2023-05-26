namespace DUMSM
{
    partial class UpdateDonorDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDonorDetails));
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Idtxt = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.DonorTypetxt = new System.Windows.Forms.ComboBox();
            this.button10 = new System.Windows.Forms.Button();
            this.DonationAmmounttxt = new System.Windows.Forms.TextBox();
            this.Addresstxt = new System.Windows.Forms.TextBox();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.MobileNumbertxt = new System.Windows.Forms.TextBox();
            this.DonorNametxt = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.tabControl3.Location = new System.Drawing.Point(16, 12);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(432, 410);
            this.tabControl3.TabIndex = 50;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.Idtxt);
            this.tabPage3.Controls.Add(this.button12);
            this.tabPage3.Controls.Add(this.DonorTypetxt);
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.DonationAmmounttxt);
            this.tabPage3.Controls.Add(this.Addresstxt);
            this.tabPage3.Controls.Add(this.Registerbtn);
            this.tabPage3.Controls.Add(this.MobileNumbertxt);
            this.tabPage3.Controls.Add(this.DonorNametxt);
            this.tabPage3.Controls.Add(this.button14);
            this.tabPage3.Controls.Add(this.button15);
            this.tabPage3.Controls.Add(this.button16);
            this.tabPage3.Controls.Add(this.button17);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(424, 366);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "দাতার তথ্য আপডেট করুন    ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(6, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 41);
            this.button1.TabIndex = 39;
            this.button1.Text = "বাতিল করুন";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Idtxt
            // 
            this.Idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtxt.Location = new System.Drawing.Point(194, 63);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.ReadOnly = true;
            this.Idtxt.Size = new System.Drawing.Size(214, 29);
            this.Idtxt.TabIndex = 38;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Enabled = false;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button12.Location = new System.Drawing.Point(9, 58);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(179, 41);
            this.button12.TabIndex = 37;
            this.button12.Text = "আইডি নাম্বার";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // DonorTypetxt
            // 
            this.DonorTypetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorTypetxt.FormattingEnabled = true;
            this.DonorTypetxt.Items.AddRange(new object[] {
            "মাসিক দাতা",
            "বাৎসরিক দাতা"});
            this.DonorTypetxt.Location = new System.Drawing.Point(194, 110);
            this.DonorTypetxt.Name = "DonorTypetxt";
            this.DonorTypetxt.Size = new System.Drawing.Size(214, 32);
            this.DonorTypetxt.TabIndex = 36;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Enabled = false;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button10.Location = new System.Drawing.Point(9, 105);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(179, 41);
            this.button10.TabIndex = 35;
            this.button10.Text = "দাতার ধরণ";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // DonationAmmounttxt
            // 
            this.DonationAmmounttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DonationAmmounttxt.Location = new System.Drawing.Point(194, 257);
            this.DonationAmmounttxt.Name = "DonationAmmounttxt";
            this.DonationAmmounttxt.Size = new System.Drawing.Size(214, 29);
            this.DonationAmmounttxt.TabIndex = 34;
            // 
            // Addresstxt
            // 
            this.Addresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Addresstxt.Location = new System.Drawing.Point(194, 205);
            this.Addresstxt.Name = "Addresstxt";
            this.Addresstxt.Size = new System.Drawing.Size(214, 29);
            this.Addresstxt.TabIndex = 33;
            // 
            // Registerbtn
            // 
            this.Registerbtn.BackColor = System.Drawing.Color.RosyBrown;
            this.Registerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Registerbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Registerbtn.Location = new System.Drawing.Point(194, 304);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(214, 41);
            this.Registerbtn.TabIndex = 31;
            this.Registerbtn.Text = "আপডেট করুন";
            this.Registerbtn.UseVisualStyleBackColor = false;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // MobileNumbertxt
            // 
            this.MobileNumbertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.MobileNumbertxt.Location = new System.Drawing.Point(194, 158);
            this.MobileNumbertxt.Name = "MobileNumbertxt";
            this.MobileNumbertxt.Size = new System.Drawing.Size(214, 29);
            this.MobileNumbertxt.TabIndex = 30;
            // 
            // DonorNametxt
            // 
            this.DonorNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorNametxt.Location = new System.Drawing.Point(194, 23);
            this.DonorNametxt.Name = "DonorNametxt";
            this.DonorNametxt.Size = new System.Drawing.Size(214, 29);
            this.DonorNametxt.TabIndex = 26;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.Enabled = false;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button14.Location = new System.Drawing.Point(6, 200);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(179, 41);
            this.button14.TabIndex = 29;
            this.button14.Text = "ঠিকানা";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.Enabled = false;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button15.Location = new System.Drawing.Point(6, 153);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(179, 41);
            this.button15.TabIndex = 27;
            this.button15.Text = "মোবাইল নাম্বার";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.Enabled = false;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button16.Location = new System.Drawing.Point(9, 15);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(179, 41);
            this.button16.TabIndex = 25;
            this.button16.Text = "দাতার নাম";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.Enabled = false;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button17.Location = new System.Drawing.Point(6, 252);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(177, 41);
            this.button17.TabIndex = 23;
            this.button17.Text = "ধার্যকৃত অনুদান";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // UpdateDonorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 427);
            this.Controls.Add(this.tabControl3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UpdateDonorDetails";
            this.Text = "UpdateDonorDetails";
            this.Load += new System.EventHandler(this.UpdateDonorDetails_Load);
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Idtxt;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ComboBox DonorTypetxt;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox DonationAmmounttxt;
        private System.Windows.Forms.TextBox Addresstxt;
        private System.Windows.Forms.Button Registerbtn;
        private System.Windows.Forms.TextBox MobileNumbertxt;
        private System.Windows.Forms.TextBox DonorNametxt;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
    }
}