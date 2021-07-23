using MaterialSkin;
using System;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace LMUSMSCW1
{
    public partial class LoginForm : Form
    {
        // Database Connection
        SqlConnection dbConnection;
        SqlCommand dbCommand;
        SqlDataAdapter dbDataAdapter;

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

            HideErrorMessage();
        }

        // Setting Public DataSets
        public static int GlobalUserID;
        public static string GlobalUserName;



        // Login Button Function
        private void Login_Login_MB_Click(object sender, EventArgs e)
        {
            HideErrorMessage();

            // Getting User Inputs
            String username = Login_Username_MTB.Text;
            String password = Login_Password_MTB.Text;

            // Input Validation
            if(username == "")
            {
                Login_Username_Error_ML.Show();
            }
            if(password ==  "")
            {
                Login_Password_Error_ML.Show();
            }

            // Server Side Validation
            if(username != "" && password !=  "")
            {
                // Database Connection & Data Retrivel
                dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
                dbConnection.Open();
                dbCommand = new SqlCommand("select Id, UserConfirmed, AccessLeve from Userprofiles where Username=@a and Password=@b", dbConnection);
                dbCommand.Parameters.AddWithValue("@a", username);
                dbCommand.Parameters.AddWithValue("@b", password);
                dbDataAdapter = new SqlDataAdapter(dbCommand);
                DataTable dataTabel = new DataTable();
                dbDataAdapter.Fill(dataTabel);
                dbCommand.ExecuteNonQuery();
                dbConnection.Close();

                // Check the Username & passwoard
                if(dataTabel.Rows.Count == 1)
                {
                    foreach(DataRow row in dataTabel.Rows)
                    {
                        // Check the user profile conformation
                        String UserStates = (String)row.ItemArray[1];
                        if(UserStates == "unconfirmed")
                        {
                            GlobalUserID = (int)row.ItemArray[0];
                            OnLoading objOnLoading = new OnLoading();
                            objOnLoading.Show();
                            this.Hide();
                        } else
                        {
                            // Check the users access level
                            String UserAccessLevel = (String)row.ItemArray[2];
                            if(UserAccessLevel  == "Admin")
                            {
                                AdminDashboard newAdminDashboard = new AdminDashboard();
                                newAdminDashboard.Show();
                                this.Hide();
                            } else
                            {
                                StaffAdminDashboard objStaffAdminDB = new StaffAdminDashboard();
                                objStaffAdminDB.Show();
                                this.Hide();
                            }
                            
                        }
                    }
                    
                } else
                {
                    Login_Invalid_ML.Show();
                }
            }

            
        }

        // Forget Password Button Function
        private void Login_FP_MTB_Click(object sender, EventArgs e)
        {
            HideErrorMessage();
            // Getting User Inputs
            String username = Login_Username_MTB.Text;

            if (username == "") 
            {
                Login_Username_Error_ML.Show();
            } else
            {
                // Database Connection & Data Retrivel
                dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
                dbConnection.Open();
                dbCommand = new SqlCommand("select Id from Userprofiles where Username=@a", dbConnection);
                dbCommand.Parameters.AddWithValue("@a", username);
                dbDataAdapter = new SqlDataAdapter(dbCommand);
                DataTable dataTabel = new DataTable();
                dbDataAdapter.Fill(dataTabel);
                dbCommand.ExecuteNonQuery();
                dbConnection.Close();

                // Check Wether Username Exists
                if (dataTabel.Rows.Count == 1)
                {
                    GlobalUserName = username;
                    RestPassword objPasswordRest = new RestPassword();
                    objPasswordRest.Show();
                    this.Hide();
                } else
                {
                    Login_Username_Error_ML.Text = "Username is not register in the system";
                    Login_Username_Error_ML.Show();
                }       
            }
        }

        // Common Hide Error Message Function
        public void HideErrorMessage()
        {
            Login_Username_Error_ML.Hide();
            Login_Password_Error_ML.Hide();
            Login_Invalid_ML.Hide();
;       }
    }
}
