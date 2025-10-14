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


        public Dashboard()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
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
            string gen, string user, string pass, string addr)
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
            welcomelabel.Text = $"Welcome, {fName} {lName}";
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log Out Successful!", "Logout");
            this.Close();
        }
    }
}
