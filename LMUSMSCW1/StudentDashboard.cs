using System.Windows.Forms;

namespace LMUSMSCW1
{
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void StudentDashboard_ScD_MLB_Click(object sender, System.EventArgs e)
        {
            SchoolDashboard objSchoolDashboard = new SchoolDashboard();
            objSchoolDashboard.Show();
            this.Hide();
        }
    }
}
