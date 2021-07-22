using System;
using System.Windows.Forms;

namespace LMUSMSCW1
{
    public partial class SchoolDashboard : Form
    {
        public SchoolDashboard()
        {
            InitializeComponent();
        }

        private void SchoolDashbaord_Close_PB_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void SchoolDashboard_Logout_MLB_Click(object sender, EventArgs e)
        {
            LoginForm objLoginForm = new LoginForm();
            objLoginForm.Show();
            this.Hide();
        }

        private void SchoolDashboard_CD_MLB_Click(object sender, EventArgs e)
        {
            ClassDashboard objClassDashboard = new ClassDashboard();
            objClassDashboard.Show();
            this.Hide();
        }
    }
}
