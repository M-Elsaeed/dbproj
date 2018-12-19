namespace DB_GUI
{
    partial class utility
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
            this.label5 = new System.Windows.Forms.Label();
            this.viewTransLbl = new System.Windows.Forms.Label();
            this.changeInfoLbl = new System.Windows.Forms.Label();
            this.changePasswordLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 55);
            this.label5.TabIndex = 9;
            this.label5.Text = "Utility form";
            // 
            // viewTransLbl
            // 
            this.viewTransLbl.AutoSize = true;
            this.viewTransLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTransLbl.Location = new System.Drawing.Point(210, 315);
            this.viewTransLbl.Name = "viewTransLbl";
            this.viewTransLbl.Size = new System.Drawing.Size(376, 32);
            this.viewTransLbl.TabIndex = 7;
            this.viewTransLbl.Text = "View transactions to account";
            this.viewTransLbl.Click += new System.EventHandler(this.label3_Click);
            // 
            // changeInfoLbl
            // 
            this.changeInfoLbl.AutoSize = true;
            this.changeInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeInfoLbl.Location = new System.Drawing.Point(248, 227);
            this.changeInfoLbl.Name = "changeInfoLbl";
            this.changeInfoLbl.Size = new System.Drawing.Size(286, 32);
            this.changeInfoLbl.TabIndex = 6;
            this.changeInfoLbl.Text = "Change personal info";
            // 
            // changePasswordLbl
            // 
            this.changePasswordLbl.AutoSize = true;
            this.changePasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordLbl.Location = new System.Drawing.Point(269, 139);
            this.changePasswordLbl.Name = "changePasswordLbl";
            this.changePasswordLbl.Size = new System.Drawing.Size(243, 32);
            this.changePasswordLbl.TabIndex = 5;
            this.changePasswordLbl.Text = "Change password";
            // 
            // utility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.viewTransLbl);
            this.Controls.Add(this.changeInfoLbl);
            this.Controls.Add(this.changePasswordLbl);
            this.Name = "utility";
            this.Text = "utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label viewTransLbl;
        private System.Windows.Forms.Label changeInfoLbl;
        private System.Windows.Forms.Label changePasswordLbl;
    }
}