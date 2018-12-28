﻿namespace DB_GUI
{
    partial class viewTransactions
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
            this.backBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maxAmountField = new System.Windows.Forms.TextBox();
            this.minAmountField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.viewBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toBranchField = new System.Windows.Forms.TextBox();
            this.fromBranchField = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.sortDrop = new System.Windows.Forms.ComboBox();
            this.sortDirDrop = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(736, 483);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(144, 57);
            this.backBtn.TabIndex = 47;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 26);
            this.label10.TabIndex = 46;
            this.label10.Text = "Min Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(492, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 26);
            this.label9.TabIndex = 45;
            this.label9.Text = "Max Amount";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // maxAmountField
            // 
            this.maxAmountField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxAmountField.Location = new System.Drawing.Point(629, 288);
            this.maxAmountField.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.maxAmountField.Name = "maxAmountField";
            this.maxAmountField.Size = new System.Drawing.Size(224, 32);
            this.maxAmountField.TabIndex = 44;
            // 
            // minAmountField
            // 
            this.minAmountField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minAmountField.Location = new System.Drawing.Point(158, 291);
            this.minAmountField.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.minAmountField.Name = "minAmountField";
            this.minAmountField.Size = new System.Drawing.Size(224, 32);
            this.minAmountField.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-175, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 26);
            this.label8.TabIndex = 42;
            this.label8.Text = "Account";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-175, -8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 26);
            this.label7.TabIndex = 41;
            this.label7.Text = "Account";
            // 
            // viewBtn
            // 
            this.viewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBtn.Location = new System.Drawing.Point(587, 483);
            this.viewBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(142, 57);
            this.viewBtn.TabIndex = 40;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = true;
            this.viewBtn.Click += new System.EventHandler(this.transferBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(514, 65);
            this.label6.TabIndex = 39;
            this.label6.Text = "View Transactions";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-231, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 26);
            this.label3.TabIndex = 34;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-277, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-277, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 26);
            this.label4.TabIndex = 55;
            this.label4.Text = "Branch Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 26);
            this.label5.TabIndex = 54;
            this.label5.Text = "Branch Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // toBranchField
            // 
            this.toBranchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toBranchField.Location = new System.Drawing.Point(272, 210);
            this.toBranchField.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.toBranchField.Name = "toBranchField";
            this.toBranchField.Size = new System.Drawing.Size(182, 32);
            this.toBranchField.TabIndex = 53;
            // 
            // fromBranchField
            // 
            this.fromBranchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromBranchField.Location = new System.Drawing.Point(272, 141);
            this.fromBranchField.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.fromBranchField.Name = "fromBranchField";
            this.fromBranchField.Size = new System.Drawing.Size(182, 32);
            this.fromBranchField.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 26);
            this.label12.TabIndex = 49;
            this.label12.Text = "To";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 26);
            this.label13.TabIndex = 48;
            this.label13.Text = "From";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 26);
            this.label11.TabIndex = 57;
            this.label11.Text = "Sort By";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(492, 389);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 26);
            this.label14.TabIndex = 59;
            this.label14.Text = "sort";
            // 
            // sortDrop
            // 
            this.sortDrop.FormattingEnabled = true;
            this.sortDrop.Items.AddRange(new object[] {
            "Customer Name",
            "Amount"});
            this.sortDrop.Location = new System.Drawing.Point(158, 392);
            this.sortDrop.Name = "sortDrop";
            this.sortDrop.Size = new System.Drawing.Size(121, 28);
            this.sortDrop.TabIndex = 60;
            this.sortDrop.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sortDirDrop
            // 
            this.sortDirDrop.FormattingEnabled = true;
            this.sortDirDrop.Items.AddRange(new object[] {
            "Ascending",
            "Decending"});
            this.sortDirDrop.Location = new System.Drawing.Point(629, 387);
            this.sortDirDrop.Name = "sortDirDrop";
            this.sortDirDrop.Size = new System.Drawing.Size(121, 28);
            this.sortDirDrop.TabIndex = 61;
            // 
            // viewTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 575);
            this.Controls.Add(this.sortDirDrop);
            this.Controls.Add(this.sortDrop);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toBranchField);
            this.Controls.Add(this.fromBranchField);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maxAmountField);
            this.Controls.Add(this.minAmountField);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewTransactions";
            this.Text = "viewTransactions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox maxAmountField;
        private System.Windows.Forms.TextBox minAmountField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox toBranchField;
        private System.Windows.Forms.TextBox fromBranchField;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox sortDrop;
        private System.Windows.Forms.ComboBox sortDirDrop;
    }
}