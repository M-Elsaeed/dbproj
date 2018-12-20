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
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 55);
            this.label6.TabIndex = 24;
            this.label6.Text = "Services";
            // 
            // withdrawLbl
            // 
            this.withdrawLbl.AutoSize = true;
            this.withdrawLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawLbl.Location = new System.Drawing.Point(338, 179);
            this.withdrawLbl.Name = "withdrawLbl";
            this.withdrawLbl.Size = new System.Drawing.Size(141, 36);
            this.withdrawLbl.TabIndex = 26;
            this.withdrawLbl.Text = "Withdraw";
            // 
            // transferFundsLbl
            // 
            this.transferFundsLbl.AutoSize = true;
            this.transferFundsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferFundsLbl.Location = new System.Drawing.Point(306, 106);
            this.transferFundsLbl.Name = "transferFundsLbl";
            this.transferFundsLbl.Size = new System.Drawing.Size(217, 36);
            this.transferFundsLbl.TabIndex = 27;
            this.transferFundsLbl.Text = "Transfer Funds";
            // 
            // depositLbl
            // 
            this.depositLbl.AutoSize = true;
            this.depositLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositLbl.Location = new System.Drawing.Point(347, 252);
            this.depositLbl.Name = "depositLbl";
            this.depositLbl.Size = new System.Drawing.Size(116, 36);
            this.depositLbl.TabIndex = 28;
            this.depositLbl.Text = "Deposit";
            // 
            // settingsLbl
            // 
            this.settingsLbl.AutoSize = true;
            this.settingsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLbl.Location = new System.Drawing.Point(347, 327);
            this.settingsLbl.Name = "settingsLbl";
            this.settingsLbl.Size = new System.Drawing.Size(123, 36);
            this.settingsLbl.TabIndex = 29;
            this.settingsLbl.Text = "Settings";
            // 
            // services_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.settingsLbl);
            this.Controls.Add(this.depositLbl);
            this.Controls.Add(this.transferFundsLbl);
            this.Controls.Add(this.withdrawLbl);
            this.Controls.Add(this.label6);
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
    }
}