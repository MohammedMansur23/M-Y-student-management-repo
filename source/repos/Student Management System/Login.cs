using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Student_Management_System
{

    public partial class Login : Form
    {
        string errorr = "⚠ Error!";
        string req = "⚠️ Required!";
        string succ = "✅ Success!";
        string inf = "⚠️ Information!";
        private void Login_Load(object sender, EventArgs e)
        {
        }
        public Login()
        {
            InitializeComponent();
            //ResizeButton();
        }
        /*private void ResizeButton()
        {

            LoginPanel.Width = (int)(LoginPagePanel.Width * 0.4);

        }*/
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
        private void UserName_Leave(object sender, EventArgs e)
        {
            TextInfo names1 = CultureInfo.CurrentCulture.TextInfo;
            UserName.Text = names1.ToTitleCase(UserName.Text.ToLower());
        }

        private void userLogin()
        {
            Database db = new Database();
            using (var conn = db.GetConnection())
            {
                conn.Open();
                string sql = "SELECT passport, student_number, faculty, department, first_name, last_name, email, phone, dob, gender, username, password, address FROM students " + 
                    "WHERE username = @username AND password = @password";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", UserName.Text);
                    cmd.Parameters.AddWithValue("@number", UserName.Text);
                    cmd.Parameters.AddWithValue("@password", password.Text);

                    if (string.IsNullOrEmpty(UserName.Text) || (string.IsNullOrEmpty(password.Text)))
                    {
                        MessageBox.Show("Fill in the required field!", req);
                    }
                    if (!string.IsNullOrEmpty(UserName.Text) && (!string.IsNullOrEmpty(password.Text)))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            Image passportImage = null;
                            if (!(reader["passport"] is DBNull))
                            {
                                byte[] imgBytes = (byte[])reader["passport"];
                                using (var ms = new System.IO.MemoryStream(imgBytes))
                                {
                                    passportImage = Image.FromStream(ms);
                                }
                            }
                            string stdnu = reader["student_number"].ToString();
                            string fac = reader["faculty"].ToString();
                            string dept = reader["department"].ToString();
                            string name = reader["first_name"].ToString();
                            string last = reader["last_name"].ToString();
                            string mail = reader["email"].ToString();
                            string phon = reader["phone"].ToString();
                            string date = reader["dob"].ToString();
                            string gen = reader["gender"].ToString();
                            string user = reader["username"].ToString();
                            string pass = reader["password"].ToString();
                            string addr = reader["address"].ToString();
                            MessageBox.Show($"Login Successful! Welcome, {UserName.Text}", succ);
                            this.Hide();
                            UserName.Clear();
                            password.Clear();
                            Dashboard dash = new Dashboard(passportImage, stdnu, fac, dept, name, last, mail, phon, date, gen, user, pass, addr);
                            dash.FormClosed += (s, args) =>
                            {
                                this.Show();
                            };
                            dash.Show();

                        }
                        else
                        {
                            MessageBox.Show("Invalid Username or Password!", errorr);
                        }
                    }
                }
            }
        }

        private void usernamepanel_Click(object sender, EventArgs e)
        {
            UserName.Focus();
        }

        private void passwordpanel_Click(object sender, EventArgs e)
        {
            password.Focus();
        }
        private void Loginbtn_Click(object sender, EventArgs e)
        {
            userLogin();
        }

        public class Database
        {
            private string connectionString = "Server=localhost;Database=sms_db;Uid=root;Pwd='';";

            public MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }
        }
        private void forgotpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact the admin.", inf);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            using (Register1 Register1 = new Register1())
            {
                Register1.ShowDialog(); // Modal = blocks until closed 
            }
            this.Show();
        }

        private void Loginbtn_MouseEnter(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserName.Text) || string.IsNullOrEmpty(password.Text))
            {
                Cursor = Cursors.No;
            }
            else if (!string.IsNullOrEmpty(UserName.Text) && !string.IsNullOrEmpty(password.Text))
            {
                Cursor = Cursors.Hand;
            }
        }

        private void Loginbtn_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
