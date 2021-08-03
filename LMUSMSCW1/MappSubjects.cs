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
    public partial class MappSubjects : Form
    {
        // Database Connection
        SqlConnection dbConnection;
        SqlCommand dbCommand;
        SqlDataAdapter dbDataAdapter;

        public MappSubjects()
        {
            InitializeComponent();
            HideErrorMessages();
        }

        // Setting Public DataSets
        public static string GlobalClassID;
        public static string GlobalSubjectID;
        public static string GlobalEditID;


        private void AdminDashboard_ScD_MLB_Click_1(object sender, EventArgs e)
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
            LoginForm objLoginForm = new LoginForm();
            objLoginForm.Show();
            this.Hide();
        }

        private void AdminDashboard_Logout_MLB_Click(object sender, EventArgs e)
        {
            StaffProfileSettings objStaffProfileSettings = new StaffProfileSettings();
            objStaffProfileSettings.Show();
            this.Hide();
        }

        // Hide Error Messages
        public void  HideErrorMessages()
        {
            MapSubject_ClassName_Error.Hide();
            MapSubject_SubjectName_Error.Hide();
            MapSubject_Error.Hide();
            MapSubject_Success.Hide();
        }

        // Clear User Inputs
        public void ClearUserInputs() {
            MapSubject_ClassName_MTB.Text = "";
            MapSubject_SubjectName_MTB.Text = "";
            MapSubject_ViewData_FilterBy_MCB.SelectedIndex = 0;
            MapSubject_ViewData_SearchValue_MTB.Text = "";
        }

        private void MappSubjects_Load(object sender, EventArgs e)
        {
            ClearUserInputs();
            HideErrorMessages();

            // Set Class Liveview
            MapSubject_ClassName_MLV.Columns.Add("Id", 200);
            MapSubject_ClassName_MLV.Columns.Add("Year", 50, HorizontalAlignment.Center);
            MapSubject_ClassName_MLV.Columns.Add("Grade", 100, HorizontalAlignment.Center);
            MapSubject_ClassName_MLV.Columns.Add("Class Name", 100, HorizontalAlignment.Center);
            MapSubject_ClassName_MLV.View = View.Details;
            LoadClassList();

            // Set Subject Liveview
            MapSubject_SubjectName_MLV.Columns.Add("Id", 100);
            MapSubject_SubjectName_MLV.Columns.Add("Subject Name", 300, HorizontalAlignment.Center);
            MapSubject_SubjectName_MLV.View = View.Details;
            LoadSubjectList();

            // Set Map Subject TO CLass Liveview
            MapSubject_FullDataListView_MLV.Columns.Add("Id", 200);
            MapSubject_FullDataListView_MLV.Columns.Add("Class ID", 400, HorizontalAlignment.Center);
            MapSubject_FullDataListView_MLV.Columns.Add("Subject Name", 400, HorizontalAlignment.Center);
            MapSubject_FullDataListView_MLV.View = View.Details;
            LoadClassSubjectList();
        }

        public void LoadClassList()
        {
            MapSubject_ClassName_MLV.Items.Clear();


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
                MapSubject_ClassName_MLV.Items.Add(ClassDataTabel.Rows[i].ItemArray[0].ToString());
                MapSubject_ClassName_MLV.Items[i].SubItems.Add(ClassDataTabel.Rows[i].ItemArray[1].ToString());
                MapSubject_ClassName_MLV.Items[i].SubItems.Add(ClassDataTabel.Rows[i].ItemArray[2].ToString());
                MapSubject_ClassName_MLV.Items[i].SubItems.Add(ClassDataTabel.Rows[i].ItemArray[3].ToString());
            }
        }

        public void LoadSubjectList()
        {
            MapSubject_SubjectName_MLV.Items.Clear();


            // Select All the Data From DB
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("Select Id, SubjectName from SubjectTabel", dbConnection);
            dbDataAdapter = new SqlDataAdapter(dbCommand);
            DataSet SubjectDataSet = new DataSet();
            dbDataAdapter.Fill(SubjectDataSet, "testTabel");
            dbConnection.Close();

            DataTable SubjectDataTabel = SubjectDataSet.Tables["testTabel"];
            int i;
            for (i = 0; i <= SubjectDataTabel.Rows.Count - 1; i++)
            {
                MapSubject_SubjectName_MLV.Items.Add(SubjectDataTabel.Rows[i].ItemArray[0].ToString());
                MapSubject_SubjectName_MLV.Items[i].SubItems.Add(SubjectDataTabel.Rows[i].ItemArray[1].ToString());
            }
        }

        public void LoadClassSubjectList()
        {
            MapSubject_FullDataListView_MLV.Items.Clear();


            // Select All the Data From DB
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("Select * from MapSubjectToClass", dbConnection);
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

        private void MapSubject_ClassName_MLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MapSubject_ClassName_MLV.SelectedItems.Count == 0)
                return;
            ListViewItem item = MapSubject_ClassName_MLV.SelectedItems[0];

            // Setting the Selected Data On Input Fields
            GlobalClassID = item.SubItems[0].Text;
            MapSubject_ClassName_MTB.Text = item.SubItems[0].Text;
        }

        private void MapSubject_SubjectName_MLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MapSubject_SubjectName_MLV.SelectedItems.Count == 0)
                return;
            ListViewItem item = MapSubject_SubjectName_MLV.SelectedItems[0];

            // Setting the Selected Data On Input Fields
            GlobalSubjectID = item.SubItems[0].Text;
            MapSubject_SubjectName_MTB.Text = item.SubItems[1].Text;
        }

        private void MapSubject_SaveBtn_MB_Click(object sender, EventArgs e)
        {
            HideErrorMessages();

            // Gather User Input Values
            string mapclasssubjectid = GlobalClassID + GlobalSubjectID;
            string classid = MapSubject_ClassName_MTB.Text;
            string subjectname = MapSubject_SubjectName_MTB.Text;

            // Input Fields Validation
            if (classid == "")
            {
                MapSubject_ClassName_Error.Show();
            }
            if (subjectname == "")
            {
                MapSubject_SubjectName_Error.Show();
            }

            // Data Base Connection & Query
            if (classid != "" && subjectname != "")
            {
                HideErrorMessages();

                dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
                dbConnection.Open();

                // CHeck the Status of the save button
                if (MapSubject_SaveBtn_MB.Text == "Save")
                {
                    // Save New Class
                    dbCommand = new SqlCommand("insert into MapSubjectToClass(Id, ClassID, SubjectName) values (@a, @b, @c)", dbConnection);
                    dbCommand.Parameters.AddWithValue("@a", mapclasssubjectid);
                    dbCommand.Parameters.AddWithValue("@b", classid);
                    dbCommand.Parameters.AddWithValue("@c", subjectname);
                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                    MapSubject_Success.Text = "Successfully asigned subject to class";
                    MapSubject_Success.Show();
                    ClearUserInputs();
                    LoadClassSubjectList();
                }
                else
                {
                    // Update Class Details
                    dbCommand = new SqlCommand("update MapSubjectToClass set ClassID=@a, SubjectName=@b where Id=@c", dbConnection);
                    dbCommand.Parameters.AddWithValue("@a", classid);
                    dbCommand.Parameters.AddWithValue("@b", subjectname);
                    dbCommand.Parameters.AddWithValue("@c", GlobalEditID);
                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                    MapSubject_Success.Text = "Successfull Updated the assigned subject";
                    MapSubject_Success.Show();
                    ClearUserInputs();
                    LoadClassSubjectList();
                }
            }
        }

        private void MapSubject_ResetBtn_MB_Click(object sender, EventArgs e)
        {
            ClearUserInputs();
            HideErrorMessages();
            LoadClassList();
            LoadSubjectList();
            LoadClassSubjectList();
        }

        private void MapSubject_ViewData_Search_MB_Click(object sender, EventArgs e)
        {
            // Get User inputs
            String filterby = MapSubject_ViewData_FilterBy_MCB.SelectedItem.ToString();
            String filtervalue = MapSubject_ViewData_SearchValue_MTB.Text;
            String sqlsearchquery = "";

            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();

            switch (filterby)
            {
                case "Subject Name":
                    sqlsearchquery = "select * from MapSubjectToClass where SubjectName like '%" + filtervalue + "%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                case "Class ID":
                    sqlsearchquery = "select * from MapSubjectToClass where ClassID like '%" + filtervalue + "%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                default:
                    sqlsearchquery = "select * from MapSubjectToClass";
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
            MapSubject_ClassName_MTB.Text = item.SubItems[1].Text;
            MapSubject_SubjectName_MTB.Text = item.SubItems[2].Text;
        }
    }
}
