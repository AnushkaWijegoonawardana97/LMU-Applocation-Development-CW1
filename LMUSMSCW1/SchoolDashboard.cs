using System;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace LMUSMSCW1
{
    public partial class SchoolDashboard : Form
    {
        // Database Connection
        SqlConnection dbConnection;
        SqlCommand dbCommand;
        SqlDataAdapter dbDataAdapter;

        public SchoolDashboard()
        {
            InitializeComponent();
        }

        // School Dashboard Logout Button Function
        private void SchoolDashboard_Logout_MLB_Click(object sender, EventArgs e)
        {
            LoginForm objLoginForm = new LoginForm();
            objLoginForm.Show();
            this.Hide();
        }

        // SD Class Dashboard Button Funtion
        private void SchoolDashboard_CD_MLB_Click(object sender, EventArgs e)
        {
            ClassDashboard objClassDashboard = new ClassDashboard();
            objClassDashboard.Show();
            this.Hide();
        }

        private void OnSchoolDBLoad(object sender, EventArgs e)
        {
            HideErrorMessages();
            ClearUserInputs();

            SchoolDashboard_VS_ListView_MLV.Columns.Add("Id", 50, HorizontalAlignment.Center);
            SchoolDashboard_VS_ListView_MLV.Columns.Add("SchoolName", 120, HorizontalAlignment.Center);
            SchoolDashboard_VS_ListView_MLV.Columns.Add("SchoolType", 100, HorizontalAlignment.Center);
            SchoolDashboard_VS_ListView_MLV.Columns.Add("PrinicipleName", 100, HorizontalAlignment.Center);
            SchoolDashboard_VS_ListView_MLV.Columns.Add("ContactNumber", 100, HorizontalAlignment.Center);
            SchoolDashboard_VS_ListView_MLV.Columns.Add("Address", 120, HorizontalAlignment.Center);
            SchoolDashboard_VS_ListView_MLV.Columns.Add("SchoolMotto", 130, HorizontalAlignment.Center);
            SchoolDashboard_VS_ListView_MLV.Columns.Add("AboutSchool", 150, HorizontalAlignment.Center);
            SchoolDashboard_VS_ListView_MLV.View = View.Details;

            // Check Wether Alreday there is a school created
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("Select count(*) from SchoolTabel", dbConnection);
            int results = Convert.ToInt32(dbCommand.ExecuteScalar());
            dbCommand.ExecuteNonQuery();
            dbConnection.Close();
            if (results != 0)
            {
                LoadDataToListView();
            } else
            {
                SchoolDB_No_SchoolRD.Show();
            }
        }

        // Hide Error Messages
        public void HideErrorMessages()
        {
            SchoolDashboard_CS_ErrorSchoolName_ML.Hide();
            SchoolDashboard_CS_ErrorSchoolType_ML.Hide();
            SchoolDashboard_CS_ErrorPrincipleName_ML.Hide();
            SchoolDashboard_CS_ErrorContactNumber_ML.Hide();
            SchoolDashboard_CS_ErrorAddress_ML.Hide();
            SchoolDashboard_CS_Success.Hide();
            SchoolDB_No_SchoolRD.Hide();
        }

        // Clear Form Input Fields
        public void ClearUserInputs()
        {
            SchoolDashboard_CS_SchoolName_MTF.Text = "";
            SchoolDashboard_CS_SchoolMotto_MTF.Text = "";
            SchoolDashboard_CS_SchoolType_MCB.SelectedIndex = 0;
            SchoolDashboard_CS_PrincipleName_MTF.Text = "";
            SchoolDashboard_CS_ContactNumber_MTF.Text = "";
            SchoolDashboard_CS_Address_MTF.Text = "";
            SchoolDashboard_CS_AboutSchool_MTF.Text = "";
        }

        // School Dashboard Save Data Button
        private void SchoolDashboard_CS_Save_MB_Click(object sender, EventArgs e)
        {
            HideErrorMessages();

            // Data user inputs
            String schoolname = SchoolDashboard_CS_SchoolName_MTF.Text;
            String schoolmotto = SchoolDashboard_CS_SchoolMotto_MTF.Text;
            String schooltype = SchoolDashboard_CS_SchoolType_MCB.SelectedItem.ToString();
            String schoolprinciple = SchoolDashboard_CS_PrincipleName_MTF.Text;
            String schoolcontactnumber = SchoolDashboard_CS_ContactNumber_MTF.Text;
            String schooladdress = SchoolDashboard_CS_Address_MTF.Text;
            String schoolabout = SchoolDashboard_CS_AboutSchool_MTF.Text;

            // User Input Validation
            if(schoolname == "")
            {
                SchoolDashboard_CS_ErrorSchoolName_ML.Show();
            }
            if(schooltype == "")
            {
                SchoolDashboard_CS_ErrorSchoolType_ML.Show();
            }
            if (schoolprinciple == "")
            {
                SchoolDashboard_CS_ErrorPrincipleName_ML.Show();
            }
            if (schoolcontactnumber == "")
            {
                SchoolDashboard_CS_ErrorContactNumber_ML.Show();
            }
            if (schooladdress == "")
            {
                SchoolDashboard_CS_ErrorAddress_ML.Show();
            }

            // Database Connection & Login
            if(schoolname != "" && schooltype !=  "" && schoolprinciple != "" && schoolcontactnumber != "" && schooladdress != "")
            {
                HideErrorMessages();

                dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
                dbConnection.Open();

                // Checking is there any schools
                dbCommand = new SqlCommand("Select count(*) from SchoolTabel", dbConnection);
                int results = Convert.ToInt32(dbCommand.ExecuteScalar());
                if (results != 0)
                {
                    if (SchoolDashboard_CS_Save_MB.Text == "Save")
                    {
                        SchoolDashboard_CS_Success.Text = "School is already created. Select form listview to update.";
                        SchoolDashboard_CS_Success.Show();
                        dbCommand.ExecuteNonQuery();
                        dbConnection.Close();
                        ClearUserInputs();
                    }
                    else
                    {
                        // Update School
                        dbCommand = new SqlCommand("update SchoolTabel set SchoolName=@a, SchoolType=@b, PrinicipleName=@c, ContactNumber=@d, Address=@e, SchoolMotto=@f, AboutSchool=@g where Id=1", dbConnection);
                        dbCommand.Parameters.AddWithValue("@a", schoolname);
                        dbCommand.Parameters.AddWithValue("@b", schooltype);
                        dbCommand.Parameters.AddWithValue("@c", schoolprinciple);
                        dbCommand.Parameters.AddWithValue("@d", schoolcontactnumber);
                        dbCommand.Parameters.AddWithValue("@e", schooladdress);
                        dbCommand.Parameters.AddWithValue("@f", schoolmotto);
                        dbCommand.Parameters.AddWithValue("@g", schoolabout);
                        dbCommand.ExecuteNonQuery();
                        dbConnection.Close();
                        ClearUserInputs();
                        SchoolDashboard_CS_Success.Text = "School Data Updated";
                        SchoolDashboard_CS_Success.Show();
                        LoadDataToListView();
                    }
                }
                else
                {
                    // Create School
                    dbCommand = new SqlCommand("insert into SchoolTabel(SchoolName, SchoolType, PrinicipleName, ContactNumber, Address, SchoolMotto, AboutSchool) values (@a, @b, @c, @d, @e, @f, @g)", dbConnection);
                    dbCommand.Parameters.AddWithValue("@a", schoolname);
                    dbCommand.Parameters.AddWithValue("@b", schooltype);
                    dbCommand.Parameters.AddWithValue("@c", schoolprinciple);
                    dbCommand.Parameters.AddWithValue("@d", schoolcontactnumber);
                    dbCommand.Parameters.AddWithValue("@e", schooladdress);
                    dbCommand.Parameters.AddWithValue("@f", schoolmotto);
                    dbCommand.Parameters.AddWithValue("@g", schoolabout);
                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                    ClearUserInputs();
                    SchoolDashboard_CS_Success.Text = "New School Created";
                    SchoolDashboard_CS_Success.Show();
                    LoadDataToListView();
                }
                
            }
        }

        private void SchoolDashboard_CS_Rest_MB_Click(object sender, EventArgs e)
        {
            ClearUserInputs();
            HideErrorMessages();
        }




        // Load Data To List View 
        public void LoadDataToListView()
        {
            HideErrorMessages();
            SchoolDashboard_VS_ListView_MLV.Items.Clear();
            

            // Select All the Data From DB
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("Select * from SchoolTabel", dbConnection);
            dbDataAdapter = new SqlDataAdapter(dbCommand);
            DataSet SchoolDataSet = new DataSet();
            dbDataAdapter.Fill(SchoolDataSet, "testTabel");
            dbConnection.Close();

            DataTable SchoolDataTabel = SchoolDataSet.Tables["testTabel"];
            int i;
            for (i = 0; i <= SchoolDataTabel.Rows.Count - 1; i++)
            {
                SchoolDashboard_VS_ListView_MLV.Items.Add(SchoolDataTabel.Rows[i].ItemArray[0].ToString());
                SchoolDashboard_VS_ListView_MLV.Items[i].SubItems.Add(SchoolDataTabel.Rows[i].ItemArray[1].ToString());
                SchoolDashboard_VS_ListView_MLV.Items[i].SubItems.Add(SchoolDataTabel.Rows[i].ItemArray[2].ToString());
                SchoolDashboard_VS_ListView_MLV.Items[i].SubItems.Add(SchoolDataTabel.Rows[i].ItemArray[3].ToString());
                SchoolDashboard_VS_ListView_MLV.Items[i].SubItems.Add(SchoolDataTabel.Rows[i].ItemArray[4].ToString());
                SchoolDashboard_VS_ListView_MLV.Items[i].SubItems.Add(SchoolDataTabel.Rows[i].ItemArray[5].ToString());
                SchoolDashboard_VS_ListView_MLV.Items[i].SubItems.Add(SchoolDataTabel.Rows[i].ItemArray[6].ToString());
                SchoolDashboard_VS_ListView_MLV.Items[i].SubItems.Add(SchoolDataTabel.Rows[i].ItemArray[7].ToString());
            }
        }

        private void SelectedSchoolListViewIndex(object sender, EventArgs e)
        {
            if (SchoolDashboard_VS_ListView_MLV.SelectedItems.Count == 0)
                return;
            ListViewItem item = SchoolDashboard_VS_ListView_MLV.SelectedItems[0];
            SchoolDashboard_CS_SchoolName_MTF.Text = item.SubItems[1].Text;
            SchoolDashboard_CS_SchoolMotto_MTF.Text = item.SubItems[6].Text;

            if (item.SubItems[2].Text == "Goverment School")
            {
                SchoolDashboard_CS_SchoolType_MCB.SelectedIndex = 0;
            }
            if (item.SubItems[2].Text == "Semi Goverment School")
            {
                SchoolDashboard_CS_SchoolType_MCB.SelectedIndex = 1;
            }
            if (item.SubItems[2].Text == "Private School")
            {
                SchoolDashboard_CS_SchoolType_MCB.SelectedIndex = 2;
            }
            if (item.SubItems[2].Text == "International School")
            {
                SchoolDashboard_CS_SchoolType_MCB.SelectedIndex = 3;
            }

            SchoolDashboard_CS_PrincipleName_MTF.Text = item.SubItems[3].Text;
            SchoolDashboard_CS_ContactNumber_MTF.Text = item.SubItems[4].Text;
            SchoolDashboard_CS_Address_MTF.Text = item.SubItems[5].Text;
            SchoolDashboard_CS_AboutSchool_MTF.Text = item.SubItems[7].Text;
            SchoolDashboard_CS_Save_MB.Text = "Update";
        }

        private void SchoolDashboard_StuD_MLB_Click(object sender, EventArgs e)
        {
            StudentDashboard objStudentDashboard = new StudentDashboard();
            objStudentDashboard.Show();
            this.Hide();
        }

        private void SchoolDashboard_StfD_MLB_Click(object sender, EventArgs e)
        {
            StaffDashboard objStaffDashboard = new StaffDashboard();
            objStaffDashboard.Show();
            this.Hide();
        }

        private void SchoolDashboard_SubD_MLB_Click(object sender, EventArgs e)
        {
            SubjectDashboard objSubjectDashboard = new SubjectDashboard();
            objSubjectDashboard.Show();
            this.Hide();
        }

        private void SchoolDashboard_UD_MLB_Click(object sender, EventArgs e)
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

        private void SchoolDashboard_BackTDB_MLB_Click(object sender, EventArgs e)
        {
            AdminDashboard objAdminDashboard = new AdminDashboard();
            objAdminDashboard.Show();
            this.Hide();
        }

        private void SchoolDashboard_Settings_MLB_Click(object sender, EventArgs e)
        {
            SettingsDashboard objSettingDashboard = new SettingsDashboard();
            objSettingDashboard.Show();
            this.Hide();
        }

        private void SchoolDashboard_ScD_MLB_Click(object sender, EventArgs e)
        {
            SchoolDashboard objSchoolDashboard = new SchoolDashboard();
            objSchoolDashboard.Show();
            this.Hide();
        }
    }
}
