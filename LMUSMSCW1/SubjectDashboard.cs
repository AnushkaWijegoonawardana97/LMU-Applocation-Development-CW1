using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace LMUSMSCW1
{
    public partial class SubjectDashboard : Form
    {
        // Database Connection
        SqlConnection dbConnection;
        SqlCommand dbCommand;
        SqlDataAdapter dbDataAdapter;

        public SubjectDashboard()
        {
            InitializeComponent();
        }

        // Setting Public DataSets
        public static string GlobalSubjectID;

        // School Dashboard Function
        private void SubjectDashboard_ScD_MLB_Click(object sender, EventArgs e)
        {
            SchoolDashboard objSchoolDashboard = new SchoolDashboard();
            objSchoolDashboard.Show();
            this.Hide();
        }

        // Class Dashboard Funtion
        private void SubjectDashboard_CD_MLB_Click(object sender, EventArgs e)
        {
            ClassDashboard objClassDashboard = new ClassDashboard();
            objClassDashboard.Show();
            this.Hide();
        }

        // Student Dashboard Function
        private void SubjectDashboard_StuD_MLB_Click(object sender, EventArgs e)
        {
            StudentDashboard objStudentDashboard = new StudentDashboard();
            objStudentDashboard.Show();
            this.Hide();
        }

        // Staff Dashboard Function
        private void SubjectDashboard_StfD_MLB_Click(object sender, EventArgs e)
        {
            StaffDashboard objStaffDashboard = new StaffDashboard();
            objStaffDashboard.Show();
            this.Hide();
        }

        // Subject Dashboard Function
        private void SubjectDashboard_SubD_MLB_Click(object sender, EventArgs e)
        {
            SubjectDashboard objSubjectDashboard = new SubjectDashboard();
            objSubjectDashboard.Show();
            this.Hide();
        }

        // User Dashboard Function
        private void SubjectDashboard_UD_MLB_Click(object sender, EventArgs e)
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

        // Admin Dashboard Function
        private void SubjectDashboard_BackTDB_MLB_Click(object sender, EventArgs e)
        {
            AdminDashboard objAdminDashboard = new AdminDashboard();
            objAdminDashboard.Hide();
            this.Show();
        }

        // Setting Dashboard Function
        private void SubjectDashboard_Settings_MLB_Click(object sender, EventArgs e)
        {
            SettingsDashboard objSettingDashboard = new SettingsDashboard();
            objSettingDashboard.Show();
            this.Hide();
        }

        // Logout Function
        private void SubjectDashboard_Logout_MLB_Click(object sender, EventArgs e)
        {
            LoginForm objLoginForm = new LoginForm();
            objLoginForm.Show();
            this.Hide();
        }

        // On Subject Dashboard Load
        private void SubjectDashboard_Load(object sender, EventArgs e)
        {
            HideErrorMessages();
            ClearUserInputs();

            // Creating the ListView
            SubjectDashboard_DataTabel_MLV.Columns.Add("Id", 150);
            SubjectDashboard_DataTabel_MLV.Columns.Add("Subject Name", 200, HorizontalAlignment.Center);
            SubjectDashboard_DataTabel_MLV.Columns.Add("NOP/w", 100, HorizontalAlignment.Center);
            SubjectDashboard_DataTabel_MLV.Columns.Add("Subject Teacher", 200, HorizontalAlignment.Center);
            SubjectDashboard_DataTabel_MLV.Columns.Add("Subject Details", 300, HorizontalAlignment.Center);
            SubjectDashboard_DataTabel_MLV.View = View.Details;

            // Creating the Teachers Data List
            SubjectDashboard_TeachersList_MLV.Columns.Add("ID", 50);
            SubjectDashboard_TeachersList_MLV.Columns.Add("Teachers", 190, HorizontalAlignment.Center);
            SubjectDashboard_TeachersList_MLV.View = View.Details;

            // Load Dat To Teachers List
            LoadTeachersNames();

            // Check Wether Alreday there is a school created
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("Select count(*) from SubjectTabel", dbConnection);
            int results = Convert.ToInt32(dbCommand.ExecuteScalar());
            dbCommand.ExecuteNonQuery();
            dbConnection.Close();
            if (results != 0)
            {
                LoadDataToListView();
            }
        }

        // Clear User Input Fileds
        public void ClearUserInputs()
        {
            SubjectDashboard_SubjectNameInput_MTB.Text = "";
            SubjectDashboard_NumberOfPeriodsInput_MTB.Text = "";
            SubjectDashboard_TeachersInput_MTB.Text = "";
            SubjectDashboard_DetailsInput_MTB.Text = "";
            SubjectDashboard_ViewData_FilterBy_MCB.SelectedIndex = 0;
            SubjectDashboard_ViewData_SearchValue_MTB.Text = "";
        }

        // Hide Error Messages
        public void HideErrorMessages()
        {
            SubjectDashboard_SubjectNameInput_Error.Hide();
            SubjectDashboard_Error.Hide();
            SubjectDashboard_Success.Hide();
        }

        // Load all the Subject  from database
        public void LoadDataToListView()
        {
            SubjectDashboard_DataTabel_MLV.Items.Clear();


            // Select All the Data From DB
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("Select * from SubjectTabel", dbConnection);
            dbDataAdapter = new SqlDataAdapter(dbCommand);
            DataSet SubjectDataSet = new DataSet();
            dbDataAdapter.Fill(SubjectDataSet, "testTabel");
            dbConnection.Close();

            DataTable SubjectDataTabel = SubjectDataSet.Tables["testTabel"];
            int i;
            for (i = 0; i <= SubjectDataTabel.Rows.Count - 1; i++)
            {
                SubjectDashboard_DataTabel_MLV.Items.Add(SubjectDataTabel.Rows[i].ItemArray[0].ToString());
                SubjectDashboard_DataTabel_MLV.Items[i].SubItems.Add(SubjectDataTabel.Rows[i].ItemArray[1].ToString());
                SubjectDashboard_DataTabel_MLV.Items[i].SubItems.Add(SubjectDataTabel.Rows[i].ItemArray[2].ToString());
                SubjectDashboard_DataTabel_MLV.Items[i].SubItems.Add(SubjectDataTabel.Rows[i].ItemArray[3].ToString());
                SubjectDashboard_DataTabel_MLV.Items[i].SubItems.Add(SubjectDataTabel.Rows[i].ItemArray[4].ToString());
            }
        }

        // Load Teachers Names
        public void LoadTeachersNames()
        {
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("Select Id, FullName from StaffMember", dbConnection);
            dbDataAdapter = new SqlDataAdapter(dbCommand);
            DataSet TeachersDataSet = new DataSet();
            dbDataAdapter.Fill(TeachersDataSet, "testTabel");
            dbConnection.Close();

            DataTable TeachersDataTabel = TeachersDataSet.Tables["testTabel"];
            int i;
            for (i = 0; i <= TeachersDataTabel.Rows.Count - 1; i++)
            {
                SubjectDashboard_TeachersList_MLV.Items.Add(TeachersDataTabel.Rows[i].ItemArray[0].ToString());
                SubjectDashboard_TeachersList_MLV.Items[i].SubItems.Add(TeachersDataTabel.Rows[i].ItemArray[1].ToString());
            }
        }

        private void SubjectDashboard_TeachersList_MLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SubjectDashboard_TeachersList_MLV.SelectedItems.Count == 0)
                return;
            ListViewItem item = SubjectDashboard_TeachersList_MLV.SelectedItems[0];
            SubjectDashboard_TeachersInput_MTB.Text = item.SubItems[1].Text;
        }

        private void SubjectDashboard_SaveBtn_MB_Click(object sender, EventArgs e)
        {
            HideErrorMessages();

            // Data User Input Data
            String subjectname = SubjectDashboard_SubjectNameInput_MTB.Text;
            String subjectnumberofperiod = SubjectDashboard_NumberOfPeriodsInput_MTB.Text;
            String subjectdetails = SubjectDashboard_DetailsInput_MTB.Text;
            String subjectteacher = SubjectDashboard_TeachersInput_MTB.Text;

            // Input Validation
            if (subjectname == "")
            {
                SubjectDashboard_SubjectNameInput_Error.Show();
            }

            if (subjectname != "")
            {
                HideErrorMessages();

                dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
                dbConnection.Open();

                // Check for the button state save or update
                if (SubjectDashboard_SaveBtn_MB.Text == "Save")
                {
                    // Save New Subject
                    dbCommand = new SqlCommand("insert into SubjectTabel(SubjectName, PeriodPerWeek, SubjectDetails, SubjectTeacher) values (@a, @b, @c, @d)", dbConnection);
                    dbCommand.Parameters.AddWithValue("@a", subjectname);
                    dbCommand.Parameters.AddWithValue("@b", subjectnumberofperiod);
                    dbCommand.Parameters.AddWithValue("@c", subjectdetails);
                    dbCommand.Parameters.AddWithValue("@d", subjectteacher);
                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                    SubjectDashboard_Success.Text = "Successfully created a new subject";
                    SubjectDashboard_Success.Show();
                    ClearUserInputs();
                    LoadDataToListView();
                }
                else
                {
                    // Update Class Details
                    dbCommand = new SqlCommand("update SubjectTabel set SubjectName=@a, PeriodPerWeek=@b, SubjectDetails=@c, SubjectTeacher=@d where Id=@e", dbConnection);
                    dbCommand.Parameters.AddWithValue("@a", subjectname);
                    dbCommand.Parameters.AddWithValue("@b", subjectnumberofperiod);
                    dbCommand.Parameters.AddWithValue("@c", subjectdetails);
                    dbCommand.Parameters.AddWithValue("@d", subjectteacher);
                    dbCommand.Parameters.AddWithValue("@e", GlobalSubjectID);
                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                    SubjectDashboard_Success.Text = "Successfully updated the subject";
                    SubjectDashboard_Success.Show();
                    ClearUserInputs();
                    LoadDataToListView();
                }

            }
        }

        private void SubjectDashboard_ResetBtn_MB_Click(object sender, EventArgs e)
        {
            HideErrorMessages();
            ClearUserInputs();
            LoadDataToListView();
        }

        private void SubjectDashboard_DataTabel_MLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SubjectDashboard_DataTabel_MLV.SelectedItems.Count == 0)
                return;
            ListViewItem item = SubjectDashboard_DataTabel_MLV.SelectedItems[0];

            // Setting the Selected Data On Input Fields
            SubjectDashboard_SaveBtn_MB.Text = "Update";
            GlobalSubjectID = item.SubItems[0].Text;

            SubjectDashboard_SubjectNameInput_MTB.Text = item.SubItems[1].Text;
            SubjectDashboard_NumberOfPeriodsInput_MTB.Text = item.SubItems[2].Text;
            SubjectDashboard_TeachersInput_MTB.Text = item.SubItems[4].Text;
            SubjectDashboard_DetailsInput_MTB.Text = item.SubItems[3].Text;
        }

        private void SubjectDashboard_ViewData_Search_MB_Click(object sender, EventArgs e)
        {
            // Get User inputs
            String filterby = SubjectDashboard_ViewData_FilterBy_MCB.SelectedItem.ToString();
            String filtervalue = SubjectDashboard_ViewData_SearchValue_MTB.Text;
            string sqlsearchquery = "";

            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();

            switch (filterby)
            {
                case "Subject":
                    sqlsearchquery = "select * from SubjectTabel where SubjectName like '%" + filtervalue + "%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                case "Subject Teacher":
                    sqlsearchquery = "select * from SubjectTabel where SubjectTeacher like '%" + filtervalue + "%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                default:
                    sqlsearchquery = "select * from SubjectTabel";
                    searchbyfilterfunction(sqlsearchquery);
                    break;

            }
        }

        // Comon Search Function
        public void searchbyfilterfunction(string sqlsearchquery)
        {
            SubjectDashboard_DataTabel_MLV.Items.Clear();


            // Select All the Data From DB
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand(sqlsearchquery, dbConnection);
            dbDataAdapter = new SqlDataAdapter(dbCommand);
            DataSet SubjectDataSet = new DataSet();
            dbDataAdapter.Fill(SubjectDataSet, "testTabel");
            dbConnection.Close();

            DataTable SubjectDataTabel = SubjectDataSet.Tables["testTabel"];
            int i;
            for (i = 0; i <= SubjectDataTabel.Rows.Count - 1; i++)
            {
                SubjectDashboard_DataTabel_MLV.Items.Add(SubjectDataTabel.Rows[i].ItemArray[0].ToString());
                SubjectDashboard_DataTabel_MLV.Items[i].SubItems.Add(SubjectDataTabel.Rows[i].ItemArray[1].ToString());
                SubjectDashboard_DataTabel_MLV.Items[i].SubItems.Add(SubjectDataTabel.Rows[i].ItemArray[2].ToString());
                SubjectDashboard_DataTabel_MLV.Items[i].SubItems.Add(SubjectDataTabel.Rows[i].ItemArray[3].ToString());
                SubjectDashboard_DataTabel_MLV.Items[i].SubItems.Add(SubjectDataTabel.Rows[i].ItemArray[4].ToString());
            }
        }
    }
}
