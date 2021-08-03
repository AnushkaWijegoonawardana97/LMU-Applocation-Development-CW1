using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMUSMSCW1
{
    public partial class SettingsDashboard : Form
    {
        // Database Connection
        SqlConnection dbConnection;
        SqlCommand dbCommand;
        SqlDataAdapter dbDataAdapter;

        public SettingsDashboard()
        {
            InitializeComponent();
            ClearUserInputs();
            HideErrorMessages();

            SettingsDashboard_ListView_MLV.Columns.Add("Id", 50, HorizontalAlignment.Center);
            SettingsDashboard_ListView_MLV.Columns.Add("Username", 120, HorizontalAlignment.Center);
            SettingsDashboard_ListView_MLV.Columns.Add("Name", 100, HorizontalAlignment.Center);
            SettingsDashboard_ListView_MLV.Columns.Add("Password", 100, HorizontalAlignment.Center);
            SettingsDashboard_ListView_MLV.Columns.Add("AccessLeve", 100, HorizontalAlignment.Center);
            SettingsDashboard_ListView_MLV.Columns.Add("UserConfirmed", 100, HorizontalAlignment.Center);
            SettingsDashboard_ListView_MLV.View = View.Details;

            LoadDataToListView();
        }

        private void SettingsDashbaord_ScD_MLB_Click(object sender, EventArgs e)
        {
            SchoolDashboard objSchoolDashboard = new SchoolDashboard();
            objSchoolDashboard.Show();
            this.Hide();
        }

        private void SettingsDashbaord_CD_MLB_Click(object sender, EventArgs e)
        {
            ClassDashboard objClassDashboard = new ClassDashboard();
            objClassDashboard.Show();
            this.Hide();
        }

        private void SettingsDashbaord_StuD_MLB_Click(object sender, EventArgs e)
        {
            StudentDashboard objStudentDashboard = new StudentDashboard();
            objStudentDashboard.Show();
            this.Hide();
        }

        private void SettingsDashbaord_StfD_MLB_Click(object sender, EventArgs e)
        {
            StaffDashboard objStaffDashboard = new StaffDashboard();
            objStaffDashboard.Show();
            this.Hide();
        }

        private void SettingsDashbaord_SubD_MLB_Click(object sender, EventArgs e)
        {
            SubjectDashboard objSubjectDashboard = new SubjectDashboard();
            objSubjectDashboard.Show();
            this.Hide();
        }

        private void SettingsDashbaord_UD_MLB_Click(object sender, EventArgs e)
        {
            UserDashboard objUserDashboard = new UserDashboard();
            objUserDashboard.Show();
            this.Hide();

            CreateUser objCreateUser = new CreateUser();
            objCreateUser.TopLevel = false;
            objCreateUser.FormBorderStyle = FormBorderStyle.None;
            objCreateUser.Dock = DockStyle.Fill;
            objUserDashboard.UserDashboard_FormPanle_P.Controls.Add(objCreateUser);
            objUserDashboard.UserDashboard_FormPanle_P.Tag = objCreateUser;
            objCreateUser.BringToFront();
            objCreateUser.Show();
        }

        private void SettingsDashbaord_BackTDB_MLB_Click(object sender, EventArgs e)
        {
            AdminDashboard objAdminDashboard = new AdminDashboard();
            objAdminDashboard.Show();
            this.Hide();
        }

        private void SettingsDashbaord_Settings_MLB_Click(object sender, EventArgs e)
        {
            SettingsDashboard objSettingDashboard = new SettingsDashboard();
            objSettingDashboard.Show();
            this.Hide();
        }

        private void SettingsDashbaord_Logout_MLB_Click(object sender, EventArgs e)
        {
            LoginForm objLoginForm = new LoginForm();
            objLoginForm.Show();
            this.Hide();
        }

        // Clear user Inputs
        public void ClearUserInputs()
        {
            SettingsDashbaord_Username_MTB.Text = "";
            SettingsDashbaord_Name_MTB.Text = "";
            SettingsDashbaord_NewPassword_MTB.Text = "";
            SettingsDashbaord_ConfirmPassword_MTB.Text = "";
        }

        // Hide Error Mesages
        public void HideErrorMessages()
        {
            SettingsDashbaord_Username_Error.Hide();
            SettingsDashbaord_Name_Error.Hide();
            SettingsDashbaord_NewPassword_Error.Hide();
            SettingsDashbaord_ConfirmPassword_Error.Hide();
            SettingsDashboard_Success.Hide();
        }

        public void LoadDataToListView()
        {
            HideErrorMessages();
            SettingsDashboard_ListView_MLV.Items.Clear();


            // Select All the Data From DB
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("select * from Userprofiles where Id=@a", dbConnection);
            dbCommand.Parameters.AddWithValue("@a", LoginForm.GlobalUserID);
            dbDataAdapter = new SqlDataAdapter(dbCommand);
            DataSet UserDataSet = new DataSet();
            dbDataAdapter.Fill(UserDataSet, "testTabel");
            dbConnection.Close();

            DataTable UserDataTabel = UserDataSet.Tables["testTabel"];
            int i;
            for (i = 0; i <= UserDataTabel.Rows.Count - 1; i++)
            {
                SettingsDashboard_ListView_MLV.Items.Add(UserDataTabel.Rows[i].ItemArray[0].ToString());
                SettingsDashboard_ListView_MLV.Items[i].SubItems.Add(UserDataTabel.Rows[i].ItemArray[1].ToString());
                SettingsDashboard_ListView_MLV.Items[i].SubItems.Add(UserDataTabel.Rows[i].ItemArray[2].ToString());
                SettingsDashboard_ListView_MLV.Items[i].SubItems.Add(UserDataTabel.Rows[i].ItemArray[3].ToString());
                SettingsDashboard_ListView_MLV.Items[i].SubItems.Add(UserDataTabel.Rows[i].ItemArray[4].ToString());
                SettingsDashboard_ListView_MLV.Items[i].SubItems.Add(UserDataTabel.Rows[i].ItemArray[5].ToString());
            }
        }

        private void SettingsDashboard_ListView_MLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SettingsDashboard_ListView_MLV.SelectedItems.Count == 0)
                return;
            ListViewItem item = SettingsDashboard_ListView_MLV.SelectedItems[0];
            SettingsDashbaord_Username_MTB.Text = item.SubItems[1].Text;
            SettingsDashbaord_Name_MTB.Text = item.SubItems[2].Text;
            SettingsDashbaord_NewPassword_MTB.Text = item.SubItems[3].Text;
            SettingsDashboard_Update_MB.Text = "Update";
        }

        private void SettingsDashboard_Rest_MB_Click(object sender, EventArgs e)
        {
            ClearUserInputs();
            HideErrorMessages();
            LoadDataToListView();
        }

        private void SettingsDashboard_Update_MB_Click(object sender, EventArgs e)
        {
            // Gather User Inputs
            String username =  SettingsDashbaord_Username_MTB.Text;
            String name =  SettingsDashbaord_Name_MTB.Text;
            String password =  SettingsDashbaord_NewPassword_MTB.Text;
            String newpassword = SettingsDashbaord_ConfirmPassword_MTB.Text;

            if(password != newpassword)
            {
                SettingsDashbaord_ConfirmPassword_Error.Text = "Confirm password doesn't match wiht new password";
                SettingsDashbaord_ConfirmPassword_Error.Show();
            } else
            {
                if (SettingsDashboard_Update_MB.Text == "Update")
                {
                    HideErrorMessages();

                    dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
                    dbConnection.Open();
                    dbCommand = new SqlCommand("update Userprofiles set Username=@b, Name=@c, Password=@d where Id=@a", dbConnection);
                    dbCommand.Parameters.AddWithValue("@a", LoginForm.GlobalUserID);
                    dbCommand.Parameters.AddWithValue("@b", username);
                    dbCommand.Parameters.AddWithValue("@c", name);
                    dbCommand.Parameters.AddWithValue("@d", password);
                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                    SettingsDashboard_Success.Show();
                    ClearUserInputs();
                    LoadDataToListView();
                }
            }
        }
    }
}
