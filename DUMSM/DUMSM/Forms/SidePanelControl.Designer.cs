namespace DUMSM.Forms
{
    partial class SidePanelControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProfileBtn = new System.Windows.Forms.Button();
            this.DonationBtn = new System.Windows.Forms.Button();
            this.EmployeeBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.DonorBtn = new System.Windows.Forms.Button();
            this.SalaryBtn = new System.Windows.Forms.Button();
            this.ExpenseBtn = new System.Windows.Forms.Button();
            this.IncomeBtn = new System.Windows.Forms.Button();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.ProfileBtn);
            this.panel2.Controls.Add(this.DonationBtn);
            this.panel2.Controls.Add(this.EmployeeBtn);
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Controls.Add(this.LogoutBtn);
            this.panel2.Controls.Add(this.ReportBtn);
            this.panel2.Controls.Add(this.DonorBtn);
            this.panel2.Controls.Add(this.SalaryBtn);
            this.panel2.Controls.Add(this.ExpenseBtn);
            this.panel2.Controls.Add(this.IncomeBtn);
            this.panel2.Controls.Add(this.DashboardBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 687);
            this.panel2.TabIndex = 55;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // ProfileBtn
            // 
            this.ProfileBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.ProfileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.ProfileBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProfileBtn.Location = new System.Drawing.Point(19, 514);
            this.ProfileBtn.Name = "ProfileBtn";
            this.ProfileBtn.Size = new System.Drawing.Size(152, 41);
            this.ProfileBtn.TabIndex = 16;
            this.ProfileBtn.Text = "প্রোফাইল সেটিংস";
            this.ProfileBtn.UseVisualStyleBackColor = false;
            this.ProfileBtn.Click += new System.EventHandler(this.ProfileBtn_Click);
            // 
            // DonationBtn
            // 
            this.DonationBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DonationBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DonationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.DonationBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DonationBtn.Location = new System.Drawing.Point(19, 173);
            this.DonationBtn.Name = "DonationBtn";
            this.DonationBtn.Size = new System.Drawing.Size(152, 41);
            this.DonationBtn.TabIndex = 15;
            this.DonationBtn.Text = "অনুদান";
            this.DonationBtn.UseVisualStyleBackColor = false;
            this.DonationBtn.Click += new System.EventHandler(this.DonationBtn_Click);
            // 
            // EmployeeBtn
            // 
            this.EmployeeBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.EmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.EmployeeBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EmployeeBtn.Location = new System.Drawing.Point(19, 361);
            this.EmployeeBtn.Name = "EmployeeBtn";
            this.EmployeeBtn.Size = new System.Drawing.Size(152, 41);
            this.EmployeeBtn.TabIndex = 14;
            this.EmployeeBtn.Text = "শিক্ষক-স্টাফ";
            this.EmployeeBtn.UseVisualStyleBackColor = false;
            this.EmployeeBtn.Click += new System.EventHandler(this.EmployeeBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.DeleteBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DeleteBtn.Location = new System.Drawing.Point(19, 561);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(152, 41);
            this.DeleteBtn.TabIndex = 13;
            this.DeleteBtn.Text = "ব্যাকআপ";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.LogoutBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LogoutBtn.Location = new System.Drawing.Point(19, 608);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(152, 41);
            this.LogoutBtn.TabIndex = 12;
            this.LogoutBtn.Text = "লগ আউট";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // ReportBtn
            // 
            this.ReportBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ReportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.ReportBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ReportBtn.Location = new System.Drawing.Point(19, 455);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(152, 41);
            this.ReportBtn.TabIndex = 11;
            this.ReportBtn.Text = "রিপোর্ট";
            this.ReportBtn.UseVisualStyleBackColor = false;
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // DonorBtn
            // 
            this.DonorBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DonorBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DonorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.DonorBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DonorBtn.Location = new System.Drawing.Point(19, 408);
            this.DonorBtn.Name = "DonorBtn";
            this.DonorBtn.Size = new System.Drawing.Size(152, 41);
            this.DonorBtn.TabIndex = 10;
            this.DonorBtn.Text = "স্থায়ী সদস্য";
            this.DonorBtn.UseVisualStyleBackColor = false;
            this.DonorBtn.Click += new System.EventHandler(this.DonorBtn_Click);
            // 
            // SalaryBtn
            // 
            this.SalaryBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SalaryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalaryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.SalaryBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.SalaryBtn.Location = new System.Drawing.Point(19, 314);
            this.SalaryBtn.Name = "SalaryBtn";
            this.SalaryBtn.Size = new System.Drawing.Size(152, 41);
            this.SalaryBtn.TabIndex = 9;
            this.SalaryBtn.Text = "বেতনের তথ্য";
            this.SalaryBtn.UseVisualStyleBackColor = false;
            this.SalaryBtn.Click += new System.EventHandler(this.SalaryBtn_Click);
            // 
            // ExpenseBtn
            // 
            this.ExpenseBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ExpenseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExpenseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.ExpenseBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExpenseBtn.Location = new System.Drawing.Point(19, 267);
            this.ExpenseBtn.Name = "ExpenseBtn";
            this.ExpenseBtn.Size = new System.Drawing.Size(152, 41);
            this.ExpenseBtn.TabIndex = 8;
            this.ExpenseBtn.Text = "খরচ";
            this.ExpenseBtn.UseVisualStyleBackColor = false;
            this.ExpenseBtn.Click += new System.EventHandler(this.ExpenseBtn_Click);
            // 
            // IncomeBtn
            // 
            this.IncomeBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.IncomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.IncomeBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IncomeBtn.Location = new System.Drawing.Point(19, 220);
            this.IncomeBtn.Name = "IncomeBtn";
            this.IncomeBtn.Size = new System.Drawing.Size(152, 41);
            this.IncomeBtn.TabIndex = 7;
            this.IncomeBtn.Text = "জমা";
            this.IncomeBtn.UseVisualStyleBackColor = false;
            this.IncomeBtn.Click += new System.EventHandler(this.IncomeBtn_Click);
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.DashboardBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DashboardBtn.Location = new System.Drawing.Point(19, 126);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(152, 41);
            this.DashboardBtn.TabIndex = 6;
            this.DashboardBtn.Text = "ড্যাশবোর্ড";
            this.DashboardBtn.UseVisualStyleBackColor = false;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // SidePanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel2);
            this.Name = "SidePanelControl";
            this.Size = new System.Drawing.Size(189, 687);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ProfileBtn;
        private System.Windows.Forms.Button DonationBtn;
        private System.Windows.Forms.Button EmployeeBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button ReportBtn;
        private System.Windows.Forms.Button DonorBtn;
        private System.Windows.Forms.Button SalaryBtn;
        private System.Windows.Forms.Button ExpenseBtn;
        private System.Windows.Forms.Button IncomeBtn;
        private System.Windows.Forms.Button DashboardBtn;
    }
}
