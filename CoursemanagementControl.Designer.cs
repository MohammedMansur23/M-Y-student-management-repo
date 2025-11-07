namespace Student_Management_System
{
    partial class CoursemanagementControl
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
            CMpanel = new Panel();
            dockkerpanel = new Panel();
            registeredcoursesdgv = new DataGridView();
            coursesDataGridView = new DataGridView();
            toppanel = new Panel();
            leftpanel = new Panel();
            CMpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)registeredcoursesdgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coursesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // CMpanel
            // 
            CMpanel.BackColor = Color.White;
            CMpanel.Controls.Add(dockkerpanel);
            CMpanel.Controls.Add(registeredcoursesdgv);
            CMpanel.Controls.Add(coursesDataGridView);
            CMpanel.Controls.Add(toppanel);
            CMpanel.Controls.Add(leftpanel);
            CMpanel.Dock = DockStyle.Fill;
            CMpanel.Location = new Point(0, 0);
            CMpanel.Name = "CMpanel";
            CMpanel.Size = new Size(1578, 735);
            CMpanel.TabIndex = 0;
            // 
            // dockkerpanel
            // 
            dockkerpanel.BackColor = Color.White;
            dockkerpanel.Dock = DockStyle.Right;
            dockkerpanel.Location = new Point(799, 50);
            dockkerpanel.Name = "dockkerpanel";
            dockkerpanel.Size = new Size(20, 685);
            dockkerpanel.TabIndex = 3;
            // 
            // registeredcoursesdgv
            // 
            registeredcoursesdgv.AllowUserToAddRows = false;
            registeredcoursesdgv.AllowUserToDeleteRows = false;
            registeredcoursesdgv.AllowUserToResizeColumns = false;
            registeredcoursesdgv.AllowUserToResizeRows = false;
            registeredcoursesdgv.BackgroundColor = Color.White;
            registeredcoursesdgv.BorderStyle = BorderStyle.None;
            registeredcoursesdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registeredcoursesdgv.Dock = DockStyle.Right;
            registeredcoursesdgv.GridColor = Color.Black;
            registeredcoursesdgv.Location = new Point(819, 50);
            registeredcoursesdgv.Name = "registeredcoursesdgv";
            registeredcoursesdgv.RowHeadersVisible = false;
            registeredcoursesdgv.RowHeadersWidth = 49;
            registeredcoursesdgv.Size = new Size(759, 685);
            registeredcoursesdgv.TabIndex = 2;
            registeredcoursesdgv.CellContentClick += registeredcoursesdgv_CellContentClick;
            // 
            // coursesDataGridView
            // 
            coursesDataGridView.AllowUserToAddRows = false;
            coursesDataGridView.AllowUserToDeleteRows = false;
            coursesDataGridView.AllowUserToResizeColumns = false;
            coursesDataGridView.AllowUserToResizeRows = false;
            coursesDataGridView.BackgroundColor = Color.White;
            coursesDataGridView.BorderStyle = BorderStyle.None;
            coursesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coursesDataGridView.Dock = DockStyle.Left;
            coursesDataGridView.GridColor = Color.Black;
            coursesDataGridView.Location = new Point(20, 50);
            coursesDataGridView.Name = "coursesDataGridView";
            coursesDataGridView.RowHeadersVisible = false;
            coursesDataGridView.RowHeadersWidth = 49;
            coursesDataGridView.Size = new Size(770, 685);
            coursesDataGridView.TabIndex = 0;
            coursesDataGridView.CellContentClick += coursesDataGridView_CellContentClick;
            // 
            // toppanel
            // 
            toppanel.BackColor = Color.White;
            toppanel.Dock = DockStyle.Top;
            toppanel.Location = new Point(20, 0);
            toppanel.Name = "toppanel";
            toppanel.Size = new Size(1558, 50);
            toppanel.TabIndex = 1;
            // 
            // leftpanel
            // 
            leftpanel.BackColor = Color.White;
            leftpanel.Dock = DockStyle.Left;
            leftpanel.Location = new Point(0, 0);
            leftpanel.Name = "leftpanel";
            leftpanel.Size = new Size(20, 735);
            leftpanel.TabIndex = 1;
            // 
            // CoursemanagementControl
            // 
            AutoScaleDimensions = new SizeF(15F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(CMpanel);
            Font = new Font("Century Gothic", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(4, 20, 41);
            Margin = new Padding(6, 5, 6, 5);
            Name = "CoursemanagementControl";
            Size = new Size(1578, 735);
            CMpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)registeredcoursesdgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)coursesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel CMpanel;
        private DataGridView coursesDataGridView;
        private Panel toppanel;
        private DataGridView registeredcoursesdgv;
        private Panel leftpanel;
        private Panel dockkerpanel;
    }
}
