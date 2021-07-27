using System;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace LMUSMSCW1
{
    public partial class ClassDashboard : Form
    {
        // Database Connection
        SqlConnection dbConnection;
        SqlCommand dbCommand;
        SqlDataAdapter dbDataAdapter;

        public ClassDashboard()
        {
            InitializeComponent();
        }

        // Setting Public DataSets
        public static string GlobalClassID;

        // 
        private void ClassDashboard_Dashboard_MLB_Click(object sender, EventArgs e)
        {
            AdminDashboard newAdminDashboard = new AdminDashboard();
            newAdminDashboard.Show();
            this.Hide();
        }

        private void ClassDashboard_Logout_MLB_Click(object sender, EventArgs e)
        {
            LoginForm objLoginForm = new LoginForm();
            objLoginForm.Show();
            this.Hide();
        }

        private void ClassDashboard_ScD_MLB_Click(object sender, EventArgs e)
        {
            SchoolDashboard objSchoolDashboard = new SchoolDashboard();
            objSchoolDashboard.Show();
            this.Hide();
        }

        private void ClassDashboard_CD_MLB_Click(object sender, EventArgs e)
        {
            ClassDashboard objClassDashboard = new ClassDashboard();
            objClassDashboard.Show();
            this.Hide();
        }

        private void ClassDashboard_Logout_MLB_Click_1(object sender, EventArgs e)
        {
            LoginForm objLoginForm = new LoginForm();
            objLoginForm.Show();
            this.Hide();
        }

        private void ClassDashboard_StuD_MLB_Click(object sender, EventArgs e)
        {
            StudentDashboard objStudentDashboard = new StudentDashboard();
            objStudentDashboard.Show();
            this.Hide();
        }

        private void ClassDashboard_StfD_MLB_Click(object sender, EventArgs e)
        {
            StaffDashboard objStaffDashboard = new StaffDashboard();
            objStaffDashboard.Show();
            this.Hide();
        }

        private void ClassDashboard_SubD_MLB_Click(object sender, EventArgs e)
        {
            SubjectDashboard objSubjectDashboard = new SubjectDashboard();
            objSubjectDashboard.Show();
            this.Hide();
        }

        private void ClassDashboard_UD_MLB_Click(object sender, EventArgs e)
        {
            UserDashboard objUserDashboard = new UserDashboard();
            objUserDashboard.Show();
            this.Hide();
        }

        private void SchoolDashboard_BackTDB_MLB_Click(object sender, EventArgs e)
        {
            AdminDashboard objAdminDashboard = new AdminDashboard();
            objAdminDashboard.Hide();
            this.Show();
        }

        private void ClassDashboard_Settings_MLB_Click(object sender, EventArgs e)
        {
            SettingsDashboard objSettingDashboard = new SettingsDashboard();
            objSettingDashboard.Hide();
            this.Show();
        }

        private void OnClassDashboardLoad(object sender, EventArgs e)
        {
            HideErrorMessages();
            ClearUserInputs();

            ClassDashboard_DataTabel_MLV.Columns.Add("Id", 150);
            ClassDashboard_DataTabel_MLV.Columns.Add("Section", 120, HorizontalAlignment.Center);
            ClassDashboard_DataTabel_MLV.Columns.Add("Year", 100, HorizontalAlignment.Center);
            ClassDashboard_DataTabel_MLV.Columns.Add("Grade", 100, HorizontalAlignment.Center);
            ClassDashboard_DataTabel_MLV.Columns.Add("Class Name", 120, HorizontalAlignment.Center);
            ClassDashboard_DataTabel_MLV.Columns.Add("Class Teacher", 150, HorizontalAlignment.Center);
            ClassDashboard_DataTabel_MLV.Columns.Add("Class Monitor", 150, HorizontalAlignment.Center);
            ClassDashboard_DataTabel_MLV.View = View.Details;

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
            }
        }


        // Hide Error Messages
        public void HideErrorMessages()
        {
            ClassDashboard_ErrorYearInput_ML.Hide();
            ClassDashboard_ErrorClassNameInput_ML.Hide();
            ClassDashboard_Success.Hide();
            ClassDashboard_Error.Hide();
        }

        // Clear User Inpits
        public void ClearUserInputs()
        {
            ClassDashboard_SectionInput_MCB.SelectedIndex = 0;
            ClassDashboard_YearInput_MTB.Text = DateTime.Now.Year.ToString();
            ClassDashboard_GradeInput_MCB.SelectedIndex = 0;
            ClassDashboard_ClassNameInput_MTB.Text = "";
            ClassDashboard_ClassTeacherInput_MCB.SelectedIndex = 0;
            ClassDashboard_ClassMonitorInput_MCB.SelectedIndex = 0;
            ClassDashboard_ViewData_FilterBy_MCB.SelectedIndex = 0;
            ClassDashboard_ViewData_SearchValue_MTB.Text = "";
        }

        // Rest The Input Fileds
        private void ClassDashboard_ResetBtn_MB_Click(object sender, EventArgs e)
        {
            HideErrorMessages();
            ClearUserInputs();
            LoadDataToListView();
        }

        private void ClassDashboard_SaveBtn_MB_Click(object sender, EventArgs e)
        {
            HideErrorMessages();

            // Creating the Class ID
            String ClassID = ClassDashboard_YearInput_MTB.Text + ClassDashboard_SectionInput_MCB.SelectedItem.ToString().Substring(0, 1) + "S" + ClassDashboard_GradeInput_MCB.SelectedItem.ToString().Replace(" ", String.Empty) + ClassDashboard_ClassNameInput_MTB.Text;

            // Data User Input Data
            String classid = ClassID;
            String classsection = ClassDashboard_SectionInput_MCB.SelectedItem.ToString();
            int classyear = Int32.Parse(ClassDashboard_YearInput_MTB.Text);
            String classgrade = ClassDashboard_GradeInput_MCB.SelectedItem.ToString();
            String classname = ClassDashboard_ClassNameInput_MTB.Text;
            String classteacher = ClassDashboard_ClassTeacherInput_MCB.SelectedItem.ToString();
            String classmonitor = ClassDashboard_ClassMonitorInput_MCB.SelectedItem.ToString();

            // Input Validation
            if(classyear.ToString() == "")
            {
                ClassDashboard_ErrorYearInput_ML.Show();
            }
            if(classname == "")
            {
                ClassDashboard_ErrorClassNameInput_ML.Show();
            }

            if(classyear.ToString() != "" && classname != "")
            {
                HideErrorMessages();

                dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
                dbConnection.Open();

                // Check for the button state save or update
                if(ClassDashboard_SaveBtn_MB.Text == "Save")
                {
                    // Checking is there any schools
                    dbCommand = new SqlCommand("Select count(*) from Class where Id=@a", dbConnection);
                    dbCommand.Parameters.AddWithValue("@a", classid);
                    int results = Convert.ToInt32(dbCommand.ExecuteScalar());
                    if (results != 0)
                    {
                        dbCommand.ExecuteNonQuery();
                        dbConnection.Close();
                        ClassDashboard_Error.Text = classid + "alreday exsist in the system";
                        ClassDashboard_Error.Show();
                    }
                    else
                    {
                        // Save New Class
                        dbCommand = new SqlCommand("insert into Class(Id, Section, Year, Grade, ClassName, ClassTeacher, ClassMonitor) values (@a, @b, @c, @d, @e, @f, @g)", dbConnection);
                        dbCommand.Parameters.AddWithValue("@a", classid);
                        dbCommand.Parameters.AddWithValue("@b", classsection);
                        dbCommand.Parameters.AddWithValue("@c", classyear);
                        dbCommand.Parameters.AddWithValue("@d", classgrade);
                        dbCommand.Parameters.AddWithValue("@e", classname);
                        dbCommand.Parameters.AddWithValue("@f", classteacher);
                        dbCommand.Parameters.AddWithValue("@g", classmonitor);
                        dbCommand.ExecuteNonQuery();
                        dbConnection.Close();
                        ClassDashboard_Success.Text = "Succes created class" + classid;
                        ClassDashboard_Success.Show();
                        ClearUserInputs();
                        LoadDataToListView();
                    }
                } else
                {
                    // Update Class Details
                    dbCommand = new SqlCommand("update Class set Section=@b, Year=@c, Grade=@d, ClassName=@e, ClassTeacher=@f, ClassMonitor=@g where Id=@a", dbConnection);
                    dbCommand.Parameters.AddWithValue("@a", GlobalClassID);
                    dbCommand.Parameters.AddWithValue("@b", classsection);
                    dbCommand.Parameters.AddWithValue("@c", classyear);
                    dbCommand.Parameters.AddWithValue("@d", classgrade);
                    dbCommand.Parameters.AddWithValue("@e", classname);
                    dbCommand.Parameters.AddWithValue("@f", classteacher);
                    dbCommand.Parameters.AddWithValue("@g", classmonitor);
                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                    ClassDashboard_Success.Text = "Succes Updated the class" + classid;
                    ClassDashboard_Success.Show();
                    ClearUserInputs();
                    LoadDataToListView();
                }
                
            }
        }

        // Load all the class  from database
        public void LoadDataToListView()
        {
            ClassDashboard_DataTabel_MLV.Items.Clear();


            // Select All the Data From DB
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("Select * from Class", dbConnection);
            dbDataAdapter = new SqlDataAdapter(dbCommand);
            DataSet ClassDataSet = new DataSet();
            dbDataAdapter.Fill(ClassDataSet, "testTabel");
            dbConnection.Close();

            DataTable ClassDataTabel = ClassDataSet.Tables["testTabel"];
            int i;
            for (i = 0; i <= ClassDataTabel.Rows.Count - 1; i++)
            {
                ClassDashboard_DataTabel_MLV.Items.Add(ClassDataTabel.Rows[i].ItemArray[0].ToString());
                ClassDashboard_DataTabel_MLV.Items[i].SubItems.Add(ClassDataTabel.Rows[i].ItemArray[1].ToString());
                ClassDashboard_DataTabel_MLV.Items[i].SubItems.Add(ClassDataTabel.Rows[i].ItemArray[2].ToString());
                ClassDashboard_DataTabel_MLV.Items[i].SubItems.Add(ClassDataTabel.Rows[i].ItemArray[3].ToString());
                ClassDashboard_DataTabel_MLV.Items[i].SubItems.Add(ClassDataTabel.Rows[i].ItemArray[4].ToString());
                ClassDashboard_DataTabel_MLV.Items[i].SubItems.Add(ClassDataTabel.Rows[i].ItemArray[5].ToString());
                ClassDashboard_DataTabel_MLV.Items[i].SubItems.Add(ClassDataTabel.Rows[i].ItemArray[6].ToString());
            }
        }

        private void ClassDashboard_DataTabel_MLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClassDashboard_DataTabel_MLV.SelectedItems.Count == 0)
                return;
            ListViewItem item = ClassDashboard_DataTabel_MLV.SelectedItems[0];

            // Setting the Selected Data On Input Fields
            ClassDashboard_SaveBtn_MB.Text = "Update";
            GlobalClassID = item.SubItems[0].Text;

            switch (item.SubItems[1].Text) 
            {
                case "Primary Section":
                    ClassDashboard_SectionInput_MCB.SelectedIndex = 0;
                    break;
                case "Middle School Section":
                    ClassDashboard_SectionInput_MCB.SelectedIndex = 1;
                    break;
                case "Upper School Section":
                    ClassDashboard_SectionInput_MCB.SelectedIndex = 2;
                    break;
                case "A/L Section":
                    ClassDashboard_SectionInput_MCB.SelectedIndex = 3;
                    break;
                default:
                    break;
            }

            ClassDashboard_YearInput_MTB.Text = item.SubItems[2].Text;

            switch(item.SubItems[3].Text)
            {
                case "Grade 1":
                    ClassDashboard_GradeInput_MCB.SelectedIndex = 0;
                    break;
                case "Grade 2":
                    ClassDashboard_GradeInput_MCB.SelectedIndex = 1;
                    break;
                case "Grade 3":
                    ClassDashboard_GradeInput_MCB.SelectedIndex = 2;
                    break;
                case "Grade 4":
                    ClassDashboard_GradeInput_MCB.SelectedIndex = 3;
                    break;
                case "Grade 5":
                    ClassDashboard_GradeInput_MCB.SelectedIndex = 4;
                    break;
                case "Grade 6":
                    ClassDashboard_GradeInput_MCB.SelectedIndex = 5;
                    break;
                case "Grade 7":
                    ClassDashboard_GradeInput_MCB.SelectedIndex = 6;
                    break;
                case "Grade 8":
                    ClassDashboard_GradeInput_MCB.SelectedIndex = 7;
                    break;
                case "Grade 9":
                    ClassDashboard_GradeInput_MCB.SelectedIndex = 8;
                    break;
                case "Grade 10":
                    ClassDashboard_GradeInput_MCB.SelectedIndex = 9;
                    break;
                case "Grade 11":
                    ClassDashboard_GradeInput_MCB.SelectedIndex = 10;
                    break;
                case "Grade 12":
                    ClassDashboard_GradeInput_MCB.SelectedIndex = 11;
                    break;
                case "Grade 13":
                    ClassDashboard_GradeInput_MCB.SelectedIndex = 12;
                    break;
                default:
                    break;
            }

            ClassDashboard_ClassNameInput_MTB.Text = item.SubItems[4].Text;
        }


        // Search Filter & Search Button Function
        private void ClassDashboard_ViewData_Search_MB_Click(object sender, EventArgs e)
        {
            // Get User inputs
            String filterby = ClassDashboard_ViewData_FilterBy_MCB.SelectedItem.ToString();
            String filtervalue = ClassDashboard_ViewData_SearchValue_MTB.Text;
            string sqlsearchquery = "";

            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();

            switch(filterby)
            {
                case "Section":
                    sqlsearchquery = "select * from class where Section like '%"+ filtervalue +"%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                case "Year":
                    sqlsearchquery = "select * from class where Year like '%" + filtervalue + "%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                case "Grade":
                    sqlsearchquery = "select * from class where Grade like '%" + filtervalue + "%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                case "ClassName":
                    sqlsearchquery = "select * from class where ClassName like '%" + filtervalue + "%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                default:
                    sqlsearchquery = "select * from class";
                    searchbyfilterfunction(sqlsearchquery);
                    break;

            }
        }

        // Comon Search Function
        public void searchbyfilterfunction(string sqlsearchquery)
        {
            ClassDashboard_DataTabel_MLV.Items.Clear();


            // Select All the Data From DB
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand(sqlsearchquery, dbConnection);
            dbDataAdapter = new SqlDataAdapter(dbCommand);
            DataSet ClassDataSet = new DataSet();
            dbDataAdapter.Fill(ClassDataSet, "testTabel");
            dbConnection.Close();

            DataTable ClassDataTabel = ClassDataSet.Tables["testTabel"];
            int i;
            for (i = 0; i <= ClassDataTabel.Rows.Count - 1; i++)
            {
                ClassDashboard_DataTabel_MLV.Items.Add(ClassDataTabel.Rows[i].ItemArray[0].ToString());
                ClassDashboard_DataTabel_MLV.Items[i].SubItems.Add(ClassDataTabel.Rows[i].ItemArray[1].ToString());
                ClassDashboard_DataTabel_MLV.Items[i].SubItems.Add(ClassDataTabel.Rows[i].ItemArray[2].ToString());
                ClassDashboard_DataTabel_MLV.Items[i].SubItems.Add(ClassDataTabel.Rows[i].ItemArray[3].ToString());
                ClassDashboard_DataTabel_MLV.Items[i].SubItems.Add(ClassDataTabel.Rows[i].ItemArray[4].ToString());
                ClassDashboard_DataTabel_MLV.Items[i].SubItems.Add(ClassDataTabel.Rows[i].ItemArray[5].ToString());
                ClassDashboard_DataTabel_MLV.Items[i].SubItems.Add(ClassDataTabel.Rows[i].ItemArray[6].ToString());
            }
        }

    }
}
