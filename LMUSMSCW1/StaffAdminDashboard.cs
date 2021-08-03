using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMUSMSCW1
{
    public partial class StaffAdminDashboard : Form
    {
        public StaffAdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_ScD_MLB_Click(object sender, EventArgs e)
        {
            MappSubjects objMappSubjects = new MappSubjects();
            objMappSubjects.Show();
            this.Hide();
        }

        private void AdminDashboard_CD_MLB_Click(object sender, EventArgs e)
        {
            MapStudents objMapStudents = new MapStudents();
            objMapStudents.Show();
            this.Hide();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            ExamResults objExamResults = new ExamResults();
            objExamResults.Show();
            this.Hide();
        }

        private void AdminDashboard_Logout_MLB_Click(object sender, EventArgs e)
        {
            LoginForm objLoginForm = new LoginForm();
            objLoginForm.Show();
            this.Hide();
        }

        private void AdminDashboard_Settings_MLB_Click(object sender, EventArgs e)
        {
            StaffProfileSettings objStaffProfileSettings = new StaffProfileSettings();
            objStaffProfileSettings.Show();
            this.Hide();
        }
    }
}
