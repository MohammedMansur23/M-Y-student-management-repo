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
using static Mysqlx.Notice.Warning.Types;

namespace Student_Management_System
{
    public partial class CoursemanagementControl : UserControl
    {
        public event Action CoursesUpdated;
        private int studentLevel;
        private string studentFaculty;
        private string studentNumber;
        public CoursemanagementControl()
        {
            InitializeComponent();
            // Don't call LoadCourses() here, designer will break if DB not available
        }

        public CoursemanagementControl(int level, string faculty, string studentNumber)
        {
            InitializeComponent();
            studentLevel = level;
            studentFaculty = faculty;
            this.studentNumber = studentNumber;
            LoadCourses();
            LoadRegisteredCourses();
            LoadCourses();
            RefreshRegisteredCourses();
        }
        private void LoadCourses()
        {
            Database db = new Database();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT c.course_code, c.course_name, c.course_credit_units
                    FROM courses c
                    LEFT JOIN registered_courses rc
                        ON c.course_code = rc.course_code AND rc.student_number = @student_number
                    WHERE c.course_level = @level AND c.faculty = @faculty AND rc.course_code IS NULL
                ";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@level", studentLevel);
                    cmd.Parameters.AddWithValue("@faculty", studentFaculty);
                    cmd.Parameters.AddWithValue("@student_number", studentNumber);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    //coursesDataGridView.DataSource = null;
                    coursesDataGridView.DataSource = dt;
                    coursesDataGridView.AllowUserToAddRows = false;

                    //StretchRowsToFill();
                    coursesDataGridView.AutoGenerateColumns = false;

                    int dgvwidth = coursesDataGridView.ClientSize.Width;
                    coursesDataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(4, 20, 41);
                    coursesDataGridView.Columns["course_code"].HeaderText = "Course Code";
                    coursesDataGridView.Columns["course_name"].HeaderText = "Course Description";
                    coursesDataGridView.Columns["course_credit_units"].HeaderText = "Credit Unit";
                    // Add Add/Drop button columns if not present
                    if (!coursesDataGridView.Columns.Contains("Add"))
                    {
                        DataGridViewButtonColumn addButton = new DataGridViewButtonColumn();
                        addButton.Name = "Add";
                        addButton.HeaderText = "Add";
                        addButton.Text = "Add";
                        addButton.UseColumnTextForButtonValue = true;
                        coursesDataGridView.Columns.Add(addButton);
                    }

                    coursesDataGridView.Columns["course_code"].FillWeight = 30;
                    coursesDataGridView.Columns["course_name"].FillWeight = 100;
                    coursesDataGridView.Columns["course_credit_units"].FillWeight = 30;

                    coursesDataGridView.Columns["course_code"].Width = (int)(dgvwidth * 0.15);
                    coursesDataGridView.Columns["course_name"].Width = (int)(dgvwidth * 0.53);
                    coursesDataGridView.Columns["course_credit_units"].Width = (int)(dgvwidth * 0.12);
                    coursesDataGridView.Columns["Add"].Width = (int)(dgvwidth * 0.15);
                    coursesDataGridView.DefaultCellStyle.Font = new Font ("Century Gothic", 14, FontStyle.Bold);

                    coursesDataGridView.ColumnHeadersHeight = 120; // Set custom header height
                    coursesDataGridView.EnableHeadersVisualStyles = false; // must disable default theme first
                    coursesDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(4, 20, 41);
                    coursesDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                    coursesDataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 16, FontStyle.Bold);

                    coursesDataGridView.RowTemplate.Height = 70;

