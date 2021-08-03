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
    public partial class ExamResults : Form
    {
        // Database Connection
        SqlConnection dbConnection;
        SqlCommand dbCommand;

        SqlDataAdapter dbDataAdapter;
        public ExamResults()
        {
            InitializeComponent();
            HideErrorMessages();
            ClearUserInputs();
        }

        // Setting Public DataSets
        public static string GlobalClassID = "";
        public static string GLobalSelectedID;
        public static string GlobalEditID;

        // Hide Error Messages
        public void HideErrorMessages()
        {
            ExamResults_ClassID_Error.Hide();
            ExamResults_StudentName_Error.Hide();
            ExamResults_SubjectName_Error.Hide();
            ExamResults_Marks_Error.Hide();
            MapStudent_Error.Hide();
            MapStudent_Success.Hide();
        }

        // Clear User Inputs
        public void ClearUserInputs()
        {
            ExamResults_ClassID_MTB.Text = "";
            ExamResults_StudentName_MTB.Text = "";
            ExamResults_SubjectName_MTB.Text = "";
            ExamResults_Marks_MTB.Text = "";
            MapStudent_ViewData_FilterBy_MCB.SelectedIndex = 0;
            MapStudent_ViewData_SearchValue_MTB.Text = "";
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

        private void ExamResults_Load(object sender, EventArgs e)
        {
            ClearUserInputs();
            HideErrorMessages();

            // Set Student Class List Liveview
            MapStudent_ClassName_MLV.Columns.Add("Id", 200);
            MapStudent_ClassName_MLV.Columns.Add("Class ID", 200, HorizontalAlignment.Center);
            MapStudent_ClassName_MLV.Columns.Add("Student Name", 200, HorizontalAlignment.Center);
            MapStudent_ClassName_MLV.View = View.Details;
            LoadStudentClassList();

            // Set Subject Liveview
            MapStudent_StudentName_MLV.Columns.Add("Id", 200);
            MapStudent_StudentName_MLV.Columns.Add("Subject Name", 300, HorizontalAlignment.Center);
            MapStudent_StudentName_MLV.View = View.Details;
            LoadSubjectList();

            // Set Map Subject TO CLass Liveview
            MapSubject_FullDataListView_MLV.Columns.Add("Id", 200);
            MapSubject_FullDataListView_MLV.Columns.Add("Class ID", 300, HorizontalAlignment.Center);
            MapSubject_FullDataListView_MLV.Columns.Add("Student Name", 300, HorizontalAlignment.Center);
            MapSubject_FullDataListView_MLV.Columns.Add("Subject Name", 300, HorizontalAlignment.Center);
            MapSubject_FullDataListView_MLV.Columns.Add("Marks", 200, HorizontalAlignment.Center);
            MapSubject_FullDataListView_MLV.View = View.Details;
            LoadMarksList();
        }

        public void LoadStudentClassList()
        {
            MapStudent_ClassName_MLV.Items.Clear();


            // Select All the Data From DB
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("Select * from MapStudentToClass", dbConnection);
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
            }
        }

        public void LoadSubjectList()
        {
            MapStudent_StudentName_MLV.Items.Clear();


            // Select All the Data From DB
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            if(GlobalClassID == "")
            {
                dbCommand = new SqlCommand("Select Id, SubjectName from MapSubjectToClass", dbConnection);
            }
            else
            {
                dbCommand = new SqlCommand("Select Id, SubjectName from MapSubjectToClass where ClassID=@a", dbConnection);
                dbCommand.Parameters.AddWithValue("@a", GlobalClassID);
            }
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
            }
            //GlobalClassID = "";
        }

        public void LoadMarksList()
        {
            MapSubject_FullDataListView_MLV.Items.Clear();


            // Select All the Data From DB
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("Select * from ExamResults", dbConnection);
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
                MapSubject_FullDataListView_MLV.Items[i].SubItems.Add(ClassSubjectDataTabel.Rows[i].ItemArray[3].ToString());
                MapSubject_FullDataListView_MLV.Items[i].SubItems.Add(ClassSubjectDataTabel.Rows[i].ItemArray[4].ToString());
            }
        }

        private void MapStudent_ClassName_MLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MapStudent_ClassName_MLV.SelectedItems.Count == 0)
                return;
            ListViewItem item = MapStudent_ClassName_MLV.SelectedItems[0];

            // Setting the Selected Data On Input Fields
            GlobalClassID = item.SubItems[1].Text;
            ExamResults_ClassID_MTB.Text = item.SubItems[1].Text;
            ExamResults_StudentName_MTB.Text = item.SubItems[2].Text;
            LoadSubjectList();
        }

        private void MapStudent_StudentName_MLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MapStudent_StudentName_MLV.SelectedItems.Count == 0)
                return;
            ListViewItem item = MapStudent_StudentName_MLV.SelectedItems[0];

            // Setting the Selected Data On Input Fields
            ExamResults_SubjectName_MTB.Text = item.SubItems[1].Text;
        }

        private void MapSubject_ResetBtn_MB_Click(object sender, EventArgs e)
        {
            ClearUserInputs();
            HideErrorMessages();
            LoadStudentClassList(); 
            LoadSubjectList();
            LoadMarksList();
        }

        private void MapSubject_SaveBtn_MB_Click(object sender, EventArgs e)
        {
            HideErrorMessages();

            // Gather User Input Values
            string classid = ExamResults_ClassID_MTB.Text;
            string studentname = ExamResults_StudentName_MTB.Text;
            string subjectname = ExamResults_SubjectName_MTB.Text;
            string marks = ExamResults_Marks_MTB.Text;

            // Input Fields Validation
            if (classid == "")
            {
                ExamResults_ClassID_Error.Show();
            }
            if (studentname == "")
            {
                ExamResults_StudentName_Error.Show();
            }
            if (subjectname == "")
            {
                ExamResults_SubjectName_Error.Show();
            }
            if (marks == "")
            {
                ExamResults_Marks_Error.Show();
            }

            // Data Base Connection & Query
            if (classid != "" && studentname != "" && subjectname != "" && marks != "")
            {
                HideErrorMessages();

                dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
                dbConnection.Open();

                // CHeck the Status of the save button
                if (MapSubject_SaveBtn_MB.Text == "Save")
                {
                    // Save New Class
                    dbCommand = new SqlCommand("insert into ExamResults(ClassID,StudentName,SubjectName,Marks) values (@a, @b, @c, @d)", dbConnection);
                    dbCommand.Parameters.AddWithValue("@a", classid);
                    dbCommand.Parameters.AddWithValue("@b", studentname);
                    dbCommand.Parameters.AddWithValue("@c", subjectname);
                    dbCommand.Parameters.AddWithValue("@d", marks);
                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                    MapStudent_Success.Text = "Exams results recorded";
                    MapStudent_Success.Show();
                    ClearUserInputs();
                    LoadMarksList();
                }
                else
                {
                    // Update Class Details
                    dbCommand = new SqlCommand("update ExamResults set StudentName=@a ,SubjectName=@b,Marks=@c where Id=@d", dbConnection);
                    dbCommand.Parameters.AddWithValue("@a", studentname);
                    dbCommand.Parameters.AddWithValue("@b", subjectname);
                    dbCommand.Parameters.AddWithValue("@c", marks);
                    dbCommand.Parameters.AddWithValue("@d", GlobalEditID);
                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                    MapStudent_Success.Text = "Exams results updated";
                    MapStudent_Success.Show();
                    ClearUserInputs();
                    LoadMarksList();
                }
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
            ExamResults_ClassID_MTB.Text = item.SubItems[1].Text;
            ExamResults_StudentName_MTB.Text = item.SubItems[2].Text;
            ExamResults_SubjectName_MTB.Text = item.SubItems[3].Text;
            ExamResults_Marks_MTB.Text = item.SubItems[4].Text;

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
                MapSubject_FullDataListView_MLV.Items[i].SubItems.Add(ClassSubjectDataTabel.Rows[i].ItemArray[3].ToString());
                MapSubject_FullDataListView_MLV.Items[i].SubItems.Add(ClassSubjectDataTabel.Rows[i].ItemArray[4].ToString());
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
                    sqlsearchquery = "select * from ExamResults where StudentName like '%" + filtervalue + "%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                case "Class ID":
                    sqlsearchquery = "select * from ExamResults where ClassID like '%" + filtervalue + "%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                case "Subject Name":
                    sqlsearchquery = "select * from ExamResults where SubjectName like '%" + filtervalue + "%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                default:
                    sqlsearchquery = "select * from ExamResults";
                    searchbyfilterfunction(sqlsearchquery);
                    break;

            }
        }
    }
}
