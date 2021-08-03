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
    public partial class MapStudents : Form
    {
        // Database Connection
        SqlConnection dbConnection;
        SqlCommand dbCommand;
        SqlDataAdapter dbDataAdapter;

        public MapStudents()
        {
            InitializeComponent();
            HideErrorMessages();
            ClearUserInputs();
        }

        // Setting Public DataSets
        public static string GlobalClassID;
        public static string GlobalStudentID;
        public static string GlobalEditID;

        // Hide Error Messages
        public void HideErrorMessages()
        {
            MapStudent_ClassName_Error.Hide();
            MapStudent_SyudentName_Error.Hide();
            MapStudent_Error.Hide();
            MapStudent_Success.Hide();
        }

        // Clear User Inputs
        public void ClearUserInputs()
        {
            MapStudent_ClassName_MTB.Text = "";
            MapStudent_SudentName_MTB.Text = "";
            MapStudent_ViewData_FilterBy_MCB.SelectedIndex = 0;
            MapStudent_ViewData_SearchValue_MTB.Text = "";
        }

        private void MappSubjects_Load(object sender, EventArgs e)
        {
            ClearUserInputs();
            HideErrorMessages();

            // Set Class Liveview
            MapStudent_ClassName_MLV.Columns.Add("Id", 200);
            MapStudent_ClassName_MLV.Columns.Add("Year", 50, HorizontalAlignment.Center);
            MapStudent_ClassName_MLV.Columns.Add("Grade", 100, HorizontalAlignment.Center);
            MapStudent_ClassName_MLV.Columns.Add("Class Name", 100, HorizontalAlignment.Center);
            MapStudent_ClassName_MLV.View = View.Details;
            LoadClassList();

            // Set Subject Liveview
            MapStudent_StudentName_MLV.Columns.Add("Id", 100);
            MapStudent_StudentName_MLV.Columns.Add("Student Name", 200, HorizontalAlignment.Center);
            MapStudent_StudentName_MLV.Columns.Add("DOB", 100, HorizontalAlignment.Center);
            MapStudent_StudentName_MLV.View = View.Details;
            LoadStudentList();

            // Set Map Subject TO CLass Liveview
            MapSubject_FullDataListView_MLV.Columns.Add("Id", 200);
            MapSubject_FullDataListView_MLV.Columns.Add("Class ID", 400, HorizontalAlignment.Center);
            MapSubject_FullDataListView_MLV.Columns.Add("Student Name", 400, HorizontalAlignment.Center);
            MapSubject_FullDataListView_MLV.View = View.Details;
            LoadClassSubjectList();
        }

        public void LoadClassList()
        {
            MapStudent_ClassName_MLV.Items.Clear();


            // Select All the Data From DB
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("Select Id, Year, Grade, ClassName from Class", dbConnection);
            dbDataAdapter = new SqlDataAdapter(dbCommand);
            DataSet ClassDataSet = new DataSet();
            dbDataAdapter.Fill(ClassDataSet, "testTabel");
            dbConnection.Close();

            DataTable ClassDataTabel = ClassDataSet.Tables["testTabel"];
            int i;
            for (i = 0; i <= ClassDataTabel.Rows.Count - 1; i++)
            {
                MapStudent_ClassName_MLV.Items.Add(ClassDataTabel.Rows[i].ItemArray[0].ToString());
                MapStudent_ClassName_MLV.Items[i].SubItems.Add(ClassDataTabel.Rows[i].ItemArray[1].ToString());
                MapStudent_ClassName_MLV.Items[i].SubItems.Add(ClassDataTabel.Rows[i].ItemArray[2].ToString());
                MapStudent_ClassName_MLV.Items[i].SubItems.Add(ClassDataTabel.Rows[i].ItemArray[3].ToString());
            }
        }

        public void LoadStudentList()
        {
            MapStudent_StudentName_MLV.Items.Clear();


            // Select All the Data From DB
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("Select Id, FullName, DOB from Students", dbConnection);
            dbDataAdapter = new SqlDataAdapter(dbCommand);
            DataSet SubjectDataSet = new DataSet();
            dbDataAdapter.Fill(SubjectDataSet, "testTabel");
            dbConnection.Close();

            DataTable SubjectDataTabel = SubjectDataSet.Tables["testTabel"];
            int i;
            for (i = 0; i <= SubjectDataTabel.Rows.Count - 1; i++)
            {
                MapStudent_StudentName_MLV.Items.Add(SubjectDataTabel.Rows[i].ItemArray[0].ToString());
                MapStudent_StudentName_MLV.Items[i].SubItems.Add(SubjectDataTabel.Rows[i].ItemArray[1].ToString());
                MapStudent_StudentName_MLV.Items[i].SubItems.Add(SubjectDataTabel.Rows[i].ItemArray[2].ToString());
            }
        }

        public void LoadClassSubjectList()
        {
            MapSubject_FullDataListView_MLV.Items.Clear();


            // Select All the Data From DB
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("Select * from MapStudentToClass", dbConnection);
            dbDataAdapter = new SqlDataAdapter(dbCommand);
            DataSet ClassSubjectDataSet = new DataSet();
            dbDataAdapter.Fill(ClassSubjectDataSet, "testTabel");
            dbConnection.Close();

            DataTable ClassSubjectDataTabel = ClassSubjectDataSet.Tables["testTabel"];
            int i;
            for (i = 0; i <= ClassSubjectDataTabel.Rows.Count - 1; i++)
            {
                MapSubject_FullDataListView_MLV.Items.Add(ClassSubjectDataTabel.Rows[i].ItemArray[0].ToString());
                MapSubject_FullDataListView_MLV.Items[i].SubItems.Add(ClassSubjectDataTabel.Rows[i].ItemArray[1].ToString());
                MapSubject_FullDataListView_MLV.Items[i].SubItems.Add(ClassSubjectDataTabel.Rows[i].ItemArray[2].ToString());
            }
        }

        private void MapStudent_ClassName_MLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MapStudent_ClassName_MLV.SelectedItems.Count == 0)
                return;
            ListViewItem item = MapStudent_ClassName_MLV.SelectedItems[0];

            // Setting the Selected Data On Input Fields
            GlobalClassID = item.SubItems[0].Text;
            MapStudent_ClassName_MTB.Text = item.SubItems[0].Text;
        }

        private void MapStudent_StudentName_MLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MapStudent_StudentName_MLV.SelectedItems.Count == 0)
                return;
            ListViewItem item = MapStudent_StudentName_MLV.SelectedItems[0];

            // Setting the Selected Data On Input Fields
            GlobalStudentID = item.SubItems[0].Text;
            MapStudent_SudentName_MTB.Text = item.SubItems[1].Text;
        }

        private void MapSubject_ResetBtn_MB_Click(object sender, EventArgs e)
        {
            ClearUserInputs();
            HideErrorMessages();
            LoadClassList();
            LoadStudentList();
            LoadClassSubjectList();
        }

        private void MapSubject_SaveBtn_MB_Click(object sender, EventArgs e)
        {
            HideErrorMessages();

            // Gather User Input Values
            string mapstudentclassid = GlobalClassID + GlobalStudentID;
            string classid = MapStudent_ClassName_MTB.Text;
            string studentname = MapStudent_SudentName_MTB.Text;

            // Input Fields Validation
            if (classid == "")
            {
                MapStudent_ClassName_Error.Show();
            }
            if (studentname == "")
            {
                MapStudent_SyudentName_Error.Show();
            }

            // Data Base Connection & Query
            if (classid != "" && studentname != "")
            {
                HideErrorMessages();

                dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
                dbConnection.Open();

                // CHeck the Status of the save button
                if (MapSubject_SaveBtn_MB.Text == "Save")
                {
                    // Save New Class
                    dbCommand = new SqlCommand("insert into MapStudentToClass(Id, StudentName, ClassID) values (@a, @b, @c)", dbConnection);
                    dbCommand.Parameters.AddWithValue("@a", mapstudentclassid);
                    dbCommand.Parameters.AddWithValue("@b", studentname);
                    dbCommand.Parameters.AddWithValue("@c", classid);
                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                    MapStudent_Success.Text = "Successfully asigned student to class";
                    MapStudent_Success.Show();
                    ClearUserInputs();
                    LoadClassSubjectList();
                }
                else
                {
                    // Update Class Details
                    dbCommand = new SqlCommand("update MapStudentToClass set ClassID=@a, StudentName=@b where Id=@c", dbConnection);
                    dbCommand.Parameters.AddWithValue("@a", classid);
                    dbCommand.Parameters.AddWithValue("@b", studentname);
                    dbCommand.Parameters.AddWithValue("@c", GlobalEditID);
                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                    MapStudent_Success.Text = "Successfull Updated the assigned subject";
                    MapStudent_Success.Show();
                    ClearUserInputs();
                    LoadClassSubjectList();
                }
            }
        }

        private void MapSubject_ViewData_Search_MB_Click(object sender, EventArgs e)
        {
            // Get User inputs
            String filterby = MapStudent_ViewData_FilterBy_MCB.SelectedItem.ToString();
            String filtervalue = MapStudent_ViewData_SearchValue_MTB.Text;
            String sqlsearchquery = "";

            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();

            switch (filterby)
            {
                case "Student Name":
                    sqlsearchquery = "select * from MapStudentToClass where StudentName like '%" + filtervalue + "%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                case "Class ID":
                    sqlsearchquery = "select * from MapStudentToClass where ClassID like '%" + filtervalue + "%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                default:
                    sqlsearchquery = "select * from MapStudentToClass";
                    searchbyfilterfunction(sqlsearchquery);
                    break;

            }
        }

        // Comon Search Function
        public void searchbyfilterfunction(string sqlsearchquery)
        {
            MapSubject_FullDataListView_MLV.Items.Clear();


            // Select All the Data From DB
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand(sqlsearchquery, dbConnection);
            dbDataAdapter = new SqlDataAdapter(dbCommand);
            DataSet StudentDataSet = new DataSet();
            DataSet ClassSubjectDataSet = new DataSet();
            dbDataAdapter.Fill(ClassSubjectDataSet, "testTabel");
            dbConnection.Close();

            DataTable ClassSubjectDataTabel = ClassSubjectDataSet.Tables["testTabel"];
            int i;
            for (i = 0; i <= ClassSubjectDataTabel.Rows.Count - 1; i++)
            {
                MapSubject_FullDataListView_MLV.Items.Add(ClassSubjectDataTabel.Rows[i].ItemArray[0].ToString());
                MapSubject_FullDataListView_MLV.Items[i].SubItems.Add(ClassSubjectDataTabel.Rows[i].ItemArray[1].ToString());
                MapSubject_FullDataListView_MLV.Items[i].SubItems.Add(ClassSubjectDataTabel.Rows[i].ItemArray[2].ToString());
            }
        }

        private void MapSubject_FullDataListView_MLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MapSubject_FullDataListView_MLV.SelectedItems.Count == 0)
                return;
            ListViewItem item = MapSubject_FullDataListView_MLV.SelectedItems[0];

            // Setting the Selected Data On Input Fields
            MapSubject_SaveBtn_MB.Text = "Update";
            GlobalEditID = item.SubItems[0].Text;
            MapStudent_ClassName_MTB.Text = item.SubItems[1].Text;
            MapStudent_SudentName_MTB.Text = item.SubItems[2].Text;
        }

        private void AdminDashboard_ScD_MLB_Click(object sender, EventArgs e)
        {
            MappSubjects objMappSubjects = new MappSubjects();
            objMappSubjects.Show();
            this.Hide();
        }

        private void AdminDashboard_CD_MLB_Click(object sender, EventArgs e)
        {
            MapStudents objMapStudents = new MapStudents();
            objMapStudents.Show();
            this.Hide();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            ExamResults objExamResults = new ExamResults();
            objExamResults.Show();
            this.Hide();
        }

        private void AdminDashboard_Settings_MLB_Click(object sender, EventArgs e)
        {
            StaffProfileSettings objStaffProfileSettings = new StaffProfileSettings();
            objStaffProfileSettings.Show();
            this.Hide();
        }

        private void AdminDashboard_Logout_MLB_Click(object sender, EventArgs e)
        {
            LoginForm objLoginForm = new LoginForm();
            objLoginForm.Show();
            this.Hide();
        }

        private void MapStudent_Success_Click(object sender, EventArgs e)
        {

        }

        private void MapStudent_SyudentName_Error_Click(object sender, EventArgs e)
        {

        }

        private void MapStudent_SudentName_MTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void MapStudent_ClassName_Error_Click(object sender, EventArgs e)
        {

        }

        private void MapStudent_ClassName_MTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void MapStudent_ViewData_FilterBy_MCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MapStudent_ViewData_SearchValue_MTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentDashboard_ViewData_MC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentDashboard_Title_ML_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashbaord_Logo_PB_Click(object sender, EventArgs e)
        {

        }

        private void MapStudent_Error_Click(object sender, EventArgs e)
        {

        }

        private void AdminDasboard_Navbar_MC_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
