using System;
using System.Windows.Forms;

namespace LMUSMSCW1
{
    public partial class ClassDashboard : Form
    {
        public ClassDashboard()
        {
            InitializeComponent();
        }

        private void ClassDashboard_Close_PB_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ClassDashboard_Dashboard_MLB_Click(object sender, EventArgs e)
        {
            AdminDashboard newAdminDashboard = new AdminDashboard();
            newAdminDashboard.Show();
            this.Hide();
        }

        private void ClassDashboard_Logout_MLB_Click(object sender, EventArgs e)
        {
            LoginForm objLoginForm = new LoginForm();
            objLoginForm.Show();
            this.Hide();
        }

        private void ClassDashboard_ScD_MLB_Click(object sender, EventArgs e)
        {
            SchoolDashboard objSchoolDashboard = new SchoolDashboard();
            objSchoolDashboard.Show();
            this.Hide();
        }

        private void ClassDashboard_CD_MLB_Click(object sender, EventArgs e)
        {
            ClassDashboard objClassDashboard = new ClassDashboard();
            objClassDashboard.Show();
            this.Hide();
        }

        private void ClassDashboard_Logout_MLB_Click_1(object sender, EventArgs e)
        {
            LoginForm objLoginForm = new LoginForm();
            objLoginForm.Show();
            this.Hide();
        }
    }
}
