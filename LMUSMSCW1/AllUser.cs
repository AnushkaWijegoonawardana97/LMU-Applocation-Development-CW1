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
    public partial class AllUser : Form
    {
        // Database Connection
        SqlConnection dbConnection;
        SqlCommand dbCommand;
        SqlDataAdapter dbDataAdapter;

        // Setting Public DataSets
        public static string GlobalUserID;

        public AllUser()
        {
            InitializeComponent();
            HideErrorMeaages();
            ClearUserInputs();

            // Creating the ListView
            UserDashboard_ALU_ListView_MLV.Columns.Add("Id", 50);
            UserDashboard_ALU_ListView_MLV.Columns.Add("Username", 200, HorizontalAlignment.Center);
            UserDashboard_ALU_ListView_MLV.Columns.Add("Name", 200, HorizontalAlignment.Center);
            UserDashboard_ALU_ListView_MLV.Columns.Add("Access Level", 200, HorizontalAlignment.Center);
            UserDashboard_ALU_ListView_MLV.Columns.Add("User Confirmed", 200, HorizontalAlignment.Center);
            UserDashboard_ALU_ListView_MLV.View = View.Details;

            LoadDataToListView();
        }

        // Load User Data To The List View
        public void LoadDataToListView()
        {
            UserDashboard_ALU_ListView_MLV.Items.Clear();


            // Select All the Data From DB
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("Select Id, Username, Name, AccessLeve, UserConfirmed from Userprofiles", dbConnection);
            dbDataAdapter = new SqlDataAdapter(dbCommand);
            DataSet UserDataSet = new DataSet();
            dbDataAdapter.Fill(UserDataSet, "testTabel");
            dbConnection.Close();

            DataTable UserDataTabel = UserDataSet.Tables["testTabel"];
            int i;
            for (i = 0; i <= UserDataTabel.Rows.Count - 1; i++)
            {
                UserDashboard_ALU_ListView_MLV.Items.Add(UserDataTabel.Rows[i].ItemArray[0].ToString());
                UserDashboard_ALU_ListView_MLV.Items[i].SubItems.Add(UserDataTabel.Rows[i].ItemArray[1].ToString());
                UserDashboard_ALU_ListView_MLV.Items[i].SubItems.Add(UserDataTabel.Rows[i].ItemArray[2].ToString());
                UserDashboard_ALU_ListView_MLV.Items[i].SubItems.Add(UserDataTabel.Rows[i].ItemArray[3].ToString());
                UserDashboard_ALU_ListView_MLV.Items[i].SubItems.Add(UserDataTabel.Rows[i].ItemArray[4].ToString());
            }
        }

        // Hide Erro Messages
        public void HideErrorMeaages()
        {
            UserDashboard_ALU_NameError.Hide();
            UserDashboard_ALU_UsernameError.Hide();
            UserDashboard_ALU_UsernameTkError.Hide();
            UserDashboard_ALU_AccessLevelError.Hide();
        }

        // Clear User Inputs
        public void ClearUserInputs()
        {
            UserDashboard_ALU_Name_MTB.Text = "";
            UserDashboard_ALU_UserName_MTB.Text = "";
            UserDashboard_ALU_AccessLevel_MTB.SelectedIndex = 0;
        }

        private void UserDashboard_ALU_ListView_MLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserDashboard_ALU_ListView_MLV.SelectedItems.Count == 0)
                return;
            ListViewItem item = UserDashboard_ALU_ListView_MLV.SelectedItems[0];

            // Setting the Selected Data On Input Fields
            GlobalUserID = item.SubItems[0].Text;
            UserDashboard_ALU_Name_MTB.Text = item.SubItems[1].Text;
            UserDashboard_ALU_UserName_MTB.Text = item.SubItems[2].Text;
            switch (item.SubItems[3].Text)
            {
                case "Admin":
                    UserDashboard_ALU_AccessLevel_MTB.SelectedIndex = 0;
                    break;
                case "Staff":
                    UserDashboard_ALU_AccessLevel_MTB.SelectedIndex = 1;
                    break;
                default:
                    break;
            }
        }

        private void UserDashboard_ALU_SaveBtn_MB_Click(object sender, EventArgs e)
        {
            HideErrorMeaages();

            // Get User Input Values
            String name = UserDashboard_ALU_Name_MTB.Text;
            String username =  UserDashboard_ALU_UserName_MTB.Text;
            String useracces = UserDashboard_ALU_AccessLevel_MTB.SelectedItem.ToString();

            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();

            // Update Class Details
            dbCommand = new SqlCommand("update Userprofiles set Username=@b, Name=@c, AccessLeve=@d where Id=@a", dbConnection);
            dbCommand.Parameters.AddWithValue("@a", GlobalUserID);
            dbCommand.Parameters.AddWithValue("@b", name);
            dbCommand.Parameters.AddWithValue("@c", username);
            dbCommand.Parameters.AddWithValue("@d", useracces);
            dbCommand.ExecuteNonQuery();
            dbConnection.Close();
            UserDashboard_ALU_Success.Text = "Successfull Updated the User details";
            UserDashboard_ALU_Success.Show();
            ClearUserInputs();
            LoadDataToListView();
        }
    }
}
