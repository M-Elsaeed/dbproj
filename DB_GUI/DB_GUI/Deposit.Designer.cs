namespace DB_GUI
{
    partial class Deposit
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
            this.depositBtn = new System.Windows.Forms.Button();
            this.Depositlbl = new System.Windows.Forms.Label();
            this.AccountIDTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AmountTxtBox = new System.Windows.Forms.TextBox();
            this.AmountLbl = new System.Windows.Forms.Label();
            this.AccountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CurrencyComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(693, 402);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(96, 37);
            this.backBtn.TabIndex = 35;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // depositBtn
            // 
            this.depositBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositBtn.Location = new System.Drawing.Point(594, 402);
            this.depositBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(95, 37);
            this.depositBtn.TabIndex = 34;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // Depositlbl
            // 
            this.Depositlbl.AutoSize = true;
            this.Depositlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Depositlbl.Location = new System.Drawing.Point(12, 9);
            this.Depositlbl.Name = "Depositlbl";
            this.Depositlbl.Size = new System.Drawing.Size(152, 42);
            this.Depositlbl.TabIndex = 39;
            this.Depositlbl.Text = "Deposit";
            // 
            // AccountIDTxtBox
            // 
            this.AccountIDTxtBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountIDTxtBox.Location = new System.Drawing.Point(251, 83);
            this.AccountIDTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.AccountIDTxtBox.Name = "AccountIDTxtBox";
            this.AccountIDTxtBox.Size = new System.Drawing.Size(200, 29);
            this.AccountIDTxtBox.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 41;
            this.label2.Text = "Account ID";
            // 
            // AmountTxtBox
            // 
            this.AmountTxtBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountTxtBox.Location = new System.Drawing.Point(251, 329);
            this.AmountTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.AmountTxtBox.Name = "AmountTxtBox";
            this.AmountTxtBox.Size = new System.Drawing.Size(200, 29);
            this.AmountTxtBox.TabIndex = 44;
            // 
            // AmountLbl
            // 
            this.AmountLbl.AutoSize = true;
            this.AmountLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountLbl.Location = new System.Drawing.Point(52, 332);
            this.AmountLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AmountLbl.Name = "AmountLbl";
            this.AmountLbl.Size = new System.Drawing.Size(75, 22);
            this.AmountLbl.TabIndex = 43;
            this.AmountLbl.Text = "Amount";
            // 
            // AccountTypeComboBox
            // 
            this.AccountTypeComboBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTypeComboBox.FormattingEnabled = true;
            this.AccountTypeComboBox.Items.AddRange(new object[] {
            "Checking Accounts",
            "Dividend Checking",
            "Savings Accounts",
            "Current Accounts"});
            this.AccountTypeComboBox.Location = new System.Drawing.Point(251, 150);
            this.AccountTypeComboBox.Name = "AccountTypeComboBox";
            this.AccountTypeComboBox.Size = new System.Drawing.Size(200, 30);
            this.AccountTypeComboBox.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 22);
            this.label4.TabIndex = 47;
            this.label4.Text = "Account Type";
            // 
            // CurrencyComboBox
            // 
            this.CurrencyComboBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyComboBox.FormattingEnabled = true;
            this.CurrencyComboBox.Items.AddRange(new object[] {
            "EGP",
            "USD",
            "EUR",
            "JPY",
            "GBP",
            "CHF",
            "CAD",
            "AUD"});
            this.CurrencyComboBox.Location = new System.Drawing.Point(251, 218);
            this.CurrencyComboBox.Name = "CurrencyComboBox";
            this.CurrencyComboBox.Size = new System.Drawing.Size(200, 30);
            this.CurrencyComboBox.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 221);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 45;
            this.label3.Text = "Currencie";
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AccountTypeComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CurrencyComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AmountTxtBox);
            this.Controls.Add(this.AmountLbl);
            this.Controls.Add(this.AccountIDTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Depositlbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.depositBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Label Depositlbl;
        private System.Windows.Forms.TextBox AccountIDTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AmountTxtBox;
        private System.Windows.Forms.Label AmountLbl;
        private System.Windows.Forms.ComboBox AccountTypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CurrencyComboBox;
        private System.Windows.Forms.Label label3;
    }
}