                    coursesDataGridView.Columns["course_code"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    coursesDataGridView.Columns["course_credit_units"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    coursesDataGridView.Columns["Add"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
            }
        }

        private void LoadRegisteredCourses()
        {
            Database db = new Database();
            int dgvwidth = coursesDataGridView.ClientSize.Width;
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
                        dt = dt.DefaultView.ToTable(true, "course_code", "course_name", "course_credit_units");

                    registeredcoursesdgv.SuspendLayout();
                    registeredcoursesdgv.DataSource = null;
                    registeredcoursesdgv.AllowUserToAddRows = false;
                    registeredcoursesdgv.AutoGenerateColumns = false;

                    // Clear and recreate columns — safe and idempotent
                    registeredcoursesdgv.Columns.Clear();

                    registeredcoursesdgv.Columns.Add("course_code", "Course Code");
                    registeredcoursesdgv.Columns.Add("course_name", "Course Description");
                    registeredcoursesdgv.Columns.Add("course_credit_units", "Credit Unit");

                    registeredcoursesdgv.Columns["course_code"].DataPropertyName = "course_code";
                    registeredcoursesdgv.Columns["course_name"].DataPropertyName = "course_name";
                    registeredcoursesdgv.Columns["course_credit_units"].DataPropertyName = "course_credit_units";

                    registeredcoursesdgv.Columns["course_code"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    registeredcoursesdgv.Columns["course_credit_units"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    // Add Drop button (single instance because we cleared above)
                    DataGridViewButtonColumn dropButton = new DataGridViewButtonColumn();
                    dropButton.Name = "Drop";
                    dropButton.HeaderText = "Drop";
                    dropButton.Text = "Drop";
                    dropButton.UseColumnTextForButtonValue = true;
                    registeredcoursesdgv.Columns.Add(dropButton);

                    // Bind AFTER columns are prepared
                    registeredcoursesdgv.DataSource = dt;

                    // Style + sizing
                    registeredcoursesdgv.DefaultCellStyle.ForeColor = Color.FromArgb(4, 20, 41);
                    registeredcoursesdgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(4, 20, 41);
                    registeredcoursesdgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                    registeredcoursesdgv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 14, FontStyle.Bold);

                    registeredcoursesdgv.Columns["course_code"].Width = (int)(dgvwidth * 0.15);
                    registeredcoursesdgv.Columns["course_name"].Width = (int)(dgvwidth * 0.53);
                    registeredcoursesdgv.Columns["course_credit_units"].Width = (int)(dgvwidth * 0.12);
                    registeredcoursesdgv.Columns["Drop"].Width = (int)(dgvwidth * 0.15);
                    registeredcoursesdgv.Columns["Drop"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    registeredcoursesdgv.RowTemplate.Height = 70;
                    registeredcoursesdgv.ColumnHeadersHeight = 120;
                    registeredcoursesdgv.EnableHeadersVisualStyles = false;
                    registeredcoursesdgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(4, 20, 41);
                    registeredcoursesdgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                    registeredcoursesdgv.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 16, FontStyle.Bold);
                    registeredcoursesdgv.DefaultCellStyle.Font = new Font("Century Gothic", 14, FontStyle.Bold);

                    registeredcoursesdgv.ResumeLayout();
                }
            }
        }


        /*private void StretchRowsToFill()
        {
            if (coursesDataGridView.Rows.Count == 0) return;

            int dgvHeight = coursesDataGridView.ClientSize.Height;
            int headerHeight = coursesDataGridView.ColumnHeadersHeight;
            int rowCount = coursesDataGridView.Rows.Count;

            // Skip the new row placeholder if AllowUserToAddRows is true
            if (coursesDataGridView.AllowUserToAddRows)
                rowCount--;

            if (rowCount <= 0) return;

            // Calculate new height for each row
            int newRowHeight = (dgvHeight - headerHeight) / rowCount;

            foreach (DataGridViewRow row in coursesDataGridView.Rows)
            {
                if (!row.IsNewRow)
                    row.Height = newRowHeight;
            }
        }*/
        private void coursesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && coursesDataGridView.Columns[e.ColumnIndex].Name == "Add")
            {
                string courseCode = coursesDataGridView.Rows[e.RowIndex].Cells["course_code"].Value.ToString();

                // 1️⃣ Register the course in database
                RegisterCourse(courseCode);

                // 2️⃣ Remove it from available courses DGV
                coursesDataGridView.Rows.RemoveAt(e.RowIndex);

                // 3️⃣ Refresh the registered courses DGV
                LoadCourses();
                LoadRegisteredCourses();
                RefreshRegisteredCourses();
            }
        }
        private void registeredcoursesdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && registeredcoursesdgv.Columns[e.ColumnIndex].Name == "Drop")
            {
                string courseCode = registeredcoursesdgv.Rows[e.RowIndex].Cells["course_code"].Value.ToString();

                // 1️⃣ Delete the course from database
                DropCourse(courseCode);

                // 2️⃣ Remove it from registered courses DGV
                registeredcoursesdgv.Rows.RemoveAt(e.RowIndex);

                // 3️⃣ Refresh the available courses DGV
                LoadCourses();
                LoadRegisteredCourses();
                RefreshRegisteredCourses();
            }
        }
        private void RegisterCourse(string courseCode)
        {
            Database db = new Database();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO registered_courses (student_number, course_code, faculty, date_registered) 
                               VALUES (@student_number, @course_code, @faculty, NOW())";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@student_number", studentNumber);
                    cmd.Parameters.AddWithValue("@course_code", courseCode);
                    cmd.Parameters.AddWithValue("@faculty", studentFaculty);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Course added successfully!");
                        CoursesUpdated?.Invoke();
                    }
                    catch (MySqlException ex)
                    {
                        if (ex.Number == 1062) // Duplicate entry
                            MessageBox.Show("You already registered this course!");
                        else
                            MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private void DropCourse(string courseCode)
        {
            Database db = new Database();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = @"DELETE FROM registered_courses 
                               WHERE student_number = @student_number AND course_code = @course_code AND faculty = @faculty";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@student_number", studentNumber);
                    cmd.Parameters.AddWithValue("@course_code", courseCode);
                    cmd.Parameters.AddWithValue("@faculty", studentFaculty);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Course dropped successfully!");
                        CoursesUpdated?.Invoke();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        public void RefreshRegisteredCourses()
        {
            LoadRegisteredCourses();
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
