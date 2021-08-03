using System;
using System.Windows.Forms;

namespace LMUSMSCW1
{
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        // School Dashboar Button
        private void UserDasboard_ScD_MLB_Click(object sender, EventArgs e)
        {
            SchoolDashboard objSchoolDashboard = new SchoolDashboard();
            objSchoolDashboard.Show();
            this.Hide();
        }

        // Class Dashboard Button
        private void UserDasboard_CD_MLB_Click(object sender, EventArgs e)
        {
            ClassDashboard objClassDashboard = new ClassDashboard();
            objClassDashboard.Show();
            this.Hide();
        }

        // Student Dashboard Button
        private void UserDasboard_StuD_MLB_Click(object sender, EventArgs e)
        {
            StudentDashboard objStudentDashboard = new StudentDashboard();
            objStudentDashboard.Show();
            this.Hide();
        }

        // Staff Dashboard Button
        private void UserDasboard_StfD_MLB_Click(object sender, EventArgs e)
        {
            StaffDashboard objStaffDashboard = new StaffDashboard();
            objStaffDashboard.Show();
            this.Hide();
        }


        // Subject Dashboard Button
        private void UserDasboard_SubD_MLB_Click(object sender, EventArgs e)
        {
            SubjectDashboard objSubjectDashboard = new SubjectDashboard();
            objSubjectDashboard.Show();
            this.Hide();
        }

        // User Dashboard Button
        private void UserDasboard_UD_MLB_Click(object sender, EventArgs e)
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


        // Settings Dashboard Button
        private void UserDasboard_Settings_MLB_Click(object sender, EventArgs e)
        {
            SettingsDashboard objSettingDashboard = new SettingsDashboard();
            objSettingDashboard.Show();
            this.Hide();
        }

        // User Daboard Logout Button Function
        private void UserDasboard_Logout_MLB_Click(object sender, EventArgs e)
        {
            LoginForm objLoginForm = new LoginForm();
            objLoginForm.Show();
            this.Hide();
        }

        // User Dashboard Create User View Button Function
        private void UserDasboard_CU_MLB_Click(object sender, EventArgs e)
        {
            CreateUser objCreateUser = new CreateUser();
            objCreateUser.TopLevel = false;
            objCreateUser.FormBorderStyle = FormBorderStyle.None;
            objCreateUser.Dock = DockStyle.Fill;
            this.UserDashboard_FormPanle_P.Controls.Add(objCreateUser);
            this.UserDashboard_FormPanle_P.Tag = objCreateUser;
            objCreateUser.BringToFront();
            objCreateUser.Show();
        }

        // User Dashboard All Usr View Button Function
        private void UserDasboard_AU_MLB_Click(object sender, EventArgs e)
        {
            AllUser objAllUser = new AllUser();
            objAllUser.TopLevel = false;
            objAllUser.FormBorderStyle = FormBorderStyle.None;
            objAllUser.Dock = DockStyle.Fill;
            this.UserDashboard_FormPanle_P.Controls.Add(objAllUser);
            this.UserDashboard_FormPanle_P.Tag = objAllUser;
            objAllUser.BringToFront();
            objAllUser.Show();
        }


        // Back to admin dashoard button
        private void materialButton1_Click(object sender, EventArgs e)
        {
            AdminDashboard objAdminDashboard = new AdminDashboard();
            objAdminDashboard.Hide();
            this.Show();
        }
    }
}
