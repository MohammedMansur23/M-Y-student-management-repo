namespace Student_Management_System
{
    partial class Dashboard
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
            dashboardentrypanel = new Panel();
            dashboardpanel = new Panel();
            overviewpanel = new Panel();
            dashboardPictureBox = new PictureBox();
            welcomelabel = new Label();
            menupanel = new Panel();
            Accountdetailsbtn = new Button();
            Resultbtn = new Button();
            logoutbtn = new Button();
            coursemanagementbtn = new Button();
            coursesbtn = new Button();
            dashboardbtn = new Button();
            dashboardentrypanel.SuspendLayout();
            overviewpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).BeginInit();
            menupanel.SuspendLayout();
            SuspendLayout();
            // 
            // dashboardentrypanel
            // 
            dashboardentrypanel.Controls.Add(dashboardpanel);
            dashboardentrypanel.Controls.Add(overviewpanel);
            dashboardentrypanel.Controls.Add(menupanel);
            dashboardentrypanel.Dock = DockStyle.Fill;
            dashboardentrypanel.Location = new Point(0, 0);
            dashboardentrypanel.Name = "dashboardentrypanel";
            dashboardentrypanel.Size = new Size(1389, 1035);
            dashboardentrypanel.TabIndex = 0;
            // 
            // dashboardpanel
            // 
            dashboardpanel.Dock = DockStyle.Fill;
            dashboardpanel.Location = new Point(274, 142);
            dashboardpanel.Name = "dashboardpanel";
            dashboardpanel.Size = new Size(1115, 893);
            dashboardpanel.TabIndex = 2;
            // 
            // overviewpanel
            // 
            overviewpanel.Controls.Add(dashboardPictureBox);
            overviewpanel.Controls.Add(welcomelabel);
            overviewpanel.Dock = DockStyle.Top;
            overviewpanel.Font = new Font("Tahoma", 12F);
            overviewpanel.Location = new Point(274, 0);
            overviewpanel.Name = "overviewpanel";
            overviewpanel.Size = new Size(1115, 142);
            overviewpanel.TabIndex = 1;
            // 
            // dashboardPictureBox
            // 
            dashboardPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dashboardPictureBox.Location = new Point(934, 3);
            dashboardPictureBox.Name = "dashboardPictureBox";
            dashboardPictureBox.Size = new Size(130, 133);
            dashboardPictureBox.TabIndex = 1;
            dashboardPictureBox.TabStop = false;
            // 
            // welcomelabel
            // 
            welcomelabel.AutoSize = true;
            welcomelabel.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Bold);
            welcomelabel.ForeColor = SystemColors.ActiveCaptionText;
            welcomelabel.Location = new Point(14, 42);
            welcomelabel.Name = "welcomelabel";
            welcomelabel.Size = new Size(0, 37);
            welcomelabel.TabIndex = 0;
            // 
            // menupanel
            // 
            menupanel.BorderStyle = BorderStyle.Fixed3D;
            menupanel.Controls.Add(Accountdetailsbtn);
            menupanel.Controls.Add(Resultbtn);
            menupanel.Controls.Add(logoutbtn);
            menupanel.Controls.Add(coursemanagementbtn);
            menupanel.Controls.Add(coursesbtn);
            menupanel.Controls.Add(dashboardbtn);
            menupanel.Dock = DockStyle.Left;
            menupanel.Font = new Font("Tahoma", 12F);
            menupanel.Location = new Point(0, 0);
            menupanel.Name = "menupanel";
            menupanel.Size = new Size(274, 1035);
            menupanel.TabIndex = 0;
            // 
            // Accountdetailsbtn
            // 
            Accountdetailsbtn.Anchor = AnchorStyles.None;
            Accountdetailsbtn.FlatAppearance.BorderSize = 0;
            Accountdetailsbtn.FlatStyle = FlatStyle.Flat;
            Accountdetailsbtn.Font = new Font("Arial Rounded MT Bold", 15F);
            Accountdetailsbtn.Location = new Point(-2, 509);
            Accountdetailsbtn.Name = "Accountdetailsbtn";
            Accountdetailsbtn.Size = new Size(269, 56);
            Accountdetailsbtn.TabIndex = 5;
            Accountdetailsbtn.Text = "Account Details";
            Accountdetailsbtn.TextAlign = ContentAlignment.MiddleLeft;
            Accountdetailsbtn.UseVisualStyleBackColor = true;
            // 
            // Resultbtn
            // 
            Resultbtn.Anchor = AnchorStyles.None;
            Resultbtn.FlatAppearance.BorderSize = 0;
            Resultbtn.FlatStyle = FlatStyle.Flat;
            Resultbtn.Font = new Font("Arial Rounded MT Bold", 15F);
            Resultbtn.Location = new Point(-2, 431);
            Resultbtn.Name = "Resultbtn";
            Resultbtn.Size = new Size(269, 56);
            Resultbtn.TabIndex = 4;
            Resultbtn.Text = "Result";
            Resultbtn.TextAlign = ContentAlignment.MiddleLeft;
            Resultbtn.UseVisualStyleBackColor = true;
            // 
            // logoutbtn
            // 
            logoutbtn.Anchor = AnchorStyles.Left;
            logoutbtn.FlatAppearance.BorderSize = 0;
            logoutbtn.FlatStyle = FlatStyle.Flat;
            logoutbtn.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            logoutbtn.Location = new Point(15, 905);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(244, 69);
            logoutbtn.TabIndex = 3;
            logoutbtn.Text = "Log Out?";
            logoutbtn.UseVisualStyleBackColor = true;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // coursemanagementbtn
            // 
            coursemanagementbtn.Anchor = AnchorStyles.None;
            coursemanagementbtn.FlatAppearance.BorderSize = 0;
            coursemanagementbtn.FlatStyle = FlatStyle.Flat;
            coursemanagementbtn.Font = new Font("Arial Rounded MT Bold", 15F);
            coursemanagementbtn.Location = new Point(-2, 354);
            coursemanagementbtn.Name = "coursemanagementbtn";
            coursemanagementbtn.Size = new Size(269, 56);
            coursemanagementbtn.TabIndex = 2;
            coursemanagementbtn.Text = "Course Management";
            coursemanagementbtn.TextAlign = ContentAlignment.MiddleLeft;
            coursemanagementbtn.UseVisualStyleBackColor = true;
            // 
            // coursesbtn
            // 
            coursesbtn.Anchor = AnchorStyles.None;
            coursesbtn.FlatAppearance.BorderSize = 0;
            coursesbtn.FlatStyle = FlatStyle.Flat;
            coursesbtn.Font = new Font("Arial Rounded MT Bold", 15F);
            coursesbtn.Location = new Point(-2, 276);
            coursesbtn.Name = "coursesbtn";
            coursesbtn.Size = new Size(269, 56);
            coursesbtn.TabIndex = 1;
            coursesbtn.Text = "Courses";
            coursesbtn.TextAlign = ContentAlignment.MiddleLeft;
            coursesbtn.UseVisualStyleBackColor = true;
            // 
            // dashboardbtn
            // 
            dashboardbtn.Anchor = AnchorStyles.None;
            dashboardbtn.FlatAppearance.BorderSize = 0;
            dashboardbtn.FlatStyle = FlatStyle.Flat;
            dashboardbtn.Font = new Font("Arial Rounded MT Bold", 15F);
            dashboardbtn.Location = new Point(-2, 198);
            dashboardbtn.Name = "dashboardbtn";
            dashboardbtn.Size = new Size(269, 56);
            dashboardbtn.TabIndex = 0;
            dashboardbtn.Text = "Dashboard";
            dashboardbtn.TextAlign = ContentAlignment.MiddleLeft;
            dashboardbtn.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1389, 1035);
            Controls.Add(dashboardentrypanel);
            Font = new Font("Arial Rounded MT Bold", 8.765218F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Dashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            dashboardentrypanel.ResumeLayout(false);
            overviewpanel.ResumeLayout(false);
            overviewpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).EndInit();
            menupanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel dashboardentrypanel;
        private Panel overviewpanel;
        private Panel menupanel;
        private Label welcomelabel;
        private Button coursemanagementbtn;
        private Button coursesbtn;
        private Button dashboardbtn;
        private Button logoutbtn;
        private Panel dashboardpanel;
        private PictureBox dashboardPictureBox;
        private Button Accountdetailsbtn;
        private Button Resultbtn;
    }
}