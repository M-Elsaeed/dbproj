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
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 44);
            this.label6.TabIndex = 24;
            this.label6.Text = "Services";
            // 
            // withdrawLbl
            // 
            this.withdrawLbl.AutoSize = true;
            this.withdrawLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawLbl.Location = new System.Drawing.Point(238, 179);
            this.withdrawLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.withdrawLbl.Name = "withdrawLbl";
            this.withdrawLbl.Size = new System.Drawing.Size(113, 29);
            this.withdrawLbl.TabIndex = 26;
            this.withdrawLbl.Text = "Withdraw";
            // 
            // transferFundsLbl
            // 
            this.transferFundsLbl.AutoSize = true;
            this.transferFundsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferFundsLbl.Location = new System.Drawing.Point(213, 124);
            this.transferFundsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.transferFundsLbl.Name = "transferFundsLbl";
            this.transferFundsLbl.Size = new System.Drawing.Size(176, 29);
            this.transferFundsLbl.TabIndex = 27;
            this.transferFundsLbl.Text = "Transfer Funds";
            this.transferFundsLbl.Click += new System.EventHandler(this.transferFundsLbl_Click);
            // 
            // depositLbl
            // 
            this.depositLbl.AutoSize = true;
            this.depositLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLbl.Location = new System.Drawing.Point(251, 233);
            this.depositLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.depositLbl.Name = "depositLbl";
            this.depositLbl.Size = new System.Drawing.Size(96, 29);
            this.depositLbl.TabIndex = 28;
            this.depositLbl.Text = "Deposit";
            // 
            // settingsLbl
            // 
            this.settingsLbl.AutoSize = true;
            this.settingsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLbl.Location = new System.Drawing.Point(251, 284);
            this.settingsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.settingsLbl.Name = "settingsLbl";
            this.settingsLbl.Size = new System.Drawing.Size(100, 29);
            this.settingsLbl.TabIndex = 29;
            this.settingsLbl.Text = "Settings";
            this.settingsLbl.Click += new System.EventHandler(this.settingsLbl_Click);
            // 
            // openAccountLbl
            // 
            this.openAccountLbl.AutoSize = true;
            this.openAccountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAccountLbl.Location = new System.Drawing.Point(162, 72);
            this.openAccountLbl.Name = "openAccountLbl";
            this.openAccountLbl.Size = new System.Drawing.Size(279, 29);
            this.openAccountLbl.TabIndex = 31;
            this.openAccountLbl.Text = "Open a new sub-account";
            // 
            // ExitLbl
            // 
            this.ExitLbl.AutoSize = true;
            this.ExitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLbl.Location = new System.Drawing.Point(271, 328);
            this.ExitLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExitLbl.Name = "ExitLbl";
            this.ExitLbl.Size = new System.Drawing.Size(52, 29);
            this.ExitLbl.TabIndex = 32;
            this.ExitLbl.Text = "Exit";
            this.ExitLbl.Click += new System.EventHandler(this.ExitLbl_Click);
            // 
            // services_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
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
    }
}