using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LMUSMSCW1
{
    public partial class CreateUser : Form
    {
        // Database Connection
        SqlConnection dbConnection;
        SqlCommand dbCommand;
        SqlDataAdapter dbDataAdapter;

        public CreateUser()
        {
            InitializeComponent();
            hideErrorMzg();
            UserDashboard_CU_AccessLevel_MTB.SelectedIndex = 0;
        }

        // Create User Function
        private void UserDashboard_CU_SaveBtn_MB_Click(object sender, EventArgs e)
        {
            // Get User Inputs
            String name = UserDashboard_CU_Name_MTB.Text;
            String username = UserDashboard_CU_UserName_MTB.Text;
            String password = UserDashboard_CU_Password_MTB.Text;
            String accesslevel = UserDashboard_CU_AccessLevel_MTB.SelectedItem.ToString();
            String userconfirmed = "unconfirmed";

            // Input Validation
            if (name == "")
            {
                UserDashboard_CU_NameError.Show();
            }
            if (username == "")
            {
                UserDashboard_CU_UsernameError.Show();
            }
            if (password == "")
            {
                UserDashboard_CU_PasswordError.Show();
            }
            if (accesslevel == "")
            {
                UserDashboard_CU_AccessLevelError.Show();
            }

            // Database Connection & Logic
            if (name != "" && username != "" && password != "" && accesslevel != "")
            {
                hideErrorMzg();
                dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
                dbConnection.Open();

                // Check wether user name already exsists
                dbCommand = new SqlCommand("Select count(*) from Userprofiles where Username = @a", dbConnection);
                dbCommand.Parameters.AddWithValue("@a", username);
                int results = Convert.ToInt32(dbCommand.ExecuteScalar());
                if(results != 0) 
                {
                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                    UserDashboard_CU_UsernameTkError.Show();
                } else
                {
                    dbCommand = new SqlCommand("insert into Userprofiles(Username, Name, Password, AccessLeve, UserConfirmed) values (@a, @b, @c, @d, @e)", dbConnection);
                    dbCommand.Parameters.AddWithValue("@a", username);
                    dbCommand.Parameters.AddWithValue("@b", name);
                    dbCommand.Parameters.AddWithValue("@c", password);
                    dbCommand.Parameters.AddWithValue("@d", accesslevel);
                    dbCommand.Parameters.AddWithValue("@e", userconfirmed);
                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                    clearInputFields();
                    UserDashboard_CU_Success.Show();
                }
            }
        }


        // Hide Error Message Comman Function
        public void hideErrorMzg()
        {
            UserDashboard_CU_NameError.Hide();
            UserDashboard_CU_UsernameError.Hide();
            UserDashboard_CU_PasswordError.Hide();
            UserDashboard_CU_AccessLevelError.Hide();
            UserDashboard_CU_Success.Hide();
            UserDashboard_CU_UsernameTkError.Hide();
        }

        // Clear Input Fields
        public void clearInputFields()
        {
            UserDashboard_CU_Name_MTB.Text = "";
            UserDashboard_CU_UserName_MTB.Text = "";
            UserDashboard_CU_Password_MTB.Text = "";
            UserDashboard_CU_AccessLevel_MTB.SelectedIndex = 0;
        }

        // Rest Input Field Button
        private void UserDashboard_CU_RestBtn_MB_Click(object sender, EventArgs e)
        {
            clearInputFields();
            hideErrorMzg();
        }

        // Creating the Username form the Full Name Input
        private void onFullNameChange(object sender, EventArgs e)
        {
            String fullname = UserDashboard_CU_Name_MTB.Text.Replace(" ", String.Empty);
            if(fullname.Length > 8)
            {
                fullname = fullname.Substring(0, 8);
            }

            // Setting the Username
            UserDashboard_CU_UserName_MTB.Text = "EPU" + fullname;

            // Setting the Password
            UserDashboard_CU_Password_MTB.Text = "EPPW" + fullname;
        }
    }
}
