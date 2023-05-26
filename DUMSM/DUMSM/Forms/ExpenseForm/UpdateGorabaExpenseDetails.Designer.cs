namespace DUMSM.Forms.ExpenseForm
{
    partial class UpdateGorabaExpenseDetails
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
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RegisterDatetxt = new System.Windows.Forms.TextBox();
            this.Fieldtxt = new System.Windows.Forms.ComboBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.RegisterDateBtn = new System.Windows.Forms.Button();
            this.Ammounttxt = new System.Windows.Forms.TextBox();
            this.Vouchertxt = new System.Windows.Forms.TextBox();
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
            this.tabControl3.Location = new System.Drawing.Point(24, 24);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(406, 333);
            this.tabControl3.TabIndex = 33;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.RegisterDatetxt);
            this.tabPage3.Controls.Add(this.Fieldtxt);
            this.tabPage3.Controls.Add(this.ResetBtn);
            this.tabPage3.Controls.Add(this.RegisterDateBtn);
            this.tabPage3.Controls.Add(this.Ammounttxt);
            this.tabPage3.Controls.Add(this.Vouchertxt);
            this.tabPage3.Controls.Add(this.button14);
            this.tabPage3.Controls.Add(this.button15);
            this.tabPage3.Controls.Add(this.button16);
            this.tabPage3.Controls.Add(this.button17);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(398, 289);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "সাধারণ খরচ আপডেট";
            // 
            // RegisterDatetxt
            // 
            this.RegisterDatetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.RegisterDatetxt.Location = new System.Drawing.Point(191, 164);
            this.RegisterDatetxt.Name = "RegisterDatetxt";
            this.RegisterDatetxt.Size = new System.Drawing.Size(172, 29);
            this.RegisterDatetxt.TabIndex = 33;
            // 
            // Fieldtxt
            // 
            this.Fieldtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fieldtxt.FormattingEnabled = true;
            this.Fieldtxt.Items.AddRange(new object[] {
            "শিক্ষক ও স্টাফ বেতন",
            "বোর্ডিং",
            "নির্মাণ ও মেরামত",
            "লাইব্রেরী",
            "আসবাব পত্র",
            "অনুষ্ঠান / ইফতার",
            "সম্মানী/অডিট/বোর্ড ফি",
            "ফোন",
            "পানি, বিদ্যুৎ ও গ্যাস",
            "ছাপা ও স্টেশনারী",
            "যাতায়াত",
            "ঋণ পরিশোধ  ",
            "বিবিধ "});
            this.Fieldtxt.Location = new System.Drawing.Point(191, 73);
            this.Fieldtxt.Name = "Fieldtxt";
            this.Fieldtxt.Size = new System.Drawing.Size(172, 32);
            this.Fieldtxt.TabIndex = 23;
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.ResetBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ResetBtn.Location = new System.Drawing.Point(6, 215);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(172, 41);
            this.ResetBtn.TabIndex = 32;
            this.ResetBtn.Text = "ফিরে যান";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // RegisterDateBtn
            // 
            this.RegisterDateBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RegisterDateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterDateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.RegisterDateBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RegisterDateBtn.Location = new System.Drawing.Point(184, 215);
            this.RegisterDateBtn.Name = "RegisterDateBtn";
            this.RegisterDateBtn.Size = new System.Drawing.Size(166, 41);
            this.RegisterDateBtn.TabIndex = 31;
            this.RegisterDateBtn.Text = "আপডেট করুন";
            this.RegisterDateBtn.UseVisualStyleBackColor = false;
            this.RegisterDateBtn.Click += new System.EventHandler(this.RegisterDateBtn_Click);
            // 
            // Ammounttxt
            // 
            this.Ammounttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Ammounttxt.Location = new System.Drawing.Point(191, 117);
            this.Ammounttxt.Name = "Ammounttxt";
            this.Ammounttxt.Size = new System.Drawing.Size(172, 29);
            this.Ammounttxt.TabIndex = 30;
            // 
            // Vouchertxt
            // 
            this.Vouchertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vouchertxt.Location = new System.Drawing.Point(191, 23);
            this.Vouchertxt.Name = "Vouchertxt";
            this.Vouchertxt.Size = new System.Drawing.Size(172, 29);
            this.Vouchertxt.TabIndex = 26;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.Enabled = false;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button14.Location = new System.Drawing.Point(6, 112);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(179, 41);
            this.button14.TabIndex = 29;
            this.button14.Text = "খরচের পরিমাণ";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.Enabled = false;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button15.Location = new System.Drawing.Point(6, 65);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(179, 41);
            this.button15.TabIndex = 27;
            this.button15.Text = "খরচের খাত";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.Enabled = false;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button16.Location = new System.Drawing.Point(6, 18);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(179, 41);
            this.button16.TabIndex = 25;
            this.button16.Text = "ভাউচার নং";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.Enabled = false;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button17.Location = new System.Drawing.Point(6, 159);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(177, 41);
            this.button17.TabIndex = 23;
            this.button17.Text = "খরচের তারিখ";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // UpdateGorabaExpenseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 381);
            this.Controls.Add(this.tabControl3);
            this.MaximizeBox = false;
            this.Name = "UpdateGorabaExpenseDetails";
            this.Text = "UpdateGorabaExpenseDetails";
            this.Load += new System.EventHandler(this.UpdateGorabaExpenseDetails_Load);
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox RegisterDatetxt;
        private System.Windows.Forms.ComboBox Fieldtxt;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button RegisterDateBtn;
        private System.Windows.Forms.TextBox Ammounttxt;
        private System.Windows.Forms.TextBox Vouchertxt;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
    }
}