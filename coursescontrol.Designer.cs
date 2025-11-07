namespace Student_Management_System
{
    partial class coursescontrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelleft = new Panel();
            paneltop = new Panel();
            panelright = new Panel();
            panelcenter = new Panel();
            dataGridViewcourses = new DataGridView();
            panelcenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewcourses).BeginInit();
            SuspendLayout();
            // 
            // panelleft
            // 
            panelleft.Dock = DockStyle.Left;
            panelleft.Location = new Point(0, 0);
            panelleft.Name = "panelleft";
            panelleft.Size = new Size(110, 735);
            panelleft.TabIndex = 0;
            // 
            // paneltop
            // 
            paneltop.Dock = DockStyle.Top;
            paneltop.Location = new Point(110, 0);
            paneltop.Name = "paneltop";
            paneltop.Size = new Size(1270, 120);
            paneltop.TabIndex = 0;
            // 
            // panelright
            // 
            panelright.Dock = DockStyle.Right;
            panelright.Location = new Point(1270, 120);
            panelright.Name = "panelright";
            panelright.Size = new Size(110, 615);
            panelright.TabIndex = 0;
            // 
            // panelcenter
            // 
            panelcenter.Controls.Add(dataGridViewcourses);
            panelcenter.Dock = DockStyle.Fill;
            panelcenter.Location = new Point(110, 120);
            panelcenter.Name = "panelcenter";
            panelcenter.Size = new Size(1160, 615);
            panelcenter.TabIndex = 0;
            // 
            // dataGridViewcourses
            // 
            dataGridViewcourses.AllowUserToAddRows = false;
            dataGridViewcourses.AllowUserToDeleteRows = false;
            dataGridViewcourses.AllowUserToResizeColumns = false;
            dataGridViewcourses.AllowUserToResizeRows = false;
            dataGridViewcourses.BackgroundColor = Color.White;
            dataGridViewcourses.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(4, 20, 21);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewcourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewcourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewcourses.Dock = DockStyle.Fill;
            dataGridViewcourses.GridColor = Color.Black;
            dataGridViewcourses.Location = new Point(0, 0);
            dataGridViewcourses.Name = "dataGridViewcourses";
            dataGridViewcourses.RowHeadersVisible = false;
            dataGridViewcourses.RowHeadersWidth = 49;
            dataGridViewcourses.Size = new Size(1160, 615);
            dataGridViewcourses.TabIndex = 0;
            dataGridViewcourses.CellContentClick += dataGridViewcourses_CellContentClick;
            // 
            // coursescontrol
            // 
            AutoScaleDimensions = new SizeF(15F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelcenter);
            Controls.Add(panelright);
            Controls.Add(paneltop);
            Controls.Add(panelleft);
            Font = new Font("Century Gothic", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(4, 20, 41);
            Margin = new Padding(6, 5, 6, 5);
            Name = "coursescontrol";
            Size = new Size(1380, 735);
            panelcenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewcourses).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelleft;
        private Panel paneltop;
        private Panel panelright;
        private Panel panelcenter;
        private DataGridView dataGridViewcourses;
    }
}
