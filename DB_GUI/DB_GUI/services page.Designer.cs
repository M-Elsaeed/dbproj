namespace DB_GUI
{
    partial class services_page
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
            this.label6 = new System.Windows.Forms.Label();
            this.withdrawLbl = new System.Windows.Forms.Label();
            this.transferFundsLbl = new System.Windows.Forms.Label();
            this.depositLbl = new System.Windows.Forms.Label();
            this.settingsLbl = new System.Windows.Forms.Label();
            this.openAccountLbl = new System.Windows.Forms.Label();
            this.ExitLbl = new System.Windows.Forms.Label();
            this.EmployeeTypeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 29.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 44);
            this.label6.TabIndex = 24;
            this.label6.Text = "Services";
            // 
            // withdrawLbl
            // 
            this.withdrawLbl.AutoSize = true;
            this.withdrawLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawLbl.Location = new System.Drawing.Point(241, 184);
            this.withdrawLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.withdrawLbl.Name = "withdrawLbl";
            this.withdrawLbl.Size = new System.Drawing.Size(88, 22);
            this.withdrawLbl.TabIndex = 3;
            this.withdrawLbl.Text = "Withdraw";
            this.withdrawLbl.Click += new System.EventHandler(this.withdrawLbl_Click);
            // 
            // transferFundsLbl
            // 
            this.transferFundsLbl.AutoSize = true;
            this.transferFundsLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferFundsLbl.Location = new System.Drawing.Point(215, 140);
            this.transferFundsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.transferFundsLbl.Name = "transferFundsLbl";
            this.transferFundsLbl.Size = new System.Drawing.Size(138, 22);
            this.transferFundsLbl.TabIndex = 2;
            this.transferFundsLbl.Text = "Transfer Funds";
            this.transferFundsLbl.Click += new System.EventHandler(this.transferFundsLbl_Click);
            // 
            // depositLbl
            // 
            this.depositLbl.AutoSize = true;
            this.depositLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLbl.Location = new System.Drawing.Point(250, 233);
            this.depositLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.depositLbl.Name = "depositLbl";
            this.depositLbl.Size = new System.Drawing.Size(76, 22);
            this.depositLbl.TabIndex = 4;
            this.depositLbl.Text = "Deposit";
            this.depositLbl.Click += new System.EventHandler(this.depositLbl_Click);
            // 
            // settingsLbl
            // 
            this.settingsLbl.AutoSize = true;
            this.settingsLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLbl.Location = new System.Drawing.Point(250, 282);
            this.settingsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.settingsLbl.Name = "settingsLbl";
            this.settingsLbl.Size = new System.Drawing.Size(79, 22);
            this.settingsLbl.TabIndex = 5;
            this.settingsLbl.Text = "Settings";
            this.settingsLbl.Click += new System.EventHandler(this.settingsLbl_Click);
            // 
            // openAccountLbl
            // 
            this.openAccountLbl.AutoSize = true;
            this.openAccountLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAccountLbl.Location = new System.Drawing.Point(174, 96);
            this.openAccountLbl.Name = "openAccountLbl";
            this.openAccountLbl.Size = new System.Drawing.Size(219, 22);
            this.openAccountLbl.TabIndex = 1;
            this.openAccountLbl.Text = "Open a new sub-account";
            this.openAccountLbl.Click += new System.EventHandler(this.openAccountLbl_Click);
            // 
            // ExitLbl
            // 
            this.ExitLbl.AutoSize = true;
            this.ExitLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLbl.Location = new System.Drawing.Point(271, 328);
            this.ExitLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExitLbl.Name = "ExitLbl";
            this.ExitLbl.Size = new System.Drawing.Size(41, 22);
            this.ExitLbl.TabIndex = 6;
            this.ExitLbl.Text = "Exit";
            this.ExitLbl.Click += new System.EventHandler(this.ExitLbl_Click);
            // 
            // EmployeeTypeLbl
            // 
            this.EmployeeTypeLbl.AutoSize = true;
            this.EmployeeTypeLbl.ForeColor = System.Drawing.Color.Red;
            this.EmployeeTypeLbl.Location = new System.Drawing.Point(535, 9);
            this.EmployeeTypeLbl.Name = "EmployeeTypeLbl";
            this.EmployeeTypeLbl.Size = new System.Drawing.Size(0, 13);
            this.EmployeeTypeLbl.TabIndex = 25;
            // 
            // services_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.EmployeeTypeLbl);
            this.Controls.Add(this.ExitLbl);
            this.Controls.Add(this.openAccountLbl);
            this.Controls.Add(this.settingsLbl);
            this.Controls.Add(this.depositLbl);
            this.Controls.Add(this.transferFundsLbl);
            this.Controls.Add(this.withdrawLbl);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "services_page";
            this.Text = "services_page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label withdrawLbl;
        private System.Windows.Forms.Label transferFundsLbl;
        private System.Windows.Forms.Label depositLbl;
        private System.Windows.Forms.Label settingsLbl;
        private System.Windows.Forms.Label openAccountLbl;
        private System.Windows.Forms.Label ExitLbl;
        private System.Windows.Forms.Label EmployeeTypeLbl;
    }
}