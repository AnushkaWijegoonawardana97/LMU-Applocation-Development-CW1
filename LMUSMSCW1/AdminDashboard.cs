using MaterialSkin;
using System;
using System.Windows.Forms;

namespace LMUSMSCW1
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void AdminDashboard_Logout_MLB_Click(object sender, EventArgs e)
        {
            LoginForm objLoginForm = new LoginForm();
            objLoginForm.Show();
            this.Hide();
        }

        // School Dashboard Button
        private void AdminDashboard_ScD_MLB_Click(object sender, EventArgs e)
        {
            SchoolDashboard objSchoolDashboard = new SchoolDashboard();
            objSchoolDashboard.Show();
            this.Hide();
        }

        // Class Dashboard Button
        private void AdminDashboard_CD_MLB_Click(object sender, EventArgs e)
        {
            ClassDashboard objClassDashboard = new ClassDashboard();
            objClassDashboard.Show();
            this.Hide();
        }

        private void AdminDashboard_UD_MLB_Click(object sender, EventArgs e)
        {
            UserDashboard objUserDashboard = new UserDashboard();
            objUserDashboard.Show();
            this.Hide();
            CreateUser objCreateUser = new CreateUser();
            objCreateUser.TopLevel = false;
            objCreateUser.FormBorderStyle = FormBorderStyle.None;
            objCreateUser.Dock = DockStyle.Fill;
            objUserDashboard.UserDashboard_FormPanle_P.Controls.Add(objCreateUser);
            objUserDashboard.UserDashboard_FormPanle_P.Tag = objCreateUser;
            objCreateUser.BringToFront();
            objCreateUser.Show();
        }

        // Student Dashboard Button
        private void AdminDashboard_StuD_MLB_Click(object sender, EventArgs e)
        {
            StudentDashboard objStudentDashboard = new StudentDashboard();
            objStudentDashboard.Show();
            this.Hide();
        }


        // Staff Dashboard Button
        private void AdminDashboard_StfD_MLB_Click(object sender, EventArgs e)
        {
            StaffDashboard objStaffDashboard = new StaffDashboard();
            objStaffDashboard.Show();
            this.Hide();
        }

        // Subject Dashboard Button
        private void AdminDashboard_SubD_MLB_Click(object sender, EventArgs e)
        {
            SubjectDashboard objSubjectDashboard = new SubjectDashboard();
            objSubjectDashboard.Show();
            this.Hide();
        }

        // Settings Dashboard Button
        private void AdminDashboard_Settings_MLB_Click(object sender, EventArgs e)
        {
            SettingsDashboard objSettingDashboard = new SettingsDashboard();
            objSettingDashboard.Show();
            this.Hide();
        }

        private void AdminDashbaord_Logo_PB_Click(object sender, EventArgs e)
        {

        }

        private void AdminDasboard_Navbar_MC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
