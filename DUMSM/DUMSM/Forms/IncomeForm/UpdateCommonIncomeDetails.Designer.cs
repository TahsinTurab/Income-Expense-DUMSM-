namespace DUMSM.Forms.IncomeForm
{
    partial class UpdateCommonIncomeDetails
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
            this.Fieldtxt = new System.Windows.Forms.ComboBox();
            this.Backbtn = new System.Windows.Forms.Button();
            this.GeneralRegisterbtn = new System.Windows.Forms.Button();
            this.Ammounttxt = new System.Windows.Forms.TextBox();
            this.SlipNumbertxt = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.RegisterDatetxt = new System.Windows.Forms.TextBox();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.tabControl3.Location = new System.Drawing.Point(12, 12);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(430, 331);
            this.tabControl3.TabIndex = 23;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.RegisterDatetxt);
            this.tabPage3.Controls.Add(this.Fieldtxt);
            this.tabPage3.Controls.Add(this.Backbtn);
            this.tabPage3.Controls.Add(this.GeneralRegisterbtn);
            this.tabPage3.Controls.Add(this.Ammounttxt);
            this.tabPage3.Controls.Add(this.SlipNumbertxt);
            this.tabPage3.Controls.Add(this.button14);
            this.tabPage3.Controls.Add(this.button15);
            this.tabPage3.Controls.Add(this.button16);
            this.tabPage3.Controls.Add(this.button17);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(422, 287);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "সাধারণ জমা আপডেট    ";
            // 
            // Fieldtxt
            // 
            this.Fieldtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fieldtxt.FormattingEnabled = true;
            this.Fieldtxt.Items.AddRange(new object[] {
            "ফরম / ভর্তি ফি",
            "শিক্ষার্থীর বেতন",
            "বোডিং/খানার চার্জ",
            "নির্মাণ ও মেরামত",
            "লাইব্রেরী",
            "অনুষ্ঠান / ইফতার  ",
            "বিবিধ "});
            this.Fieldtxt.Location = new System.Drawing.Point(187, 58);
            this.Fieldtxt.Name = "Fieldtxt";
            this.Fieldtxt.Size = new System.Drawing.Size(227, 32);
            this.Fieldtxt.TabIndex = 23;
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Backbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Backbtn.Location = new System.Drawing.Point(70, 214);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(172, 41);
            this.Backbtn.TabIndex = 32;
            this.Backbtn.Text = "বাতিল করুন";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // GeneralRegisterbtn
            // 
            this.GeneralRegisterbtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GeneralRegisterbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GeneralRegisterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.GeneralRegisterbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GeneralRegisterbtn.Location = new System.Drawing.Point(248, 214);
            this.GeneralRegisterbtn.Name = "GeneralRegisterbtn";
            this.GeneralRegisterbtn.Size = new System.Drawing.Size(166, 41);
            this.GeneralRegisterbtn.TabIndex = 31;
            this.GeneralRegisterbtn.Text = "আপডেট করুন";
            this.GeneralRegisterbtn.UseVisualStyleBackColor = false;
            this.GeneralRegisterbtn.Click += new System.EventHandler(this.GeneralRegisterbtn_Click);
            // 
            // Ammounttxt
            // 
            this.Ammounttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Ammounttxt.Location = new System.Drawing.Point(187, 105);
            this.Ammounttxt.Name = "Ammounttxt";
            this.Ammounttxt.Size = new System.Drawing.Size(227, 29);
            this.Ammounttxt.TabIndex = 30;
            // 
            // SlipNumbertxt
            // 
            this.SlipNumbertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlipNumbertxt.Location = new System.Drawing.Point(187, 11);
            this.SlipNumbertxt.Name = "SlipNumbertxt";
            this.SlipNumbertxt.Size = new System.Drawing.Size(227, 29);
            this.SlipNumbertxt.TabIndex = 26;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.Enabled = false;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button14.Location = new System.Drawing.Point(6, 100);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(179, 41);
            this.button14.TabIndex = 29;
            this.button14.Text = "জমা দানের পরিমাণ";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.Enabled = false;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button15.Location = new System.Drawing.Point(6, 53);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(179, 41);
            this.button15.TabIndex = 27;
            this.button15.Text = "জমা দানের খাত";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.Enabled = false;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button16.Location = new System.Drawing.Point(6, 6);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(179, 41);
            this.button16.TabIndex = 25;
            this.button16.Text = "রশিদ নং";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.Enabled = false;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button17.Location = new System.Drawing.Point(6, 147);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(177, 41);
            this.button17.TabIndex = 23;
            this.button17.Text = "জমাদানের তারিখ";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // RegisterDatetxt
            // 
            this.RegisterDatetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.RegisterDatetxt.Location = new System.Drawing.Point(187, 152);
            this.RegisterDatetxt.Name = "RegisterDatetxt";
            this.RegisterDatetxt.Size = new System.Drawing.Size(227, 29);
            this.RegisterDatetxt.TabIndex = 33;
            // 
            // UpdateCommonIncomeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 381);
            this.Controls.Add(this.tabControl3);
            this.Name = "UpdateCommonIncomeDetails";
            this.Text = "UpdateCommonIncomeDetails";
            this.Load += new System.EventHandler(this.UpdateCommonIncomeDetails_Load);
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
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button GeneralRegisterbtn;
        private System.Windows.Forms.TextBox Ammounttxt;
        private System.Windows.Forms.TextBox SlipNumbertxt;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
    }
}