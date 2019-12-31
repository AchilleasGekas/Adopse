namespace WP8_Test
{
    partial class DonationForm
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
            this.donationBtn = new System.Windows.Forms.Button();
            this.descriptionLB = new System.Windows.Forms.Label();
            this.currencyCB = new System.Windows.Forms.ComboBox();
            this.currencyLB = new System.Windows.Forms.Label();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // donationBtn
            // 
            this.donationBtn.Location = new System.Drawing.Point(16, 230);
            this.donationBtn.Name = "donationBtn";
            this.donationBtn.Size = new System.Drawing.Size(123, 42);
            this.donationBtn.TabIndex = 0;
            this.donationBtn.Text = "Go to Paypal";
            this.donationBtn.UseVisualStyleBackColor = true;
            this.donationBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // descriptionLB
            // 
            this.descriptionLB.AutoSize = true;
            this.descriptionLB.Location = new System.Drawing.Point(13, 93);
            this.descriptionLB.Name = "descriptionLB";
            this.descriptionLB.Size = new System.Drawing.Size(66, 13);
            this.descriptionLB.TabIndex = 1;
            this.descriptionLB.Text = "Description: ";
            this.descriptionLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // currencyCB
            // 
            this.currencyCB.FormattingEnabled = true;
            this.currencyCB.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "AUD"});
            this.currencyCB.Location = new System.Drawing.Point(84, 169);
            this.currencyCB.Name = "currencyCB";
            this.currencyCB.Size = new System.Drawing.Size(121, 21);
            this.currencyCB.TabIndex = 2;
            this.currencyCB.Text = "EUR";
            // 
            // currencyLB
            // 
            this.currencyLB.AutoSize = true;
            this.currencyLB.Location = new System.Drawing.Point(13, 169);
            this.currencyLB.Name = "currencyLB";
            this.currencyLB.Size = new System.Drawing.Size(52, 13);
            this.currencyLB.TabIndex = 3;
            this.currencyLB.Text = "Currency:";
            // 
            // descriptionTB
            // 
            this.descriptionTB.Location = new System.Drawing.Point(84, 93);
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(121, 20);
            this.descriptionTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Write something Good :D";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose your Currency";
            // 
            // DonationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionTB);
            this.Controls.Add(this.currencyLB);
            this.Controls.Add(this.currencyCB);
            this.Controls.Add(this.descriptionLB);
            this.Controls.Add(this.donationBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DonationForm";
            this.Text = "DonationForm";
            this.Load += new System.EventHandler(this.DonationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button donationBtn;
        private System.Windows.Forms.Label descriptionLB;
        private System.Windows.Forms.ComboBox currencyCB;
        private System.Windows.Forms.Label currencyLB;
        private System.Windows.Forms.TextBox descriptionTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}