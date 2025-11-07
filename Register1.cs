using CuoreUI.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static Student_Management_System.Login;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Student_Management_System
{
    public partial class Register1 : Form
    {
        Dictionary<string, List<string>> facultyDepartments = new Dictionary<string, List<string>>()
        {
            {"Arts", new List<string>{"English", "History & International Studies", "Religion", "Performing Arts"}},
            {"Engineering and Technology", new List<string>{"Computer Engineering", "Electrical Engineering","Civil Engineering","Mechanical Engineering"}},
            {"Basic Medical Sciences", new List<string>{"Medicine and Surgery", "Anatomy", "Physiology", "Medical Laboratory Science"}},
            {"Life Sciences", new List<string>{"Microbiology","Plant Biology","Zoology","Environmental Biology"}},
            {"Commmunication and Information Sciences", new List<string>{"Computer Science","Information Technology","Telecommunication Science","Library & Inforamtion Science"}},
            {"Basic Sciences", new List<string>{"Physics","Mathematics","Chemistry","Statistics"}},
            {"Education", new List<string>{"Computer Science Education","Arts Education","Human Kinetics Education","Educational Management"}}
        };

        public Register1()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCLBUTTONDBLCLK = 0x00A3; // Double-click on title bar
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010; // Move window (dragging)
            const int SC_MAXIMIZE = 0xF030;

            if (m.Msg == WM_NCLBUTTONDBLCLK) return; // Disable double-click restore
            if (m.Msg == WM_SYSCOMMAND)
            {
                int command = m.WParam.ToInt32() & 0xFFF0;
                if (command == SC_MOVE || command == SC_MAXIMIZE) return; // Disable drag/maximize
            }

            base.WndProc(ref m);
        }
        private bool passportImported = false;
        string errorr = "⚠ Error!";
        string req = "⚠️ Required!";
        string succ = "✅ Success!";

        private void Register1_Load(object sender, EventArgs e)
        {
            department.Enabled = false;
            faculty.Items = (facultyDepartments.Keys.ToArray());
            LoadStudents();
            faculty.VerticalScroll.Visible = true;
            faculty.AutoScroll = true;
            department.VerticalScroll.Visible = true;
            department.AutoScroll = true;
            txtFirstName.Focus();
            /* txtFirstName.PlaceholderText = "First";
             txtLastName.PlaceholderText = "Last";
             txtStudentNumber.PlaceholderText = "####/##**###";
             txtEmail.PlaceholderText = "name@example.com";
             txtPhone.PlaceholderText = "08012345678";*/
        }
        private void LoadStudents()
        {
            Database db = new Database();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql1 = "SELECT  student_number, first_name, last_name, email, phone, dob, username, password, faculty, department, program, program_duration FROM students";
                MySqlDataAdapter da = new MySqlDataAdapter(sql1, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            TextInfo names1 = CultureInfo.CurrentCulture.TextInfo;
            txtFirstName.contentTextField.Text = names1.ToTitleCase(txtFirstName.contentTextField.Text.ToLower());
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            TextInfo names2 = CultureInfo.CurrentCulture.TextInfo;
            txtLastName.contentTextField.Text = names2.ToTitleCase(txtLastName.contentTextField.Text.ToLower());
        }

        private void Usernametxt_Leave(object sender, EventArgs e)
        {
            TextInfo usernames = CultureInfo.CurrentCulture.TextInfo;
            Usernametxt.contentTextField.Text = usernames.ToTitleCase(Usernametxt.contentTextField.Text.ToLower());
        }

        private void txtStudentNumber_Leave(object sender, EventArgs e)
        {
            TextInfo stdidd = CultureInfo.CurrentCulture.TextInfo;
            txtStudentNumber.contentTextField.Text = stdidd.ToTitleCase(txtStudentNumber.contentTextField.Text.ToUpper());
            string id = txtStudentNumber.contentTextField.Text;
            string nid = @"^20\d{2}[-/]\d{2}[A-Za-z]{2}\d{3}$";

            if (string.IsNullOrEmpty(id) || id.Length < 4)
            {
                MessageBox.Show("Invalid Student Number!", errorr);
                txtStudentNumber.contentTextField.Text = string.Empty;
                faculty.SelectedItem = faculty.NoSelectionText;
                department.SelectedItem = department.NoSelectionText;
                return;
            }
            int year;
            int.TryParse(id.Substring(0, 4), out year);
            if (!Regex.IsMatch(id, nid) || string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Enter a valid Student Number", errorr);
                faculty.Enabled = true;
                faculty.SelectedItem = faculty.NoSelectionText;
                department.SelectedItem = department.NoSelectionText;
            }

            if (year > DateTime.Now.Year)
            {
                MessageBox.Show("Invalid Student Number: year cannot be in the future", errorr);
                txtStudentNumber.contentTextField.Text = string.Empty;
                txtStudentNumber.Focus();
            }

            else
            {
                // Arts
                if (id.Contains("/46"))
                {
                    faculty.SelectedItem = faculty.Items[0];
                    if (id.Contains("46EN"))
                    {
                        faculty.SelectedItem = faculty.Items[0];
                        department.SelectedItem = department.Items[0];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("46RE"))
                    {
                        faculty.SelectedItem = faculty.Items[0];
                        department.SelectedItem = department.Items[2];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("46HI"))
                    {
                        faculty.SelectedItem = faculty.Items[0];
                        department.SelectedItem = department.Items[1];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("46PA"))
                    {
                        faculty.SelectedItem = faculty.Items[0];
                        department.SelectedItem = department.Items[3];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else
                        MessageBox.Show("Invalid Student Number", errorr);
                }

                // Basic Medical Sciences
                else if (id.Contains("/48"))
                {
                    faculty.SelectedItem = faculty.Items[2];
                    if (id.Contains("MS"))
                    {
                        faculty.SelectedItem = faculty.Items[2];
                        department.SelectedItem = department.Items[0];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("AN"))
                    {
                        faculty.SelectedItem = faculty.Items[2];
                        department.SelectedItem = department.Items[1];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("PH"))
                    {
                        faculty.SelectedItem = faculty.Items[2];
                        department.SelectedItem = department.Items[2];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("ML"))
                    {
                        faculty.SelectedItem = faculty.Items[2];
                        department.SelectedItem = department.Items[3];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else
                        MessageBox.Show("Invalid Student Number", errorr);
                }

                // Basic Sciences
                else if (id.Contains("/50"))
                {
                    faculty.SelectedItem = faculty.Items[5];
                    if (id.Contains("PY"))
                    {
                        faculty.SelectedItem = faculty.Items[5];
                        department.SelectedItem = department.Items[0];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("CH"))
                    {
                        faculty.SelectedItem = faculty.Items[5];
                        department.SelectedItem = department.Items[2];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("ST"))
                    {
                        faculty.SelectedItem = faculty.Items[5];
                        department.SelectedItem = department.Items[3];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("MA"))
                    {
                        faculty.SelectedItem = faculty.Items[5];
                        department.SelectedItem = department.Items[1];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else
                        MessageBox.Show("Invalid Student Number", errorr);
                }

                // Communication & Info Sciences
                else if (id.Contains("/52"))
                {
                    faculty.SelectedItem = faculty.Items[4];
                    if (id.Contains("CS"))
                    {
                        faculty.SelectedItem = faculty.Items[4];
                        department.SelectedItem = department.Items[0];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("IT"))
                    {
                        faculty.SelectedItem = faculty.Items[4];
                        department.SelectedItem = department.Items[1];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("TS"))
                    {
                        faculty.SelectedItem = faculty.Items[4];
                        department.SelectedItem = department.Items[2];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("LS"))
                    {
                        faculty.SelectedItem = faculty.Items[4];
                        department.SelectedItem = department.Items[3];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else
                        MessageBox.Show("Invalid Student Number", errorr);
                }

                // Education
                else if (id.Contains("/54"))
                {
                    faculty.SelectedItem = faculty.Items[6];
                    if (id.Contains("SE"))
                    {
                        faculty.SelectedItem = faculty.Items[6];
                        department.SelectedItem = department.Items[0];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("AE"))
                    {
                        faculty.SelectedItem = faculty.Items[6];
                        department.SelectedItem = department.Items[1];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("HK"))
                    {
                        faculty.SelectedItem = faculty.Items[6];
                        department.SelectedItem = department.Items[2];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("EM"))
                    {
                        faculty.SelectedItem = faculty.Items[6];
                        department.SelectedItem = department.Items[3];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else
                        MessageBox.Show("Invalid Student Number", errorr);
                }

                // Engineering
                else if (id.Contains("/56"))
                {
                    faculty.SelectedItem = faculty.Items[1];
                    if (id.Contains("CP"))
                    {
                        faculty.SelectedItem = faculty.Items[1];
                        department.SelectedItem = department.Items[0];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("CE"))
                    {
                        faculty.SelectedItem = faculty.Items[1];
                        department.SelectedItem = department.Items[2];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("EE"))
                    {
                        faculty.SelectedItem = faculty.Items[1];
                        department.SelectedItem = department.Items[1];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("ME"))
                    {
                        faculty.SelectedItem = faculty.Items[1];
                        department.SelectedItem = department.Items[3];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else
                        MessageBox.Show("Invalid Student Number", errorr);
                }

                // Life Sciences
                else if (id.Contains("/58"))
                {
                    faculty.SelectedItem = faculty.Items[3];
                    if (id.Contains("MB"))
                    {
                        faculty.SelectedItem = faculty.Items[3];
                        department.SelectedItem = department.Items[0];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("PB"))
                    {
                        faculty.SelectedItem = faculty.Items[3];
                        department.SelectedItem = department.Items[1];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("ZO"))
                    {
                        faculty.SelectedItem = faculty.Items[3];
                        department.SelectedItem = department.Items[2];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else if (id.Contains("EB"))
                    {
                        faculty.SelectedItem = faculty.Items[3];
                        department.SelectedItem = department.Items[3];
                        faculty.Enabled = false;
                        department.Enabled = false;
                    }
                    else
                        MessageBox.Show("Invalid Student Number", errorr);
                }
                else
                {
                    MessageBox.Show("Invalid Student Number", errorr);
                    faculty.Enabled = true;
                    faculty.SelectedItem = faculty.NoSelectionText;
                    department.SelectedItem = department.NoSelectionText;
                    txtStudentNumber.contentTextField.Text = string.Empty;
                }
            }
        }

        private void faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            department.Enabled = true;
            department.Items = Array.Empty<string>(); ;
            string selectedfaculty = faculty.SelectedItem.ToString();

            if (facultyDepartments.ContainsKey(selectedfaculty))
            {
                department.Items = (facultyDepartments[selectedfaculty].ToArray());
            }
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Passport Photo";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    PictureBox1.BackgroundImage = Image.FromFile(ofd.FileName);
                }
                passportImported = true;
            }
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            Database db = new Database();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql1 = "INSERT INTO students (passport, student_number, first_name, last_name, email, phone, dob, gender, address, username, password, faculty, department, program, program_duration) " +
                             "VALUES (@passport, @number, @first, @last, @email, @phone, @dob, @gender, @address, @username, @password, @faculty, @department, @program, @program_duration)";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                cmd1.Parameters.AddWithValue("@number", txtStudentNumber.contentTextField.Text);
                cmd1.Parameters.AddWithValue("@first", txtFirstName.contentTextField.Text);
                cmd1.Parameters.AddWithValue("@last", txtLastName.contentTextField.Text);
                cmd1.Parameters.AddWithValue("@email", txtEmail.contentTextField.Text);
                cmd1.Parameters.AddWithValue("@phone", txtPhone.contentTextField.Text);
                cmd1.Parameters.AddWithValue("@dob", dtpDOB.Content);
                cmd1.Parameters.AddWithValue("@gender", cmbGender.SelectedItem);
                cmd1.Parameters.AddWithValue("@address", txtAddress.contentTextField.Text);
                cmd1.Parameters.AddWithValue("@username", Usernametxt.contentTextField.Text);
                cmd1.Parameters.AddWithValue("@password", passwordtxt.contentTextField.Text);
                cmd1.Parameters.AddWithValue("@faculty", faculty.SelectedItem);
                cmd1.Parameters.AddWithValue("@department", department.SelectedItem);
                cmd1.Parameters.AddWithValue("@program", programcmbbox.SelectedItem);
                cmd1.Parameters.AddWithValue("@program_duration", programdurationcmbbox.SelectedItem);
                using (MemoryStream ms = new MemoryStream())
                {
                    PictureBox1.BackgroundImage.Save(ms, PictureBox1.BackgroundImage.RawFormat);
                    cmd1.Parameters.AddWithValue("@passport", ms.ToArray());
                }

                string name1 = txtFirstName.contentTextField.Text;
                string name2 = txtLastName.contentTextField.Text;
                string pattern = @"^[A-Za-z\s'-]+$";


                string num = txtPhone.contentTextField.Text;
                string pattern2 = @"^0\d{10}$";

                string stdid = txtStudentNumber.contentTextField.Text;
                string pattern3 = @"^20\d{2}[-/]\d{2}[A-Za-z]{2}\d{3}$";

                string email = txtEmail.contentTextField.Text;
                string emailpattern = @"^[A-Za-z0-9]+@[A-Za-z]+\.[A-Za-z]{2,}$";

                if (string.IsNullOrEmpty(txtFirstName.contentTextField.Text))
                {
                    MessageBox.Show("Input your Firstname!", req);
                }
                else if (!Regex.IsMatch(name1, pattern))
                {
                    MessageBox.Show("Firstname can only contain letters!", req);
                }
                else if (string.IsNullOrEmpty(txtLastName.contentTextField.Text))
                {
                    MessageBox.Show("Input your Lastname!", req);
                }
                else if (!Regex.IsMatch(name2, pattern))
                {
                    MessageBox.Show("Lastname can only contain letters!", req);
                }
                else if (string.IsNullOrEmpty(cmbGender.SelectedItem))
                {
                    MessageBox.Show("Choose a Gender!", req);
                }
                else if (dtpDOB.Content >= DateTime.Today)
                {
                    MessageBox.Show("Don't choose a Date in the future", errorr);
                }

                else if (string.IsNullOrEmpty(txtStudentNumber.contentTextField.Text))
                {
                    MessageBox.Show("Input your Student ID!", req);
                }
                else if (!Regex.IsMatch(stdid, pattern3))
                {
                    MessageBox.Show("Enter a valid Student ID", req);
                }
                else if (string.IsNullOrEmpty(faculty.SelectedItem))
                {
                    MessageBox.Show("Select a Faculty!", req);
                }
                else if (string.IsNullOrEmpty(department.SelectedItem))
                {
                    MessageBox.Show("Select a Department!", req);
                }
                else if (string.IsNullOrEmpty(programcmbbox.SelectedItem))
                {
                    MessageBox.Show("Select a program!", req);
                }
                else if (string.IsNullOrEmpty(programdurationcmbbox.SelectedItem))
                {
                    MessageBox.Show("Choose the program duration!", req);
                }
                else if (string.IsNullOrEmpty(txtEmail.contentTextField.Text)
                    || (!Regex.IsMatch(email, emailpattern)))
                {
                    MessageBox.Show("Input a valid email!", req);
                }
                else if (string.IsNullOrEmpty(txtPhone.contentTextField.Text)
                    || (!Regex.IsMatch(num, pattern2)))
                {
                    MessageBox.Show("Input a valid phone number!", req);
                }
                else if (string.IsNullOrEmpty(txtAddress.contentTextField.Text))
                {
                    MessageBox.Show("Input an Address!", req);
                }
                else if (passportImported == false)
                {
                    MessageBox.Show("Import a Passport", req);
                }
                else if (string.IsNullOrEmpty(Usernametxt.contentTextField.Text)
                    || (!Regex.IsMatch(name1, pattern)))
                {
                    MessageBox.Show("Create a Username!", req);
                }
                else if (string.IsNullOrEmpty(passwordtxt.contentTextField.Text))
                {
                    MessageBox.Show("Create a password!", req);
                }
                else
                {
                    string correctedID = stdid.ToUpper();
                    string emailcorrected = email.ToLower();
                    txtStudentNumber.contentTextField.Text = correctedID;
                    txtEmail.contentTextField.Text = emailcorrected;
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show($"Student added successfully! Your Password is: {passwordtxt.contentTextField.Text}", succ);
                    LoadStudents();
                    this.Close();
                }
            }
        }

        private void dtpDOB_MouseHover(object sender, EventArgs e)
        {
            doblabel.BackColor = Color.WhiteSmoke;
        }

        private void dtpDOB_MouseLeave(object sender, EventArgs e)
        {
            doblabel.BackColor = Color.White;
        }

        private void doblabel_Click(object sender, EventArgs e)
        {
            dtpDOB.Focus();
        }
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
