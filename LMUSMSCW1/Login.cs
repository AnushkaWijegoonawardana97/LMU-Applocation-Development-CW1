using MaterialSkin;
using System;
using System.Windows.Forms;

namespace LMUSMSCW1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
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

        private void Login_Close_PB_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Login_Login_MB_Click(object sender, EventArgs e)
        {
            AdminDashboard newAdminDashboard = new AdminDashboard();
            newAdminDashboard.Show();
            this.Hide();
        }
    }
}
