namespace DB_GUI
{
    partial class CityAvg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cityText = new System.Windows.Forms.TextBox();
            this.computeBtn = new System.Windows.Forms.Button();
            this.avgText = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(655, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average";
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(212, 83);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(100, 26);
            this.cityText.TabIndex = 2;
            // 
            // computeBtn
            // 
            this.computeBtn.Location = new System.Drawing.Point(458, 221);
            this.computeBtn.Name = "computeBtn";
            this.computeBtn.Size = new System.Drawing.Size(144, 59);
            this.computeBtn.TabIndex = 3;
            this.computeBtn.Text = "Compute Average";
            this.computeBtn.UseVisualStyleBackColor = true;
            this.computeBtn.Click += new System.EventHandler(this.computeBtn_Click);
            // 
            // avgText
            // 
            this.avgText.Enabled = false;
            this.avgText.Location = new System.Drawing.Point(740, 83);
            this.avgText.Name = "avgText";
            this.avgText.Size = new System.Drawing.Size(100, 26);
            this.avgText.TabIndex = 4;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(458, 298);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(144, 57);
            this.backBtn.TabIndex = 34;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // CityAvg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 491);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.avgText);
            this.Controls.Add(this.computeBtn);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CityAvg";
            this.Text = "Find Average Balance By City";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Button computeBtn;
        private System.Windows.Forms.TextBox avgText;
        private System.Windows.Forms.Button backBtn;
    }
}