using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LMUSMSCW1
{
    public partial class RestPassword : Form
    {
        // Database Connection
        SqlConnection dbConnection;
        SqlCommand dbCommand;

        public RestPassword()
        {
            InitializeComponent();
        }

        // On Form Load Function
        private void OnForgetPWFormLoad(object sender, EventArgs e)
        {
            HideErrorMeaasges();
            FP_WelcomeText_ML.Text = "Welcome " + LoginForm.GlobalUserName + ",";
        }

        // Update Button Click Function
        private void FP_Update_MB_Click(object sender, EventArgs e)
        {
            HideErrorMeaasges();

            // Get User Input Data
            String newpassword = FP_NewPassword_MTB.Text;
            String confirmnewpassword = FP_ConfirmPassword_MTB.Text;

            // INput Filed Validation
            if(newpassword == "")
            {
                FP_NewPassword_Error_ML.Show();
            }
            if(confirmnewpassword == "") {
                FP_ConfirmPassword_Error_ML.Show();
            }

            // New Password Validation
            if(newpassword != "" && confirmnewpassword != "")
            {
                if (newpassword == confirmnewpassword)
                {
                    // Updating the Database
                    dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
                    dbConnection.Open();
                    dbCommand = new SqlCommand("update Userprofiles set Password=@b where Username=@a", dbConnection);
                    dbCommand.Parameters.AddWithValue("@a", LoginForm.GlobalUserName);
                    dbCommand.Parameters.AddWithValue("@b", newpassword);
                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();

                    // Loading the login screen
                    LoginForm objLogin = new LoginForm();
                    objLogin.Show();
                    this.Hide();
                }
                else
                {
                    FP_ConfirmPassword_Error_ML.Text = "Confirm password didn't match with nee password";
                    FP_ConfirmPassword_Error_ML.Show();
                }
            }
        }

        // Rest Button Click
        private void FP_Rest_MTB_Click(object sender, EventArgs e)
        {
            ClearUserInputs();
        }

        // Back to login form button click
        private void FB_BackLogin_MB_Click(object sender, EventArgs e)
        {
            LoginForm objLoginForm = new LoginForm();
            objLoginForm.Show();
            this.Hide();
        }

        // Hide Error Messages
        public void HideErrorMeaasges()
        {
            FP_NewPassword_Error_ML.Hide();
            FP_ConfirmPassword_Error_ML.Hide();
        }

        // Clear user Inputs
        public void ClearUserInputs()
        {
            FP_NewPassword_MTB.Text = "";
            FP_ConfirmPassword_MTB.Text = "";
        }
    }
}
