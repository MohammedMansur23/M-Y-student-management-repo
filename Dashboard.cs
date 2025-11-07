using Org.BouncyCastle.Asn1.Ocsp;
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
    public partial class Dashboard : Form
    {
        private Image passport;
        private string studentID;
        private string faculty;
        private string department;
        private string fName;
        private string lName;
        private string mails;
        private string phones;
        private string dates;
        private string gens;
        private string users;
        private string passes;
        private string addrs;

        private int studentLevel;       // e.g., 100, 200, etc.
        private string studentFaculty;  // e.g., "CIS"
        private string studentNumber;   // e.g., "2023/52CS132"
        public Dashboard()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            accountsettingcontrol.Visible = false;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_NOCLOSE = 0x200;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_NOCLOSE;
                return cp;
            }
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
        public Dashboard(Image passportImage, string id, string fac, string dept,
            string name, string last, string mail, string phon, string date,
            string gen, string user, string pass, string addr, string programType, int programDuration)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            passport = passportImage;
            dashboardPictureBox.Image = passport;
            dashboardPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            studentID = id;
            faculty = fac;
            department = dept;
            fName = name;
            lName = last;
            mails = mail;
            phones = phon;
            dates = date;
            gens = gen;
            users = user;
            passes = pass;
            addrs = addr;
            studentNumber = studentID;
            studentFaculty = faculty;

            welcomelabel.Text = $"Welcome, {fName} {lName}";

            SetStudentLevelAndYear(studentID, programType, programDuration);

            coursemanagementControl1 = new CoursemanagementControl(studentLevel, studentFaculty, studentNumber);
            coursemanagementControl1.Dock = DockStyle.Fill;
            detailspanel.Controls.Add(coursemanagementControl1);
            coursemanagementControl1.Visible = false;

            coursescontrol = new coursescontrol(studentLevel, studentFaculty, studentNumber);
            coursescontrol.Dock = DockStyle.Fill;
            detailspanel.Controls.Add(coursescontrol);
            coursescontrol.Visible = false;
        }

        private void SetStudentLevelAndYear(string studentNumber, string programType, int programDuration)
        {
            int admissionYear = int.Parse(studentNumber.Substring(0, 4));
            int currentYear = DateTime.Now.Year;
            int yearsPassed = currentYear - admissionYear; // number of years since admission
            int currentYearInProgram = yearsPassed + 1;

            string schoolYear = "";
            string level = $" {programType} {department}";

            if (programType == "Bachelor's")
            {
                switch (currentYearInProgram)
                {
                    case 1:
                        schoolYear = "1st Year"; level = $"{programType} {department}"; studentLevel = 100; break;
                    case 2:
                        schoolYear = "2nd Year"; level = $"{programType} {department}"; studentLevel = 200; break;
                    case 3:
                        schoolYear = "3rd Year"; level = $"{programType} {department}"; studentLevel = 300; break;
                    case 4:
                        schoolYear = "4th Year"; level = $"{programType} {department}"; studentLevel = 400; break;
                    default:
                        schoolYear = "Graduated / Not eligible"; level = "N/A"; break;
                }
            }
            else
            {
                // For Postgrad or other programs
                schoolYear = $"{currentYearInProgram} {(currentYearInProgram == 1 ? "Year" : "Years")} in Program";
                level = $" {programType} {department}";
                studentLevel = 100;
            }
            // Assign faculty to the field
            studentFaculty = faculty;

            // Assign to labels
            levellbl.Text = level;
            schoolYearlbl.Text = schoolYear;
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            accountsettingcontrol.Visible = false;
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log Out Successful!", "Logout");
            this.Close();
        }

        private void dashboardPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void dashboardpanelbtn_Click(object sender, EventArgs e)
        {
            clickpanel.Location = new Point(-1, 123);
            dashboardlblbtn.BackColor = clickpanel.BackColor;
            dashboardpanelbtn.BackColor = clickpanel.BackColor;
            dashboardpic.BackColor = clickpanel.BackColor;
            accountsettingcontrol.Visible = false;
            coursemanagementControl1.Visible = false;
            coursescontrol.Visible = false;
        }
        private void coursemanagementpanelbtn_Click(object sender, EventArgs e)
        {
            clickpanel.Location = new Point(-1, 228);
            coursemanagementlblbtn.BackColor = clickpanel.BackColor;
            coursemanagementpanelbtn.BackColor = clickpanel.BackColor;
            coursemanagementpic.BackColor = clickpanel.BackColor;
            accountsettingcontrol.Visible = false;
            coursemanagementControl1.Visible = true;
            coursescontrol.Visible = false;
        }

        private void coursepanelbtn_Click(object sender, EventArgs e)
        {
            clickpanel.Location = new Point(-1, 333);
            courseslblbtn.BackColor = clickpanel.BackColor;
            coursepanelbtn.BackColor = clickpanel.BackColor;
            coursespic.BackColor = clickpanel.BackColor;
            accountsettingcontrol.Visible = false;
            coursemanagementControl1.Visible = false;
            coursescontrol.Visible = true;
            coursescontrol.LoadedCourses();
        }
        private void resultpanelbtn_Click(object sender, EventArgs e)
        {
            clickpanel.Location = new Point(-1, 438);
            resultlblbtn.BackColor = clickpanel.BackColor;
            resultpanelbtn.BackColor = clickpanel.BackColor;
            resultpic.BackColor = clickpanel.BackColor;
            accountsettingcontrol.Visible = false;
            coursemanagementControl1.Visible = false;
            coursescontrol.Visible = false;
        }

        private void accountsettingspanelbtn_Click(object sender, EventArgs e)
        {
            clickpanel.Location = new Point(-1, 543);
            accountsettingslblbtn.BackColor = clickpanel.BackColor;
            accountsettingspanelbtn.BackColor = clickpanel.BackColor;
            accountsettingcontrol.LoadUserData(fName, lName, gens, dates, users, passes, mails, phones, addrs, studentID, faculty, department);
            accountsettingcontrol.Visible = true;
            coursemanagementControl1.Visible = false;
            coursescontrol.Visible = false;
        }



        private void dashboardpanelbtn_MouseEnter(object sender, EventArgs e)
        {
            dashboardlblbtn.BackColor = clickpanel.BackColor;
            dashboardpanelbtn.BackColor = clickpanel.BackColor;
            dashboardpic.BackColor = clickpanel.BackColor;

        }

        private void coursemanagementpanelbtn_MouseEnter(object sender, EventArgs e)
        {
            coursemanagementlblbtn.BackColor = clickpanel.BackColor;
            coursemanagementpanelbtn.BackColor = clickpanel.BackColor;
            coursemanagementpic.BackColor = clickpanel.BackColor;
        }

        private void coursepanelbtn_MouseEnter(object sender, EventArgs e)
        {
            courseslblbtn.BackColor = clickpanel.BackColor;
            coursepanelbtn.BackColor = clickpanel.BackColor;
            coursespic.BackColor = clickpanel.BackColor;
        }

        private void resultpanelbtn_MouseEnter(object sender, EventArgs e)
        {
            resultlblbtn.BackColor = clickpanel.BackColor;
            resultpanelbtn.BackColor = clickpanel.BackColor;
            resultpic.BackColor = clickpanel.BackColor;
        }

        private void accountsettingspanelbtn_MouseEnter(object sender, EventArgs e)
        {
            accountsettingslblbtn.BackColor = clickpanel.BackColor;
            accountsettingspanelbtn.BackColor = clickpanel.BackColor;
            accountpic.BackColor = clickpanel.BackColor;
        }

        private void dashboardpanelbtn_MouseLeave(object sender, EventArgs e)
        {
            dashboardlblbtn.BackColor = menupanel.BackColor;
            dashboardpanelbtn.BackColor = menupanel.BackColor;
            dashboardpic.BackColor = menupanel.BackColor;
        }
        private void coursemanagementpanelbtn_MouseLeave(object sender, EventArgs e)
        {
            coursemanagementlblbtn.BackColor = menupanel.BackColor;
            coursemanagementpanelbtn.BackColor = menupanel.BackColor;
            coursemanagementpic.BackColor = menupanel.BackColor;
        }
        private void coursepanelbtn_MouseLeave(object sender, EventArgs e)
        {
            courseslblbtn.BackColor = menupanel.BackColor;
            coursepanelbtn.BackColor = menupanel.BackColor;
            coursespic.BackColor = menupanel.BackColor;
        }
        private void resultpanelbtn_MouseLeave(object sender, EventArgs e)
        {
            resultlblbtn.BackColor = menupanel.BackColor;
            resultpanelbtn.BackColor = menupanel.BackColor;
            resultpic.BackColor = menupanel.BackColor;
        }

        private void accountsettingspanelbtn_MouseLeave(object sender, EventArgs e)
        {
            accountsettingslblbtn.BackColor = menupanel.BackColor;
            accountsettingspanelbtn.BackColor = menupanel.BackColor;
            accountpic.BackColor = menupanel.BackColor;
        }

        private void mainoverviewpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void coursepanelbtn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
