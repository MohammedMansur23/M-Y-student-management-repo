namespace Student_Management_System
{
    partial class Register1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register1));
            usernameandpasswordpanel = new CuoreUI.Controls.cuiPanel();
            PictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            btnRegister = new CuoreUI.Controls.cuiButton();
            passwordtxt = new CuoreUI.Controls.cuiTextBox();
            Usernametxt = new CuoreUI.Controls.cuiTextBox();
            generalandinfopanel = new CuoreUI.Controls.cuiPanel();
            dtpDOB = new CuoreUI.Controls.cuiCalendarDatePicker();
            department = new CuoreUI.Controls.cuiComboBox();
            faculty = new CuoreUI.Controls.cuiComboBox();
            cmbGender = new CuoreUI.Controls.cuiComboBox();
            txtAddress = new CuoreUI.Controls.cuiTextBox();
            txtPhone = new CuoreUI.Controls.cuiTextBox();
            txtEmail = new CuoreUI.Controls.cuiTextBox();
            txtLastName = new CuoreUI.Controls.cuiTextBox();
            txtFirstName = new CuoreUI.Controls.cuiTextBox();
            txtStudentNumber = new CuoreUI.Controls.cuiTextBox();
            usernameandpasswordpanel.SuspendLayout();
            generalandinfopanel.SuspendLayout();
            SuspendLayout();
            // 
            // usernameandpasswordpanel
            // 
            usernameandpasswordpanel.BackColor = Color.FromArgb(72, 53, 212);
            usernameandpasswordpanel.Controls.Add(PictureBox1);
            usernameandpasswordpanel.Controls.Add(btnRegister);
            usernameandpasswordpanel.Controls.Add(passwordtxt);
            usernameandpasswordpanel.Controls.Add(Usernametxt);
            usernameandpasswordpanel.Dock = DockStyle.Right;
            usernameandpasswordpanel.Location = new Point(428, 0);
            usernameandpasswordpanel.Name = "usernameandpasswordpanel";
            usernameandpasswordpanel.OutlineThickness = 1F;
            usernameandpasswordpanel.PanelColor = Color.FromArgb(72, 53, 212);
            usernameandpasswordpanel.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            usernameandpasswordpanel.Rounding = new Padding(8);
            usernameandpasswordpanel.Size = new Size(961, 1035);
            usernameandpasswordpanel.TabIndex = 0;
            // 
            // PictureBox1
            // 
            PictureBox1.BackColor = Color.FromArgb(72, 53, 212);
            PictureBox1.BackgroundImage = (Image)resources.GetObject("PictureBox1.BackgroundImage");
            PictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            PictureBox1.Content = null;
            PictureBox1.ImageTint = Color.White;
            PictureBox1.Location = new Point(330, 178);
            PictureBox1.Margin = new Padding(4, 4, 4, 4);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.OutlineThickness = 1F;
            PictureBox1.PanelOutlineColor = Color.Empty;
            PictureBox1.Rotation = 0;
            PictureBox1.Rounding = new Padding(8);
            PictureBox1.Size = new Size(300, 300);
            PictureBox1.TabIndex = 3;
            PictureBox1.Load += PictureBox1_Load;
            PictureBox1.Click += PictureBox1_Click;
            // 
            // btnRegister
            // 
            btnRegister.CheckButton = false;
            btnRegister.Checked = false;
            btnRegister.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnRegister.CheckedForeColor = Color.White;
            btnRegister.CheckedImageTint = Color.White;
            btnRegister.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnRegister.Content = "Register";
            btnRegister.DialogResult = DialogResult.None;
            btnRegister.Font = new Font("Century Gothic", 20.0347824F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.Black;
            btnRegister.HoverBackground = Color.White;
            btnRegister.HoverForeColor = Color.Black;
            btnRegister.HoverImageTint = Color.White;
            btnRegister.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnRegister.Image = null;
            btnRegister.ImageAutoCenter = true;
            btnRegister.ImageExpand = new Point(0, 0);
            btnRegister.ImageOffset = new Point(0, 0);
            btnRegister.Location = new Point(358, 802);
            btnRegister.Name = "btnRegister";
            btnRegister.NormalBackground = Color.White;
            btnRegister.NormalForeColor = Color.Black;
            btnRegister.NormalImageTint = Color.White;
            btnRegister.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnRegister.OutlineThickness = 1F;
            btnRegister.PressedBackground = Color.WhiteSmoke;
            btnRegister.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnRegister.PressedImageTint = Color.White;
            btnRegister.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnRegister.Rounding = new Padding(25);
            btnRegister.Size = new Size(244, 54);
            btnRegister.TabIndex = 2;
            btnRegister.TextAlignment = StringAlignment.Center;
            btnRegister.TextOffset = new Point(0, 0);
            btnRegister.Click += btnRegister_Click;
            // 
            // passwordtxt
            // 
            passwordtxt.BackColor = Color.Transparent;
            passwordtxt.BackgroundColor = Color.FromArgb(72, 53, 212);
            passwordtxt.BackgroundImageLayout = ImageLayout.Zoom;
            passwordtxt.Content = "";
            passwordtxt.FocusBackgroundColor = Color.FromArgb(72, 53, 212);
            passwordtxt.FocusImageTint = Color.Transparent;
            passwordtxt.FocusOutlineColor = Color.White;
            passwordtxt.Font = new Font("Century Gothic", 16.2782612F);
            passwordtxt.ForeColor = Color.White;
            passwordtxt.Image = null;
            passwordtxt.ImageExpand = new Point(0, 0);
            passwordtxt.ImageOffset = new Point(0, 0);
            passwordtxt.Location = new Point(259, 676);
            passwordtxt.Margin = new Padding(4);
            passwordtxt.Multiline = false;
            passwordtxt.Name = "passwordtxt";
            passwordtxt.NormalImageTint = Color.White;
            passwordtxt.OutlineColor = Color.White;
            passwordtxt.Padding = new Padding(32, 11, 32, 0);
            passwordtxt.PasswordChar = false;
            passwordtxt.PlaceholderColor = SystemColors.Control;
            passwordtxt.PlaceholderText = "Password";
            passwordtxt.Rounding = new Padding(2);
            passwordtxt.Size = new Size(442, 54);
            passwordtxt.TabIndex = 0;
            passwordtxt.TextOffset = new Size(0, 0);
            passwordtxt.UnderlinedStyle = true;
            // 
            // Usernametxt
            // 
            Usernametxt.BackColor = Color.Transparent;
            Usernametxt.BackgroundColor = Color.FromArgb(72, 53, 212);
            Usernametxt.BackgroundImageLayout = ImageLayout.Zoom;
            Usernametxt.Content = "";
            Usernametxt.FocusBackgroundColor = Color.FromArgb(72, 53, 212);
            Usernametxt.FocusImageTint = Color.Transparent;
            Usernametxt.FocusOutlineColor = Color.White;
            Usernametxt.Font = new Font("Century Gothic", 16.2782612F);
            Usernametxt.ForeColor = Color.White;
            Usernametxt.Image = null;
            Usernametxt.ImageExpand = new Point(0, 0);
            Usernametxt.ImageOffset = new Point(0, 0);
            Usernametxt.Location = new Point(259, 550);
            Usernametxt.Margin = new Padding(4);
            Usernametxt.Multiline = false;
            Usernametxt.Name = "Usernametxt";
            Usernametxt.NormalImageTint = Color.White;
            Usernametxt.OutlineColor = Color.White;
            Usernametxt.Padding = new Padding(32, 11, 32, 0);
            Usernametxt.PasswordChar = false;
            Usernametxt.PlaceholderColor = SystemColors.Control;
            Usernametxt.PlaceholderText = "Username";
            Usernametxt.Rounding = new Padding(2);
            Usernametxt.Size = new Size(442, 54);
            Usernametxt.TabIndex = 0;
            Usernametxt.TextOffset = new Size(0, 0);
            Usernametxt.UnderlinedStyle = true;
            Usernametxt.Leave += Usernametxt_Leave;
            // 
            // generalandinfopanel
            // 
            generalandinfopanel.BackColor = Color.White;
            generalandinfopanel.Controls.Add(dtpDOB);
            generalandinfopanel.Controls.Add(department);
            generalandinfopanel.Controls.Add(faculty);
            generalandinfopanel.Controls.Add(cmbGender);
            generalandinfopanel.Controls.Add(txtAddress);
            generalandinfopanel.Controls.Add(txtPhone);
            generalandinfopanel.Controls.Add(txtEmail);
            generalandinfopanel.Controls.Add(txtLastName);
            generalandinfopanel.Controls.Add(txtFirstName);
            generalandinfopanel.Controls.Add(txtStudentNumber);
            generalandinfopanel.Dock = DockStyle.Fill;
            generalandinfopanel.Location = new Point(0, 0);
            generalandinfopanel.Name = "generalandinfopanel";
            generalandinfopanel.OutlineThickness = 1F;
            generalandinfopanel.PanelColor = Color.White;
            generalandinfopanel.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            generalandinfopanel.Rounding = new Padding(0);
            generalandinfopanel.Size = new Size(1389, 1035);
            generalandinfopanel.TabIndex = 0;
            // 
            // dtpDOB
            // 
            dtpDOB.Content = new DateTime(2025, 10, 15, 0, 0, 0, 0);
            dtpDOB.EnableThemeChangeButton = true;
            dtpDOB.Font = new Font("Century Gothic", 10F);
            dtpDOB.ForeColor = Color.Gray;
            dtpDOB.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            dtpDOB.HoverOutline = Color.FromArgb(180, 128, 128, 128);
            dtpDOB.Icon = (Image)resources.GetObject("dtpDOB.Icon");
            dtpDOB.IconTint = Color.Gray;
            dtpDOB.Location = new Point(149, 767);
            dtpDOB.Margin = new Padding(5, 4, 5, 4);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.NormalBackground = Color.FromArgb(32, 128, 128, 128);
            dtpDOB.NormalOutline = Color.FromArgb(150, 128, 128, 128);
            dtpDOB.OutlineThickness = 1.5F;
            dtpDOB.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Top;
            dtpDOB.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            dtpDOB.PressedOutline = Color.FromArgb(210, 128, 128, 128);
            dtpDOB.Rounding = 8;
            dtpDOB.ShowIcon = true;
            dtpDOB.Size = new Size(229, 60);
            dtpDOB.TabIndex = 2;
            dtpDOB.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            // 
            // department
            // 
            department.BackgroundColor = Color.FromArgb(255, 255, 255);
            department.ButtonCursor = Cursors.Arrow;
            department.ButtonHoverBackground = Color.FromArgb(192, 255, 106, 0);
            department.ButtonHoverOutline = Color.Empty;
            department.ButtonNormalBackground = Color.FromArgb(255, 106, 0);
            department.ButtonNormalOutline = Color.Empty;
            department.ButtonPressedBackground = Color.FromArgb(255, 106, 0);
            department.ButtonPressedOutline = Color.Empty;
            department.DropDownBackgroundColor = Color.White;
            department.DropDownOutlineColor = Color.FromArgb(30, 255, 255, 255);
            department.ExpandArrowColor = Color.Gray;
            department.Font = new Font("Century Gothic", 10F);
            department.ForeColor = Color.Gray;
            department.Location = new Point(149, 691);
            department.Margin = new Padding(5);
            department.Name = "department";
            department.NoSelectionDropdownText = "Empty";
            department.NoSelectionText = "Department";
            department.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            department.OutlineThickness = 1F;
            department.Rounding = 8;
            department.Size = new Size(338, 47);
            department.TabIndex = 1;
            // 
            // faculty
            // 
            faculty.BackgroundColor = Color.FromArgb(255, 255, 255);
            faculty.ButtonCursor = Cursors.Arrow;
            faculty.ButtonHoverBackground = Color.FromArgb(192, 255, 106, 0);
            faculty.ButtonHoverOutline = Color.Empty;
            faculty.ButtonNormalBackground = Color.FromArgb(255, 106, 0);
            faculty.ButtonNormalOutline = Color.Empty;
            faculty.ButtonPressedBackground = Color.FromArgb(255, 106, 0);
            faculty.ButtonPressedOutline = Color.Empty;
            faculty.DropDownBackgroundColor = Color.White;
            faculty.DropDownOutlineColor = Color.FromArgb(30, 255, 255, 255);
            faculty.ExpandArrowColor = Color.Gray;
            faculty.Font = new Font("Century Gothic", 10F);
            faculty.ForeColor = Color.Gray;
            faculty.Location = new Point(149, 635);
            faculty.Margin = new Padding(5);
            faculty.Name = "faculty";
            faculty.NoSelectionDropdownText = "Empty";
            faculty.NoSelectionText = "Faculty";
            faculty.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            faculty.OutlineThickness = 1F;
            faculty.Rounding = 8;
            faculty.Size = new Size(338, 47);
            faculty.TabIndex = 1;
            faculty.SelectedIndexChanged += faculty_SelectedIndexChanged;
            // 
            // cmbGender
            // 
            cmbGender.BackgroundColor = Color.FromArgb(255, 255, 255);
            cmbGender.ButtonCursor = Cursors.Arrow;
            cmbGender.ButtonHoverBackground = Color.FromArgb(192, 255, 106, 0);
            cmbGender.ButtonHoverOutline = Color.Empty;
            cmbGender.ButtonNormalBackground = Color.FromArgb(255, 106, 0);
            cmbGender.ButtonNormalOutline = Color.Empty;
            cmbGender.ButtonPressedBackground = Color.FromArgb(255, 106, 0);
            cmbGender.ButtonPressedOutline = Color.Empty;
            cmbGender.DropDownBackgroundColor = Color.White;
            cmbGender.DropDownOutlineColor = Color.FromArgb(30, 255, 255, 255);
            cmbGender.ExpandArrowColor = Color.Gray;
            cmbGender.Font = new Font("Century Gothic", 10F);
            cmbGender.ForeColor = Color.Gray;
            cmbGender.Items = new string[]
    {
    "Male",
    "Female"
    };
            cmbGender.Location = new Point(149, 580);
            cmbGender.Margin = new Padding(5);
            cmbGender.Name = "cmbGender";
            cmbGender.NoSelectionDropdownText = "Empty";
            cmbGender.NoSelectionText = "Gender";
            cmbGender.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cmbGender.OutlineThickness = 1F;
            cmbGender.Rounding = 8;
            cmbGender.Size = new Size(338, 47);
            cmbGender.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.BackgroundColor = Color.White;
            txtAddress.Content = "";
            txtAddress.FocusBackgroundColor = Color.White;
            txtAddress.FocusImageTint = Color.White;
            txtAddress.FocusOutlineColor = Color.Black;
            txtAddress.Font = new Font("Century Gothic", 16.2782612F);
            txtAddress.ForeColor = Color.Gray;
            txtAddress.Image = null;
            txtAddress.ImageExpand = new Point(0, 0);
            txtAddress.ImageOffset = new Point(0, 0);
            txtAddress.Location = new Point(148, 517);
            txtAddress.Margin = new Padding(4);
            txtAddress.Multiline = false;
            txtAddress.Name = "txtAddress";
            txtAddress.NormalImageTint = Color.White;
            txtAddress.OutlineColor = Color.Black;
            txtAddress.Padding = new Padding(32, 11, 32, 0);
            txtAddress.PasswordChar = false;
            txtAddress.PlaceholderColor = SystemColors.ActiveBorder;
            txtAddress.PlaceholderText = "Address";
            txtAddress.Rounding = new Padding(2);
            txtAddress.Size = new Size(442, 54);
            txtAddress.TabIndex = 0;
            txtAddress.TextOffset = new Size(0, 0);
            txtAddress.UnderlinedStyle = true;
            // 
            // txtPhone
            // 
            txtPhone.BackgroundColor = Color.White;
            txtPhone.Content = "";
            txtPhone.FocusBackgroundColor = Color.White;
            txtPhone.FocusImageTint = Color.White;
            txtPhone.FocusOutlineColor = Color.Black;
            txtPhone.Font = new Font("Century Gothic", 16.2782612F);
            txtPhone.ForeColor = Color.Gray;
            txtPhone.Image = null;
            txtPhone.ImageExpand = new Point(0, 0);
            txtPhone.ImageOffset = new Point(0, 0);
            txtPhone.Location = new Point(148, 455);
            txtPhone.Margin = new Padding(4);
            txtPhone.Multiline = false;
            txtPhone.Name = "txtPhone";
            txtPhone.NormalImageTint = Color.White;
            txtPhone.OutlineColor = Color.Black;
            txtPhone.Padding = new Padding(32, 11, 32, 0);
            txtPhone.PasswordChar = false;
            txtPhone.PlaceholderColor = SystemColors.ActiveBorder;
            txtPhone.PlaceholderText = "Phone";
            txtPhone.Rounding = new Padding(2);
            txtPhone.Size = new Size(442, 54);
            txtPhone.TabIndex = 0;
            txtPhone.TextOffset = new Size(0, 0);
            txtPhone.UnderlinedStyle = true;
            // 
            // txtEmail
            // 
            txtEmail.BackgroundColor = Color.White;
            txtEmail.Content = "";
            txtEmail.FocusBackgroundColor = Color.White;
            txtEmail.FocusImageTint = Color.White;
            txtEmail.FocusOutlineColor = Color.Black;
            txtEmail.Font = new Font("Century Gothic", 16.2782612F);
            txtEmail.ForeColor = Color.Gray;
            txtEmail.Image = null;
            txtEmail.ImageExpand = new Point(0, 0);
            txtEmail.ImageOffset = new Point(0, 0);
            txtEmail.Location = new Point(148, 393);
            txtEmail.Margin = new Padding(4);
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.NormalImageTint = Color.White;
            txtEmail.OutlineColor = Color.Black;
            txtEmail.Padding = new Padding(32, 11, 32, 0);
            txtEmail.PasswordChar = false;
            txtEmail.PlaceholderColor = SystemColors.ActiveBorder;
            txtEmail.PlaceholderText = "Email";
            txtEmail.Rounding = new Padding(2);
            txtEmail.Size = new Size(442, 54);
            txtEmail.TabIndex = 0;
            txtEmail.TextOffset = new Size(0, 0);
            txtEmail.UnderlinedStyle = true;
            // 
            // txtLastName
            // 
            txtLastName.BackgroundColor = Color.White;
            txtLastName.Content = "";
            txtLastName.FocusBackgroundColor = Color.White;
            txtLastName.FocusImageTint = Color.White;
            txtLastName.FocusOutlineColor = Color.Black;
            txtLastName.Font = new Font("Century Gothic", 16.2782612F);
            txtLastName.ForeColor = Color.Gray;
            txtLastName.Image = null;
            txtLastName.ImageExpand = new Point(0, 0);
            txtLastName.ImageOffset = new Point(0, 0);
            txtLastName.Location = new Point(148, 331);
            txtLastName.Margin = new Padding(4);
            txtLastName.Multiline = false;
            txtLastName.Name = "txtLastName";
            txtLastName.NormalImageTint = Color.White;
            txtLastName.OutlineColor = Color.Black;
            txtLastName.Padding = new Padding(32, 11, 32, 0);
            txtLastName.PasswordChar = false;
            txtLastName.PlaceholderColor = SystemColors.ActiveBorder;
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Rounding = new Padding(2);
            txtLastName.Size = new Size(442, 54);
            txtLastName.TabIndex = 0;
            txtLastName.TextOffset = new Size(0, 0);
            txtLastName.UnderlinedStyle = true;
            txtLastName.Leave += txtLastName_Leave;
            // 
            // txtFirstName
            // 
            txtFirstName.BackgroundColor = Color.White;
            txtFirstName.Content = "";
            txtFirstName.FocusBackgroundColor = Color.White;
            txtFirstName.FocusImageTint = Color.White;
            txtFirstName.FocusOutlineColor = Color.Black;
            txtFirstName.Font = new Font("Century Gothic", 16.2782612F);
            txtFirstName.ForeColor = Color.Gray;
            txtFirstName.Image = null;
            txtFirstName.ImageExpand = new Point(0, 0);
            txtFirstName.ImageOffset = new Point(0, 0);
            txtFirstName.Location = new Point(148, 269);
            txtFirstName.Margin = new Padding(4);
            txtFirstName.Multiline = false;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.NormalImageTint = Color.White;
            txtFirstName.OutlineColor = Color.Black;
            txtFirstName.Padding = new Padding(32, 11, 32, 0);
            txtFirstName.PasswordChar = false;
            txtFirstName.PlaceholderColor = SystemColors.ActiveBorder;
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Rounding = new Padding(2);
            txtFirstName.Size = new Size(442, 54);
            txtFirstName.TabIndex = 0;
            txtFirstName.TextOffset = new Size(0, 0);
            txtFirstName.UnderlinedStyle = true;
            txtFirstName.Leave += txtFirstName_Leave;
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.BackgroundColor = Color.White;
            txtStudentNumber.Content = "";
            txtStudentNumber.FocusBackgroundColor = Color.White;
            txtStudentNumber.FocusImageTint = Color.White;
            txtStudentNumber.FocusOutlineColor = Color.Black;
            txtStudentNumber.Font = new Font("Century Gothic", 16.2782612F);
            txtStudentNumber.ForeColor = Color.Black;
            txtStudentNumber.Image = null;
            txtStudentNumber.ImageExpand = new Point(0, 0);
            txtStudentNumber.ImageOffset = new Point(0, 0);
            txtStudentNumber.Location = new Point(148, 207);
            txtStudentNumber.Margin = new Padding(4);
            txtStudentNumber.Multiline = false;
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.NormalImageTint = Color.White;
            txtStudentNumber.OutlineColor = Color.Black;
            txtStudentNumber.Padding = new Padding(32, 11, 32, 0);
            txtStudentNumber.PasswordChar = false;
            txtStudentNumber.PlaceholderColor = SystemColors.ActiveBorder;
            txtStudentNumber.PlaceholderText = "Student Number";
            txtStudentNumber.Rounding = new Padding(2);
            txtStudentNumber.Size = new Size(442, 54);
            txtStudentNumber.TabIndex = 0;
            txtStudentNumber.TextOffset = new Size(0, 0);
            txtStudentNumber.UnderlinedStyle = true;
            txtStudentNumber.ContentChanged += txtStudentNumber_ContentChanged;
            txtStudentNumber.Leave += txtStudentNumber_Leave;
            // 
            // Register1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1389, 1035);
            Controls.Add(usernameandpasswordpanel);
            Controls.Add(generalandinfopanel);
            MaximizeBox = false;
            Name = "Register1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            WindowState = FormWindowState.Maximized;
            Load += Register1_Load;
            usernameandpasswordpanel.ResumeLayout(false);
            generalandinfopanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel usernameandpasswordpanel;
        private CuoreUI.Controls.cuiPanel generalandinfopanel;
        private CuoreUI.Controls.cuiTextBox txtStudentNumber;
        private CuoreUI.Controls.cuiTextBox passwordtxt;
        private CuoreUI.Controls.cuiTextBox Usernametxt;
        private CuoreUI.Controls.cuiTextBox txtAddress;
        private CuoreUI.Controls.cuiTextBox txtPhone;
        private CuoreUI.Controls.cuiTextBox txtEmail;
        private CuoreUI.Controls.cuiTextBox txtLastName;
        private CuoreUI.Controls.cuiTextBox txtFirstName;
        private CuoreUI.Controls.cuiComboBox department;
        private CuoreUI.Controls.cuiComboBox faculty;
        private CuoreUI.Controls.cuiComboBox cmbGender;
        private CuoreUI.Controls.cuiButton btnRegister;
        private CuoreUI.Controls.cuiCalendarDatePicker dtpDOB;
        private CuoreUI.Controls.cuiPictureBox PictureBox1;
    }
}