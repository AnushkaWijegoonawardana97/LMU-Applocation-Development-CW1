using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LMUSMSCW1
{
    public partial class OnLoading : Form
    {
        // Database Connection
        SqlConnection dbConnection;
        SqlCommand dbCommand;
        SqlDataAdapter dbDataAdapter;

        public OnLoading()
        {
            InitializeComponent();
            OnWindowLoad();
        }

        // Setting Userdetails from Database
        public static string oldname;
        public static string oldusername;

        // Hide Error Messages
        public void HideErroMessages()
        {
            OnLoading_Name_Error_ML.Hide();
            OnLoading_Username_Error_ML.Hide();
            OnLoading_NewPassword_Error_ML.Hide();
            OnLoading_ConfirmPassword_Error_ML.Hide();
            OnLoading_Success.Hide();
        }

        // Data On Loading
        public void OnWindowLoad()
        {
            HideErroMessages();

            // Fetching the Date Related to the User
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("select Username, Name from Userprofiles where ID=@a", dbConnection);
            dbCommand.Parameters.AddWithValue("@a", LoginForm.GlobalUserID);
            dbDataAdapter = new SqlDataAdapter(dbCommand);
            DataTable dataTabel = new DataTable();
            dbDataAdapter.Fill(dataTabel);
            dbCommand.ExecuteNonQuery();
            dbConnection.Close();

            foreach (DataRow row in dataTabel.Rows)
            {
                // Setting the welcome user text
                OnLoading_Username_ML.Text = "Welcome " + (String)row.ItemArray[1] + ",";

                // Setting the Name to Name Text Filed
                OnLoding_Name_MTB.Text = (String)row.ItemArray[1];
                oldname = (String)row.ItemArray[1];

                // Setting the Username to Username Text Field
                OnLoding_Username_MTB.Text = (String)row.ItemArray[0];
                oldusername = (String)row.ItemArray[0];
            }
        }

        private void OnLoading_Update_MB_Click(object sender, EventArgs e)
        {
            HideErroMessages();

            // Getting Data From Input Fields
            String obname = OnLoding_Name_MTB.Text;
            String obusername = OnLoding_Username_MTB.Text;
            String obnewpassword = OnLoading_NewPassword_MTB.Text;
            String obconfirmpassword = OnLoading_ConfirmPassword_MTB.Text;

            // Validating the User Inputs
            if (obnewpassword == "")
            {
                OnLoading_NewPassword_Error_ML.Show();
            }
            if (obconfirmpassword == "")
            {
                OnLoading_ConfirmPassword_Error_ML.Show();
            }

            // Check Wether New Passeord Match With the Confirm Password
            if(obnewpassword == obconfirmpassword)
            {
                // Check Wether username  is changed
                if(oldusername == obusername)
                {
                    // Updating the Database
                    dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
                    dbConnection.Open();
                    dbCommand = new SqlCommand("update Userprofiles set Name=@b, Password=@c, UserConfirmed=@d where Id=@a", dbConnection);
                    dbCommand.Parameters.AddWithValue("@a", LoginForm.GlobalUserID);
                    dbCommand.Parameters.AddWithValue("@b", obname);
                    dbCommand.Parameters.AddWithValue("@c", obnewpassword);
                    dbCommand.Parameters.AddWithValue("@d", "confirmed");
                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                    OnLoading_Success.Show();

                    // Loading the login screen
                    LoginForm objLogin = new LoginForm();
                    objLogin.Show();
                    this.Hide();
                } else
                {
                    dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
                    dbConnection.Open();

                    // Check wether user name already exsists
                    dbCommand = new SqlCommand("Select count(*) from Userprofiles where Username = @a", dbConnection);
                    dbCommand.Parameters.AddWithValue("@a", obusername);
                    int results = Convert.ToInt32(dbCommand.ExecuteScalar());

                    if (results != 0)
                    {
                        dbCommand.ExecuteNonQuery();
                        dbConnection.Close();
                        OnLoading_Username_Error_ML.Text = "Username already exsists. enter new one";
                        OnLoading_Username_Error_ML.Show();
                    }
                    else
                    {
                        dbCommand = new SqlCommand("update Userprofiles set Name=@b, Password=@c, UserConfirmed=@d, Username=@e where Id=@a", dbConnection);
                        dbCommand.Parameters.AddWithValue("@a", LoginForm.GlobalUserID);
                        dbCommand.Parameters.AddWithValue("@b", obname);
                        dbCommand.Parameters.AddWithValue("@c", obnewpassword);
                        dbCommand.Parameters.AddWithValue("@d", "confirmed");
                        dbCommand.Parameters.AddWithValue("@e", obusername);
                        dbCommand.ExecuteNonQuery();
                        dbConnection.Close();
                        OnLoading_Success.Show();

                        // Loading the login screen
                        LoginForm objLogin = new LoginForm();
                        objLogin.Show();
                        this.Hide();
                    }
                }
            } else
            {
                OnLoading_ConfirmPassword_Error_ML.Text = "Your confirm password didn't match with new password";
                OnLoading_ConfirmPassword_Error_ML.Show();
            }
        }

        private void OnLoading_Reset_MTB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rest");
        }

        public void ClearUserInputs()
        {
            OnLoading_NewPassword_MTB.Text = "";
            OnLoading_ConfirmPassword_MTB.Text = "";
        }
    }
}
