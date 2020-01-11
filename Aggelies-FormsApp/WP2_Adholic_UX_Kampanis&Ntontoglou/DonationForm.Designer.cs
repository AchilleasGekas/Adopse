namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonationForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.currencyLB = new System.Windows.Forms.Label();
            this.currencyCB = new System.Windows.Forms.ComboBox();
            this.descriptionLB = new System.Windows.Forms.Label();
            this.donationBtn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(110, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Choose your Currency";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(109, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Write something Good :D";
            // 
            // descriptionTB
            // 
            this.descriptionTB.Location = new System.Drawing.Point(215, 103);
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(121, 20);
            this.descriptionTB.TabIndex = 11;
            // 
            // currencyLB
            // 
            this.currencyLB.AutoSize = true;
            this.currencyLB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.currencyLB.Location = new System.Drawing.Point(110, 178);
            this.currencyLB.Name = "currencyLB";
            this.currencyLB.Size = new System.Drawing.Size(81, 20);
            this.currencyLB.TabIndex = 10;
            this.currencyLB.Text = "Currency:";
            // 
            // currencyCB
            // 
            this.currencyCB.FormattingEnabled = true;
            this.currencyCB.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "AUD"});
            this.currencyCB.Location = new System.Drawing.Point(215, 178);
            this.currencyCB.Name = "currencyCB";
            this.currencyCB.Size = new System.Drawing.Size(121, 21);
            this.currencyCB.TabIndex = 9;
            this.currencyCB.Text = "EUR";
            // 
            // descriptionLB
            // 
            this.descriptionLB.AutoSize = true;
            this.descriptionLB.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.descriptionLB.Location = new System.Drawing.Point(110, 101);
            this.descriptionLB.Name = "descriptionLB";
            this.descriptionLB.Size = new System.Drawing.Size(99, 20);
            this.descriptionLB.TabIndex = 8;
            this.descriptionLB.Text = "Description: ";
            // 
            // donationBtn
            // 
            this.donationBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.donationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donationBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donationBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.donationBtn.Location = new System.Drawing.Point(145, 239);
            this.donationBtn.Name = "donationBtn";
            this.donationBtn.Size = new System.Drawing.Size(159, 33);
            this.donationBtn.TabIndex = 7;
            this.donationBtn.Text = "Go to Paypal";
            this.donationBtn.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.close);
            this.panel5.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(427, 32);
            this.panel5.TabIndex = 89;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove);
            this.panel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // close
            // 
            this.close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.close.Cursor = System.Windows.Forms.Cursors.Default;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(400, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(24, 24);
            this.close.TabIndex = 13;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // DonationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 332);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionTB);
            this.Controls.Add(this.currencyLB);
            this.Controls.Add(this.currencyCB);
            this.Controls.Add(this.descriptionLB);
            this.Controls.Add(this.donationBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DonationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DonationForm";
            this.Load += new System.EventHandler(this.DonationForm_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTB;
        private System.Windows.Forms.Label currencyLB;
        private System.Windows.Forms.ComboBox currencyCB;
        private System.Windows.Forms.Label descriptionLB;
        private System.Windows.Forms.Button donationBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}