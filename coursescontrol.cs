using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class coursescontrol : UserControl
    {
        private int studentLevel;
        private string studentFaculty;
        private string studentNumber;
        public coursescontrol()
        {
            InitializeComponent();
        }
        public coursescontrol(int level, string faculty, string studentNumber)
        {
            InitializeComponent();
            studentLevel = level;
            studentFaculty = faculty;
            this.studentNumber = studentNumber;
            LoadedCourses();
        }

        public void LoadedCourses()
        {
            Database db = new Database();
            int dgvwidth = dataGridViewcourses.ClientSize.Width;
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = @"
            SELECT 
                c.course_code, 
                c.course_name, 
                c.course_credit_units
            FROM registered_courses rc
            JOIN courses c ON rc.course_code = c.course_code
            WHERE rc.student_number = @student_number AND rc.faculty = @faculty";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@student_number", studentNumber);
                    cmd.Parameters.AddWithValue("@faculty", studentFaculty);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 1)
                    {
                        dt = dt.DefaultView.ToTable(true, "course_code", "course_name", "course_credit_units");
                    }

                    dataGridViewcourses.SuspendLayout();

                    dataGridViewcourses.DataSource = null;
                    dataGridViewcourses.DataSource = dt;
                    dataGridViewcourses.AllowUserToAddRows = false;
                    dataGridViewcourses.AutoGenerateColumns = false;

                    dataGridViewcourses.Columns.Clear(); // clear old columns

                    // Add columns manually for clean look
                    dataGridViewcourses.Columns.Add("course_code", "Course Code");
                    dataGridViewcourses.Columns.Add("course_name", "Course Description");
                    dataGridViewcourses.Columns.Add("course_credit_units", "Credit Unit");
    
                    DataGridViewTextBoxColumn status = new DataGridViewTextBoxColumn();
                    status.Name = "status";
                    status.HeaderText = "Status";
                    status.Visible = true;
                    status.ValueType = typeof(string);
                    status.DataPropertyName = "status";
                    dataGridViewcourses.Columns.Add(status);
                    foreach (DataGridViewRow row in dataGridViewcourses.Rows)
                    {
                        row.Cells["status"].Value = "Approved";
                    }

                    dataGridViewcourses.Columns["course_code"].DataPropertyName = "course_code";
                    dataGridViewcourses.Columns["course_name"].DataPropertyName = "course_name";
                    dataGridViewcourses.Columns["course_credit_units"].DataPropertyName = "course_credit_units";

                    dataGridViewcourses.Columns["course_code"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridViewcourses.Columns["course_credit_units"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    // Style + sizing
                    dataGridViewcourses.DefaultCellStyle.ForeColor = Color.FromArgb(4, 20, 41);
                    dataGridViewcourses.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(4, 20, 41);
                    dataGridViewcourses.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                    dataGridViewcourses.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14, FontStyle.Bold);

                    dataGridViewcourses.Columns["course_code"].Width = (int)(dgvwidth * 0.15);
                    dataGridViewcourses.Columns["course_name"].Width = (int)(dgvwidth * 0.59);
                    dataGridViewcourses.Columns["course_credit_units"].Width = (int)(dgvwidth * 0.125);
                    status.Width = (int)(dgvwidth * 0.113);

                    dataGridViewcourses.RowTemplate.Height = 70;
                    dataGridViewcourses.ColumnHeadersHeight = 120; // Set custom header height
                    dataGridViewcourses.EnableHeadersVisualStyles = false; // must disable default theme first
                    dataGridViewcourses.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(4, 20, 41);
                    dataGridViewcourses.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                    dataGridViewcourses.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 16, FontStyle.Bold);
                    dataGridViewcourses.DefaultCellStyle.Font = new Font("Century Gothic", 14, FontStyle.Bold);

                    dataGridViewcourses.ResumeLayout();
                }
            }
        }

        private void dataGridViewcourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public class Database
        {
            private string connectionString = "Server=localhost;Database=sms_db;Uid=root;Pwd='';";

            public MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }
        }
    }
}
