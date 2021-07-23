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

        // User Dashboard Close System Buttton
        private void UserDasboard_Close_PB_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void UserDasboard_ScD_MLB_Click(object sender, EventArgs e)
        {

        }

        private void UserDasboard_CD_MLB_Click(object sender, EventArgs e)
        {

        }

        private void UserDasboard_StuD_MLB_Click(object sender, EventArgs e)
        {

        }

        private void UserDasboard_StfD_MLB_Click(object sender, EventArgs e)
        {

        }

        private void UserDasboard_SubD_MLB_Click(object sender, EventArgs e)
        {

        }

        private void UserDasboard_UD_MLB_Click(object sender, EventArgs e)
        {

        }

        private void UserDasboard_Settings_MLB_Click(object sender, EventArgs e)
        {

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
    }
}
