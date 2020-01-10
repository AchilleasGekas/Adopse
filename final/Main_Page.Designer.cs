namespace WindowsFormsApp1
{
    partial class Main_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Page));
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel_login_register = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Log_in_label_main = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.Maximize = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.navigation_panel = new System.Windows.Forms.Panel();
            this.home_button_main = new System.Windows.Forms.Button();
            this.panel_back = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel_home = new System.Windows.Forms.Panel();
            this.back_button_main = new System.Windows.Forms.Button();
            this.panel_user = new System.Windows.Forms.Panel();
            this.usern_main_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.left_panel_options = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.main_panel.SuspendLayout();
            this.panel_login_register.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).BeginInit();
            this.navigation_panel.SuspendLayout();
            this.panel_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.left_panel_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.main_panel.Controls.Add(this.LogOutButton);
            this.main_panel.Controls.Add(this.panel_login_register);
            this.main_panel.Controls.Add(this.panel5);
            this.main_panel.Controls.Add(this.flowLayoutPanel1);
            this.main_panel.Controls.Add(this.navigation_panel);
            this.main_panel.Controls.Add(this.panel_user);
            this.main_panel.Controls.Add(this.left_panel_options);
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Margin = new System.Windows.Forms.Padding(2);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1209, 498);
            this.main_panel.TabIndex = 0;
            this.main_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_login_register
            // 
            this.panel_login_register.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_login_register.Controls.Add(this.comboBox1);
            this.panel_login_register.Controls.Add(this.Log_in_label_main);
            this.panel_login_register.Location = new System.Drawing.Point(905, 37);
            this.panel_login_register.Name = "panel_login_register";
            this.panel_login_register.Size = new System.Drawing.Size(301, 78);
            this.panel_login_register.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(224)))));
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Greek",
            "English"});
            this.comboBox1.Location = new System.Drawing.Point(171, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "--";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Log_in_label_main
            // 
            this.Log_in_label_main.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Log_in_label_main.AutoSize = true;
            this.Log_in_label_main.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Log_in_label_main.Location = new System.Drawing.Point(106, 9);
            this.Log_in_label_main.Name = "Log_in_label_main";
            this.Log_in_label_main.Size = new System.Drawing.Size(192, 22);
            this.Log_in_label_main.TabIndex = 13;
            this.Log_in_label_main.Text = "Σύνδεση / Εγγραφή";
            this.Log_in_label_main.Click += new System.EventHandler(this.Log_in_label_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(224)))));
            this.panel5.Controls.Add(this.Minimize);
            this.panel5.Controls.Add(this.close);
            this.panel5.Controls.Add(this.Maximize);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1209, 32);
            this.panel5.TabIndex = 0;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove);
            this.panel5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseUp);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(1122, 4);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(24, 24);
            this.Minimize.TabIndex = 15;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // close
            // 
            this.close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(1182, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(24, 24);
            this.close.TabIndex = 13;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Maximize
            // 
            this.Maximize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Maximize.Image = ((System.Drawing.Image)(resources.GetObject("Maximize.Image")));
            this.Maximize.Location = new System.Drawing.Point(1152, 4);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(24, 24);
            this.Maximize.TabIndex = 14;
            this.Maximize.TabStop = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(234, 180);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(972, 318);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // navigation_panel
            // 
            this.navigation_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.navigation_panel.Controls.Add(this.home_button_main);
            this.navigation_panel.Controls.Add(this.panel_back);
            this.navigation_panel.Controls.Add(this.panel4);
            this.navigation_panel.Controls.Add(this.panel_home);
            this.navigation_panel.Controls.Add(this.back_button_main);
            this.navigation_panel.Location = new System.Drawing.Point(0, 0);
            this.navigation_panel.Margin = new System.Windows.Forms.Padding(2);
            this.navigation_panel.Name = "navigation_panel";
            this.navigation_panel.Size = new System.Drawing.Size(229, 151);
            this.navigation_panel.TabIndex = 0;
            // 
            // home_button_main
            // 
            this.home_button_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.home_button_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.home_button_main.Cursor = System.Windows.Forms.Cursors.Default;
            this.home_button_main.FlatAppearance.BorderSize = 0;
            this.home_button_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_button_main.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.home_button_main.Image = ((System.Drawing.Image)(resources.GetObject("home_button_main.Image")));
            this.home_button_main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home_button_main.Location = new System.Drawing.Point(11, 31);
            this.home_button_main.Margin = new System.Windows.Forms.Padding(2);
            this.home_button_main.Name = "home_button_main";
            this.home_button_main.Size = new System.Drawing.Size(218, 55);
            this.home_button_main.TabIndex = 2;
            this.home_button_main.Text = "      Αρχική";
            this.home_button_main.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.home_button_main.UseVisualStyleBackColor = false;
            this.home_button_main.Click += new System.EventHandler(this.home_button_Click);
            // 
            // panel_back
            // 
            this.panel_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.panel_back.Location = new System.Drawing.Point(0, 97);
            this.panel_back.Name = "panel_back";
            this.panel_back.Size = new System.Drawing.Size(10, 51);
            this.panel_back.TabIndex = 4;
            this.panel_back.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(234, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(464, 10);
            this.panel4.TabIndex = 13;
            // 
            // panel_home
            // 
            this.panel_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.panel_home.Location = new System.Drawing.Point(0, 33);
            this.panel_home.Name = "panel_home";
            this.panel_home.Size = new System.Drawing.Size(10, 53);
            this.panel_home.TabIndex = 5;
            // 
            // back_button_main
            // 
            this.back_button_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back_button_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.back_button_main.Cursor = System.Windows.Forms.Cursors.Default;
            this.back_button_main.FlatAppearance.BorderSize = 0;
            this.back_button_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button_main.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.back_button_main.Image = ((System.Drawing.Image)(resources.GetObject("back_button_main.Image")));
            this.back_button_main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back_button_main.Location = new System.Drawing.Point(9, 97);
            this.back_button_main.Margin = new System.Windows.Forms.Padding(0);
            this.back_button_main.Name = "back_button_main";
            this.back_button_main.Size = new System.Drawing.Size(218, 51);
            this.back_button_main.TabIndex = 3;
            this.back_button_main.Text = "      Πίσω";
            this.back_button_main.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.back_button_main.UseVisualStyleBackColor = false;
            this.back_button_main.Click += new System.EventHandler(this.back_button_Click);
            // 
            // panel_user
            // 
            this.panel_user.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(199)))), ((int)(((byte)(224)))));
            this.panel_user.Controls.Add(this.usern_main_label);
            this.panel_user.Controls.Add(this.pictureBox1);
            this.panel_user.Location = new System.Drawing.Point(281, 0);
            this.panel_user.Margin = new System.Windows.Forms.Padding(2);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(147, 175);
            this.panel_user.TabIndex = 1;
            this.panel_user.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // usern_main_label
            // 
            this.usern_main_label.AutoSize = true;
            this.usern_main_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.usern_main_label.Location = new System.Drawing.Point(20, 122);
            this.usern_main_label.Name = "usern_main_label";
            this.usern_main_label.Size = new System.Drawing.Size(76, 21);
            this.usern_main_label.TabIndex = 13;
            this.usern_main_label.Text = "Χρήστης";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 78);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // left_panel_options
            // 
            this.left_panel_options.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.left_panel_options.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.left_panel_options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(229)))), ((int)(((byte)(250)))));
            this.left_panel_options.Controls.Add(this.flowLayoutPanel2);
            this.left_panel_options.Location = new System.Drawing.Point(0, 145);
            this.left_panel_options.Margin = new System.Windows.Forms.Padding(2);
            this.left_panel_options.Name = "left_panel_options";
            this.left_panel_options.Size = new System.Drawing.Size(229, 353);
            this.left_panel_options.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, -2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(223, 352);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(791, 37);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(75, 23);
            this.LogOutButton.TabIndex = 14;
            this.LogOutButton.Text = "LogOut";
            this.LogOutButton.UseVisualStyleBackColor = true;
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 498);
            this.Controls.Add(this.main_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Main_Page_Load);
            this.main_panel.ResumeLayout(false);
            this.panel_login_register.ResumeLayout(false);
            this.panel_login_register.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).EndInit();
            this.navigation_panel.ResumeLayout(false);
            this.panel_user.ResumeLayout(false);
            this.panel_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.left_panel_options.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel left_panel_options;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel navigation_panel;
        private System.Windows.Forms.Panel panel_back;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.PictureBox Maximize;
        private System.Windows.Forms.Panel panel_login_register;
        public System.Windows.Forms.Label usern_main_label;
        public System.Windows.Forms.Button home_button_main;
        public System.Windows.Forms.Button back_button_main;
        public System.Windows.Forms.Label Log_in_label_main;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button LogOutButton;
    }
}