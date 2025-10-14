using MySql.Data.MySqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Transactions;

namespace Student_Management_System
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
        }

        string errorr = "⚠ Error!";
        string req = "⚠️ Required!";
        string succ = "✅ Success!";
        private void Form1_Load(object sender, EventArgs e)
        {
            department.Enabled = false;
            faculty.Items.AddRange(facultyDepartments.Keys.ToArray());
            LoadStudents();
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
                string sql1 = "SELECT  student_number, first_name, last_name, email, phone, dob, username, password, faculty, department FROM students";
                MySqlDataAdapter da = new MySqlDataAdapter(sql1, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }
        }
        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            TextInfo names1 = CultureInfo.CurrentCulture.TextInfo;
            txtFirstName.Text = names1.ToTitleCase(txtFirstName.Text.ToLower());
        }
        private void txtLastName_Leave(object sender, EventArgs e)
        {
            TextInfo names2 = CultureInfo.CurrentCulture.TextInfo;
            txtLastName.Text = names2.ToTitleCase(txtLastName.Text.ToLower());
        }
        private void Usernametxt_Leave(object sender, EventArgs e)
        {
            TextInfo usernames = CultureInfo.CurrentCulture.TextInfo;
            Usernametxt.Text = usernames.ToTitleCase(Usernametxt.Text.ToLower());
        }

        private void txtStudentNumber_Leave(object sender, EventArgs e)
        {
            TextInfo stdidd = CultureInfo.CurrentCulture.TextInfo;
            txtStudentNumber.Text = stdidd.ToTitleCase(txtStudentNumber.Text.ToUpper());
            if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/52"))
            {
                faculty.Text = "Communication and Information Sciences";
                if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/52CS"))
                {
                    department.Text = "Computer Science";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/52IT"))
                {
                    department.Text = "Information Technology";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/52TS"))
                {
                    department.Text = "Telecommunication Science";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/52LS"))
                {
                    department.Text = "Library & Information Science";
                }
                else
                {
                    MessageBox.Show("Input a valid Student number", errorr);
                }
            }
            else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/50"))
            {
                faculty.Text = "Basic Sciences";
                if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/50PH"))
                {
                    department.Text = "Physics";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/50CH"))
                {
                    department.Text = "Chemistry";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/50ST"))
                {
                    department.Text = "Statistics";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/50MA"))
                {
                    department.Text = "Mathematics";
                }
                else
                {
                    MessageBox.Show("Input a valid Student Number");
                }
            }
            else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/48"))
            {
                faculty.Text = "Basic Medical Sciences";
                if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/48AN"))
                {
                    department.Text = "Anatomy";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/48PH"))
                {
                    department.Text = "Physiology";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/48MS"))
                {
                    department.Text = "Medicine and Surgery";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/48ML"))
                {
                    department.Text = "Medical Laboratory Science";
                }
                else
                {
                    MessageBox.Show("Input a valid Student Number", errorr);
                }
            }
            else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/46"))
            {
                faculty.Text = "Arts";
                if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/46EN"))
                {
                    department.Text = "English";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/46RE"))
                {
                    department.Text = "Religion";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/46HI"))
                {
                    department.Text = "History & International Studies";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/46PA"))
                {
                    department.Text = "Performing Arts";
                }
                else
                {
                    MessageBox.Show("Input a valid Student Number", errorr);
                }
            }
            else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/54"))
            {
                faculty.Text = "Education";
                if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/54AE"))
                {
                    department.Text = "Arts Education";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/54EM"))
                {
                    department.Text = "Educational Management";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/54HK"))
                {
                    department.Text = "Human Kinetics Education";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/54CE"))
                {
                    department.Text = "Computer Science Education";
                }
                else
                {
                    MessageBox.Show("Input a valid Student Number", errorr);
                }
            }
            else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/56"))
            {
                faculty.Text = "Engineering and Technology";
                if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/56CE"))
                {
                    department.Text = "Civil Engineering";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/56CP"))
                {
                    department.Text = "Computer Engineering";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/56EE"))
                {
                    department.Text = "Electrical Engineering";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/56ME"))
                {
                    department.Text = "Mechanical Engineering";
                }
                else
                {
                    MessageBox.Show("Input a valid Student Number", errorr);
                }
            }
            else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/58"))
            {
                faculty.Text = "Life Sciences";
                if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/58ZO"))
                {
                    department.Text = "Zoology";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/58MB"))
                {
                    department.Text = "Microbiology";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/58PB"))
                {
                    department.Text = "Plant Biology";
                }
                else if (Regex.IsMatch(txtStudentNumber.Text, @"^20\d{2}/58EB"))
                {
                    department.Text = "Environmental Biology";
                }
                else
                {
                    MessageBox.Show("Enter a valid Student Number", errorr);
                }
            }
            else
            {
                MessageBox.Show("Input an actual Student Number", errorr);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql1 = "INSERT INTO students (passport, student_number, first_name, last_name, email, phone, dob, gender, address, username, password, faculty, department) " +
                             "VALUES (@passport, @number, @first, @last, @email, @phone, @dob, @gender, @address, @username, @password, @faculty, @department)";
                MySqlCommand cmd1 = new MySqlCommand(sql1, conn);
                cmd1.Parameters.AddWithValue("@number", txtStudentNumber.Text);
                cmd1.Parameters.AddWithValue("@first", txtFirstName.Text);
                cmd1.Parameters.AddWithValue("@last", txtLastName.Text);
                cmd1.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd1.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd1.Parameters.AddWithValue("@dob", dtpDOB.Value.Date);
                cmd1.Parameters.AddWithValue("@gender", cmbGender.Text);
                cmd1.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd1.Parameters.AddWithValue("@username", Usernametxt.Text);
                cmd1.Parameters.AddWithValue("@password", passwordtxt.Text);
                cmd1.Parameters.AddWithValue("@faculty", faculty.Text);
                cmd1.Parameters.AddWithValue("@department", department.Text);
                cmd1.Parameters.AddWithValue("@passport", pictureBox1.BackgroundImage);

                string name1 = txtFirstName.Text;
                string name2 = txtLastName.Text;
                string pattern = @"^[A-Za-z\s'-]+$";


                string num = txtPhone.Text;
                string pattern2 = @"^0\d{10}$";

                string stdid = txtStudentNumber.Text;
                string pattern3 = @"^20\d{2}[-/]\d{2}[A-Za-z]{2}\d{3}$";

                string email = txtEmail.Text;
                string emailpattern = @"^[A-Za-z0-9]+@[A-Za-z]+\.[A-Za-z]{2,}$";

                var defaultimage = pictureBox1.BackgroundImage;
                if (string.IsNullOrEmpty(txtStudentNumber.Text))
                {
                    MessageBox.Show("Input your Student ID!", req);
                }
                else if (!Regex.IsMatch(stdid, pattern3))
                {
                    MessageBox.Show("Enter a valid Student ID", req);
                }


                else if (string.IsNullOrEmpty(txtFirstName.Text))
                {
                    MessageBox.Show("Input your Firstname!", req);
                }
                else if (!Regex.IsMatch(name1, pattern))
                {
                    MessageBox.Show("Firstname can only contain letters!", req);
                }


                else if (string.IsNullOrEmpty(txtLastName.Text))
                {
                    MessageBox.Show("Input your Lastname!", req);
                }
                else if (!Regex.IsMatch(name2, pattern))
                {
                    MessageBox.Show("Lastname can only contain letters!", req);
                }


                else if (string.IsNullOrEmpty(txtEmail.Text)
                    || (!Regex.IsMatch(email, emailpattern)))
                {
                    MessageBox.Show("Input a valid email!", req);
                }


                else if (string.IsNullOrEmpty(txtPhone.Text)
                    || (!Regex.IsMatch(num, pattern2)))
                {
                    MessageBox.Show("Input a valid phone number!", req);
                }


                else if (string.IsNullOrEmpty(cmbGender.Text))
                {
                    MessageBox.Show("Choose a Gender!", req);
                }
                else if (string.IsNullOrEmpty(faculty.Text))
                {
                    MessageBox.Show("Select a Faculty!", req);
                }
                else if (string.IsNullOrEmpty(department.Text))
                {
                    MessageBox.Show("Select a Department!", req);
                }
                else if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("Input an Address!", req);
                }
                else if (dtpDOB.Value > DateTime.Today)
                {
                    MessageBox.Show("Don't choose a Date in the future", errorr);
                }
                else if (string.IsNullOrEmpty(Usernametxt.Text)
                    || (!Regex.IsMatch(name1, pattern)))
                {
                    MessageBox.Show("Create a Username!", req);
                }
                else if (string.IsNullOrEmpty(passwordtxt.Text))
                {
                    MessageBox.Show("Create a password!", req);
                }
                
                else if (pictureBox1.BackgroundImage == defaultimage)
                {
                    MessageBox.Show("Import a Passport", req);
                }
                else
                {
                    string correctedID = stdid.ToUpper();
                    string emailcorrected = email.ToLower();
                    txtStudentNumber.Text = correctedID;
                    txtEmail.Text = emailcorrected;
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show($"Student added successfully! Your Password is: {passwordtxt.Text}", succ);
                    LoadStudents();
                    this.Close();
                }


            }
        }

        private void studentnumberpanel_MouseClick(object sender, MouseEventArgs e)
        {
            txtStudentNumber.Focus();
        }

        private void firstnamepanel_Click(object sender, EventArgs e)
        {
            txtFirstName.Focus();
        }

        private void lastnamepanel_Click(object sender, EventArgs e)
        {
            txtLastName.Focus();
        }

        private void emailpanel_Click(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void phonepanel_Click(object sender, EventArgs e)
        {
            txtPhone.Focus();
        }

        private void addresspanel_Click(object sender, EventArgs e)
        {
            txtAddress.Focus();
        }

        private void usernamepanel_Click(object sender, EventArgs e)
        {
            Usernametxt.Focus();
        }

        private void passwordpanel_Click(object sender, EventArgs e)
        {
            passwordtxt.Focus();
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            department.Enabled = true;
            department.Items.Clear();
            string selectedfaculty = faculty.SelectedItem.ToString();

            if (facultyDepartments.ContainsKey(selectedfaculty))
            {
                department.Items.AddRange(facultyDepartments[selectedfaculty].ToArray());
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Passport Photo";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.BackgroundImage = Image.FromFile(ofd.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Optional: fit image nicely
                }
            }
        }
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