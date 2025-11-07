using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Student_Management_System
{
    public partial class accountsettingcontrol : UserControl
    {
        public accountsettingcontrol()
        {
            InitializeComponent();
        }
        public void LoadUserData(string firstName, string lastName, string gender, string dob, string username, string password, string email, string phone, string address, string stdnumber, string faculty, string department)
        {
            firstnamelbltxt.Text = firstName;
            lastnamelbltxt.Text = lastName;
            genderlbltxt.Text = gender;
            DateTime dobDate = DateTime.Parse(dob);
            doblbltxt.Text = dobDate.ToString("dd/MM/yyyy");
            usernamelbltxt.Text = username;
            passwordlbltxt.Text = password;
            emaillbltxt.Text = email;
            phonelbltxt.Text = phone;
            addresslbltxt.Text = address;
            stdlbltxt.Text = stdnumber;
            facultylbltxt.Text = faculty;
            departmentlbltxt.Text = department;
            TextInfo genss = CultureInfo.CurrentCulture.TextInfo;
            genderlbltxt.Text = genss.ToTitleCase(genderlbltxt.Text.ToLower());
        }

        private void GIpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
