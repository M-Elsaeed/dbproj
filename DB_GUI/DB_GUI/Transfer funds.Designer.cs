namespace DB_GUI
{
    partial class Transfer_funds
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
            this.transferBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.toAccountField = new System.Windows.Forms.TextBox();
            this.amountField = new System.Windows.Forms.TextBox();
            this.fromAccountField = new System.Windows.Forms.TextBox();
            this.authorizeLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toSubaccountField = new System.Windows.Forms.TextBox();
            this.fromSubaccountField = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // transferBtn
            // 
            this.transferBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferBtn.Location = new System.Drawing.Point(394, 317);
            this.transferBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(95, 37);
            this.transferBtn.TabIndex = 24;
            this.transferBtn.Text = "Transfer";
            this.transferBtn.UseVisualStyleBackColor = true;
            this.transferBtn.Click += new System.EventHandler(this.transferBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 44);
            this.label6.TabIndex = 23;
            this.label6.Text = "Transfer form";
            // 
            // toAccountField
            // 
            this.toAccountField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAccountField.Location = new System.Drawing.Point(156, 142);
            this.toAccountField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.toAccountField.Name = "toAccountField";
            this.toAccountField.Size = new System.Drawing.Size(159, 24);
            this.toAccountField.TabIndex = 20;
            // 
            // amountField
            // 
            this.amountField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountField.Location = new System.Drawing.Point(156, 248);
            this.amountField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.amountField.Name = "amountField";
            this.amountField.Size = new System.Drawing.Size(130, 24);
            this.amountField.TabIndex = 19;
            // 
            // fromAccountField
            // 
            this.fromAccountField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromAccountField.Location = new System.Drawing.Point(156, 97);
            this.fromAccountField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fromAccountField.Name = "fromAccountField";
            this.fromAccountField.Size = new System.Drawing.Size(159, 24);
            this.fromAccountField.TabIndex = 18;
            // 
            // authorizeLbl
            // 
            this.authorizeLbl.AutoSize = true;
            this.authorizeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorizeLbl.Location = new System.Drawing.Point(391, 270);
            this.authorizeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.authorizeLbl.Name = "authorizeLbl";
            this.authorizeLbl.Size = new System.Drawing.Size(191, 18);
            this.authorizeLbl.TabIndex = 16;
            this.authorizeLbl.Text = "Authorization code : ######";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Account";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(91, 144);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Account";
            // 
            // toSubaccountField
            // 
            this.toSubaccountField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toSubaccountField.Location = new System.Drawing.Point(422, 142);
            this.toSubaccountField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.toSubaccountField.Name = "toSubaccountField";
            this.toSubaccountField.Size = new System.Drawing.Size(151, 24);
            this.toSubaccountField.TabIndex = 27;
            // 
            // fromSubaccountField
            // 
            this.fromSubaccountField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromSubaccountField.Location = new System.Drawing.Point(422, 94);
            this.fromSubaccountField.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fromSubaccountField.Name = "fromSubaccountField";
            this.fromSubaccountField.Size = new System.Drawing.Size(151, 24);
            this.fromSubaccountField.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(331, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "Sub account";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(331, 144);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "Sub account";
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(493, 317);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(96, 37);
            this.backBtn.TabIndex = 31;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // Transfer_funds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 365);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fromSubaccountField);
            this.Controls.Add(this.toSubaccountField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.transferBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toAccountField);
            this.Controls.Add(this.amountField);
            this.Controls.Add(this.fromAccountField);
            this.Controls.Add(this.authorizeLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Transfer_funds";
            this.Text = "Transfer_funds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox toAccountField;
        private System.Windows.Forms.TextBox amountField;
        private System.Windows.Forms.TextBox fromAccountField;
        private System.Windows.Forms.Label authorizeLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox toSubaccountField;
        private System.Windows.Forms.TextBox fromSubaccountField;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button backBtn;
    }
}