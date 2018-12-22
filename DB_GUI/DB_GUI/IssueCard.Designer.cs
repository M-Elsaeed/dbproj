namespace DB_GUI
{
    partial class IssueCard
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
            this.IssueBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.accountIDTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Depositlbl = new System.Windows.Forms.Label();
            this.issueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.expiryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dailyLimitTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cardTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.issuerComboBox = new System.Windows.Forms.ComboBox();
            this.cardDurationComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(693, 402);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(96, 37);
            this.backBtn.TabIndex = 37;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // IssueBtn
            // 
            this.IssueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueBtn.Location = new System.Drawing.Point(594, 402);
            this.IssueBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.IssueBtn.Name = "IssueBtn";
            this.IssueBtn.Size = new System.Drawing.Size(95, 37);
            this.IssueBtn.TabIndex = 36;
            this.IssueBtn.Text = "Issue";
            this.IssueBtn.UseVisualStyleBackColor = true;
            this.IssueBtn.Click += new System.EventHandler(this.IssueBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 51;
            this.label4.Text = "Issuer";
            // 
            // accountIDTxtBox
            // 
            this.accountIDTxtBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountIDTxtBox.Location = new System.Drawing.Point(306, 88);
            this.accountIDTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.accountIDTxtBox.Name = "accountIDTxtBox";
            this.accountIDTxtBox.Size = new System.Drawing.Size(200, 29);
            this.accountIDTxtBox.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 49;
            this.label2.Text = "Account ID";
            // 
            // Depositlbl
            // 
            this.Depositlbl.AutoSize = true;
            this.Depositlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Depositlbl.Location = new System.Drawing.Point(12, 9);
            this.Depositlbl.Name = "Depositlbl";
            this.Depositlbl.Size = new System.Drawing.Size(208, 42);
            this.Depositlbl.TabIndex = 53;
            this.Depositlbl.Text = "Issue Card";
            // 
            // issueDateTimePicker
            // 
            this.issueDateTimePicker.Enabled = false;
            this.issueDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.issueDateTimePicker.Location = new System.Drawing.Point(306, 201);
            this.issueDateTimePicker.Name = "issueDateTimePicker";
            this.issueDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.issueDateTimePicker.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 55;
            this.label1.Text = "Issue Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 57;
            this.label3.Text = "Expiry Date";
            // 
            // expiryDateTimePicker
            // 
            this.expiryDateTimePicker.Enabled = false;
            this.expiryDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expiryDateTimePicker.Location = new System.Drawing.Point(306, 248);
            this.expiryDateTimePicker.Name = "expiryDateTimePicker";
            this.expiryDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.expiryDateTimePicker.TabIndex = 56;
            // 
            // dailyLimitTxtBox
            // 
            this.dailyLimitTxtBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyLimitTxtBox.Location = new System.Drawing.Point(306, 300);
            this.dailyLimitTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.dailyLimitTxtBox.Name = "dailyLimitTxtBox";
            this.dailyLimitTxtBox.Size = new System.Drawing.Size(200, 29);
            this.dailyLimitTxtBox.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 307);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 58;
            this.label5.Text = "Daily Limit";
            // 
            // cardTypeComboBox
            // 
            this.cardTypeComboBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardTypeComboBox.FormattingEnabled = true;
            this.cardTypeComboBox.Items.AddRange(new object[] {
            "Debit",
            "Credit"});
            this.cardTypeComboBox.Location = new System.Drawing.Point(306, 358);
            this.cardTypeComboBox.Name = "cardTypeComboBox";
            this.cardTypeComboBox.Size = new System.Drawing.Size(200, 30);
            this.cardTypeComboBox.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 361);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 60;
            this.label6.Text = "Card Type";
            // 
            // issuerComboBox
            // 
            this.issuerComboBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuerComboBox.FormattingEnabled = true;
            this.issuerComboBox.Items.AddRange(new object[] {
            "Visa",
            "MasterCard",
            "American Express",
            "Chase",
            "Discover",
            "Citibank",
            "Capital One"});
            this.issuerComboBox.Location = new System.Drawing.Point(306, 144);
            this.issuerComboBox.Name = "issuerComboBox";
            this.issuerComboBox.Size = new System.Drawing.Size(200, 30);
            this.issuerComboBox.TabIndex = 52;
            // 
            // cardDurationComboBox
            // 
            this.cardDurationComboBox.FormattingEnabled = true;
            this.cardDurationComboBox.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.cardDurationComboBox.Location = new System.Drawing.Point(693, 202);
            this.cardDurationComboBox.Name = "cardDurationComboBox";
            this.cardDurationComboBox.Size = new System.Drawing.Size(64, 21);
            this.cardDurationComboBox.TabIndex = 62;
            this.cardDurationComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(546, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 22);
            this.label7.TabIndex = 63;
            this.label7.Text = "Card Duration";
            // 
            // IssueCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cardDurationComboBox);
            this.Controls.Add(this.cardTypeComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dailyLimitTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.expiryDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.issueDateTimePicker);
            this.Controls.Add(this.Depositlbl);
            this.Controls.Add(this.issuerComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accountIDTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.IssueBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueCard";
            this.Text = "IssueCard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button IssueBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox accountIDTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Depositlbl;
        private System.Windows.Forms.DateTimePicker issueDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker expiryDateTimePicker;
        private System.Windows.Forms.TextBox dailyLimitTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cardTypeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox issuerComboBox;
        private System.Windows.Forms.ComboBox cardDurationComboBox;
        private System.Windows.Forms.Label label7;
    }
}