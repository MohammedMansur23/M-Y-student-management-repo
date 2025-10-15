namespace Student_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LoginPagePanel = new Panel();
            LoginPanel = new Panel();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            passwordpanel = new Panel();
            pictureBox3 = new PictureBox();
            password = new TextBox();
            usernamepanel = new Panel();
            pictureBox2 = new PictureBox();
            UserName = new TextBox();
            forgotpass = new LinkLabel();
            Loginbtn = new Button();
            rememberme = new CheckBox();
            PasswordLabel = new Label();
            UsernameLabel = new Label();
            pictureBox1 = new PictureBox();
            LoginPagePanel.SuspendLayout();
            LoginPanel.SuspendLayout();
            passwordpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            usernamepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginPagePanel
            // 
            LoginPagePanel.BackColor = SystemColors.Info;
            LoginPagePanel.BackgroundImageLayout = ImageLayout.Stretch;
            LoginPagePanel.Controls.Add(LoginPanel);
            LoginPagePanel.Dock = DockStyle.Fill;
            LoginPagePanel.Location = new Point(0, 0);
            LoginPagePanel.Name = "LoginPagePanel";
            LoginPagePanel.Size = new Size(1389, 1035);
            LoginPagePanel.TabIndex = 0;
            // 
            // LoginPanel
            // 
            LoginPanel.Anchor = AnchorStyles.None;
            LoginPanel.BackColor = Color.DarkSlateGray;
            LoginPanel.Controls.Add(linkLabel1);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Controls.Add(passwordpanel);
            LoginPanel.Controls.Add(usernamepanel);
            LoginPanel.Controls.Add(forgotpass);
            LoginPanel.Controls.Add(Loginbtn);
            LoginPanel.Controls.Add(rememberme);
            LoginPanel.Controls.Add(PasswordLabel);
            LoginPanel.Controls.Add(UsernameLabel);
            LoginPanel.Controls.Add(pictureBox1);
            LoginPanel.Font = new Font("Arial", 12F);
            LoginPanel.ForeColor = SystemColors.ScrollBar;
            LoginPanel.Location = new Point(323, 91);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(759, 853);
            LoginPanel.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = SystemColors.WindowFrame;
            linkLabel1.AutoSize = true;
            linkLabel1.ForeColor = SystemColors.ScrollBar;
            linkLabel1.LinkColor = SystemColors.ScrollBar;
            linkLabel1.Location = new Point(381, 816);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(129, 23);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register Now";
            linkLabel1.VisitedLinkColor = SystemColors.ScrollBar;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.ForeColor = SystemColors.ScrollBar;
            label1.Location = new Point(185, 816);
            label1.Name = "label1";
            label1.Size = new Size(201, 23);
            label1.TabIndex = 12;
            label1.Text = "Not A Student/Admin?";
            label1.Click += label1_Click;
            // 
            // passwordpanel
            // 
            passwordpanel.BackColor = SystemColors.Info;
            passwordpanel.Controls.Add(pictureBox3);
            passwordpanel.Controls.Add(password);
            passwordpanel.Cursor = Cursors.IBeam;
            passwordpanel.Location = new Point(82, 462);
            passwordpanel.Name = "passwordpanel";
            passwordpanel.Size = new Size(587, 92);
            passwordpanel.TabIndex = 10;
            passwordpanel.Click += passwordpanel_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.Info;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(16, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 37);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.None;
            password.BackColor = SystemColors.Info;
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Arial", 20F);
            password.ForeColor = SystemColors.ButtonShadow;
            password.Location = new Point(74, 27);
            password.MaxLength = 18;
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(499, 37);
            password.TabIndex = 4;
            // 
            // usernamepanel
            // 
            usernamepanel.BackColor = SystemColors.Info;
            usernamepanel.Controls.Add(pictureBox2);
            usernamepanel.Controls.Add(UserName);
            usernamepanel.Cursor = Cursors.IBeam;
            usernamepanel.Location = new Point(82, 325);
            usernamepanel.Name = "usernamepanel";
            usernamepanel.Size = new Size(587, 92);
            usernamepanel.TabIndex = 9;
            usernamepanel.Click += usernamepanel_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.Info;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Location = new Point(17, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 37);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // UserName
            // 
            UserName.Anchor = AnchorStyles.None;
            UserName.BackColor = SystemColors.Info;
            UserName.BorderStyle = BorderStyle.None;
            UserName.Font = new Font("Arial", 20F);
            UserName.ForeColor = SystemColors.ButtonShadow;
            UserName.Location = new Point(74, 27);
            UserName.MaxLength = 18;
            UserName.Name = "UserName";
            UserName.Size = new Size(499, 37);
            UserName.TabIndex = 3;
            UserName.Leave += UserName_Leave;
            // 
            // forgotpass
            // 
            forgotpass.ActiveLinkColor = SystemColors.WindowFrame;
            forgotpass.AutoSize = true;
            forgotpass.ForeColor = SystemColors.ScrollBar;
            forgotpass.LinkColor = SystemColors.ScrollBar;
            forgotpass.Location = new Point(496, 573);
            forgotpass.Name = "forgotpass";
            forgotpass.Size = new Size(173, 23);
            forgotpass.TabIndex = 8;
            forgotpass.TabStop = true;
            forgotpass.Text = "Forgot Password?";
            forgotpass.VisitedLinkColor = SystemColors.ScrollBar;
            forgotpass.LinkClicked += forgotpass_LinkClicked;
            // 
            // Loginbtn
            // 
            Loginbtn.BackColor = SystemColors.Info;
            Loginbtn.FlatStyle = FlatStyle.Flat;
            Loginbtn.Font = new Font("Arial", 18F, FontStyle.Bold);
            Loginbtn.ForeColor = Color.DarkSlateGray;
            Loginbtn.Location = new Point(82, 660);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(587, 92);
            Loginbtn.TabIndex = 5;
            Loginbtn.Text = "LOGIN";
            Loginbtn.UseVisualStyleBackColor = false;
            Loginbtn.Click += Loginbtn_Click;
            Loginbtn.MouseEnter += Loginbtn_MouseEnter;
            Loginbtn.MouseLeave += Loginbtn_MouseLeave;
            // 
            // rememberme
            // 
            rememberme.AutoSize = true;
            rememberme.Font = new Font("Arial", 12F, FontStyle.Bold);
            rememberme.ForeColor = SystemColors.ScrollBar;
            rememberme.Location = new Point(82, 573);
            rememberme.Name = "rememberme";
            rememberme.Size = new Size(164, 28);
            rememberme.TabIndex = 7;
            rememberme.Text = "Remember Me";
            rememberme.UseVisualStyleBackColor = true;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Arial", 12F);
            PasswordLabel.ForeColor = SystemColors.ScrollBar;
            PasswordLabel.Location = new Point(82, 436);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(98, 23);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Arial", 12F);
            UsernameLabel.ForeColor = SystemColors.ScrollBar;
            UsernameLabel.Location = new Point(82, 299);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(99, 23);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(256, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 265);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1389, 1035);
            Controls.Add(LoginPagePanel);
            MaximizeBox = false;
            Name = "Login";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += Login_Load;
            LoginPagePanel.ResumeLayout(false);
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            passwordpanel.ResumeLayout(false);
            passwordpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            usernamepanel.ResumeLayout(false);
            usernamepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginPagePanel;
        private Panel LoginPanel;
        private PictureBox pictureBox1;
        private Label PasswordLabel;
        private Label UsernameLabel;
        private TextBox UserName;
        private TextBox password;
        private Button Loginbtn;
        private CheckBox rememberme;
        private LinkLabel forgotpass;
        private Panel passwordpanel;
        private Panel usernamepanel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}