using System.Windows.Forms;
using System.Data.Sql;
using System;
using System.Data.SqlClient;
using System.Data;

namespace LMUSMSCW1
{
    public partial class StudentDashboard : Form
    {
        // Database Connection
        SqlConnection dbConnection;
        SqlCommand dbCommand;
        SqlDataAdapter dbDataAdapter;

        public StudentDashboard()
        {
            InitializeComponent();
        }

        // Setting Public DataSets
        public static string GlobalStudentID;

        // School Dashboard Button
        private void StudentDashboard_ScD_MLB_Click(object sender, System.EventArgs e)
        {
            SchoolDashboard objSchoolDashboard = new SchoolDashboard();
            objSchoolDashboard.Show();
            this.Hide();
        }

        // Class Dashboard Button
        private void StudentDashboard_CD_MLB_Click(object sender, System.EventArgs e)
        {
            ClassDashboard objClassDashboard = new ClassDashboard();
            objClassDashboard.Show();
            this.Hide();
        }

        // Student Dashboard Button
        private void StudentDashboard_StuD_MLB_Click(object sender, System.EventArgs e)
        {
            StudentDashboard objStudentDashboard = new StudentDashboard();
            objStudentDashboard.Show();
            this.Hide();
        }

        // Staff Dashboard Button
        private void StudentDashboard_StfD_MLB_Click(object sender, System.EventArgs e)
        {
            StaffDashboard objStaffDashboard = new StaffDashboard();
            objStaffDashboard.Show();
            this.Hide();
        }

        // Subject Dashboard Button
        private void StudentDashboard_SubD_MLB_Click(object sender, System.EventArgs e)
        {
            StudentDashboard objStudentDashboard = new StudentDashboard();
            objStudentDashboard.Show();
            this.Hide();
        }

        // User Dashboard Button
        private void StudentDashboard_UD_MLB_Click(object sender, System.EventArgs e)
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

        // Main Dashboard Button
        private void StudentDashboard_BackTDB_MLB_Click(object sender, System.EventArgs e)
        {
            AdminDashboard objAdminDashboard = new AdminDashboard();
            objAdminDashboard.Show();
            this.Hide();
        }

        // Settings Button
        private void StudentDashboard_Settings_MLB_Click(object sender, System.EventArgs e)
        {
            SettingsDashboard objSettingDashboard = new SettingsDashboard();
            objSettingDashboard.Show();
            this.Hide();
        }

        // Logout Button
        private void StudentDashboard_Logout_MLB_Click(object sender, System.EventArgs e)
        {
            LoginForm objLoginForm = new LoginForm();
            objLoginForm.Show();
            this.Hide();
        }

        // Clear User Input Function
        public void ClearUserInputs()
        {
            StudentDashboard_StudentNameInput_MTB.Text = "";
            StudentDashboard_GenderInput_MCB.SelectedIndex = 0;
            StudentDashboard_AddressInput_MTB.Text = "";
            StudentDashboard_ContactNumberInput_MTB.Text = "";
            StudentDashboard_GuradianInput_MTB.Text = "";
            StudentDashboard_GuradianNameInput_MTB.Text = "";
            StudentDashboard_GuradianContactInput_MTB.Text = "";
            StudentDashboard_MedicalNotesInput_MTB.Text = "";
            StudentDashboard_SpecialNotesInput_MTB.Text = "";
            StudentDashboard_ViewData_FilterBy_MCB.SelectedIndex = 0;
            StudentDashboard_ViewData_SearchValue_MTB.Text = "";
            StudentDashboard_DOBInput_DP.MaxDate = DateTime.Today;
            StudentDashboard_DOBInput_DP.Value = DateTime.Today;
        }

        // Hide Error Messages
        public void HideErrorMessages()
        {
            StudentDashboard_StudentName_Error_ML.Hide();
            StudentDashboard_Gender_Error_ML.Hide();
            StudentDashboard_Address_Error_ML.Hide();
            StudentDashboard_ContactNumber_Error_ML.Hide();
            StudentDashboard_Guradian_Error_ML.Hide();
            StudentDashboard_GuradianName_Error_ML.Hide();
            StudentDashboard_Error.Hide();
            StudentDashboard_Success.Hide();
        }

        // On Student Dashboard Load
        private void StudentDashboard_Load(object sender, System.EventArgs e)
        {
            HideErrorMessages();
            ClearUserInputs();

            StudentDashboard_DataTabel_MLV.Columns.Add("Id", 50);
            StudentDashboard_DataTabel_MLV.Columns.Add("Student Name", 100, HorizontalAlignment.Center);
            StudentDashboard_DataTabel_MLV.Columns.Add("DOB", 100, HorizontalAlignment.Center);
            StudentDashboard_DataTabel_MLV.Columns.Add("Gender", 100, HorizontalAlignment.Center);
            StudentDashboard_DataTabel_MLV.Columns.Add("Address", 120, HorizontalAlignment.Center);
            StudentDashboard_DataTabel_MLV.Columns.Add("Contact Number", 150, HorizontalAlignment.Center);
            StudentDashboard_DataTabel_MLV.Columns.Add("Guradian", 150, HorizontalAlignment.Center);
            StudentDashboard_DataTabel_MLV.Columns.Add("Guradian Name", 150, HorizontalAlignment.Center);
            StudentDashboard_DataTabel_MLV.Columns.Add("Guradian Contact Number", 150, HorizontalAlignment.Center);
            StudentDashboard_DataTabel_MLV.Columns.Add("Medical Notes", 150, HorizontalAlignment.Center);
            StudentDashboard_DataTabel_MLV.Columns.Add("Special Notes", 150, HorizontalAlignment.Center);
            StudentDashboard_DataTabel_MLV.View = View.Details;

            // Check Wether Alreday there is a school created
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("Select count(*) from Students", dbConnection);
            int results = (int)dbCommand.ExecuteScalar();
            dbCommand.ExecuteNonQuery();
            dbConnection.Close();
            if (results != 0)
            {
                LoadDataToListView();
            }
        }

        // Load Student Data To List View
        public void LoadDataToListView()
        {
            StudentDashboard_DataTabel_MLV.Items.Clear();


            // Select All the Data From DB
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("Select * from Students", dbConnection);
            dbDataAdapter = new SqlDataAdapter(dbCommand);
            DataSet StudentDataSet = new DataSet();
            dbDataAdapter.Fill(StudentDataSet, "testTabel");
            dbConnection.Close();

            DataTable StudentDataTabel = StudentDataSet.Tables["testTabel"];
            int i;
            for (i = 0; i <= StudentDataTabel.Rows.Count - 1; i++)
            {
                StudentDashboard_DataTabel_MLV.Items.Add(StudentDataTabel.Rows[i].ItemArray[0].ToString());
                StudentDashboard_DataTabel_MLV.Items[i].SubItems.Add(StudentDataTabel.Rows[i].ItemArray[1].ToString());
                StudentDashboard_DataTabel_MLV.Items[i].SubItems.Add(StudentDataTabel.Rows[i].ItemArray[2].ToString());
                StudentDashboard_DataTabel_MLV.Items[i].SubItems.Add(StudentDataTabel.Rows[i].ItemArray[3].ToString());
                StudentDashboard_DataTabel_MLV.Items[i].SubItems.Add(StudentDataTabel.Rows[i].ItemArray[4].ToString());
                StudentDashboard_DataTabel_MLV.Items[i].SubItems.Add(StudentDataTabel.Rows[i].ItemArray[5].ToString());
                StudentDashboard_DataTabel_MLV.Items[i].SubItems.Add(StudentDataTabel.Rows[i].ItemArray[6].ToString());
                StudentDashboard_DataTabel_MLV.Items[i].SubItems.Add(StudentDataTabel.Rows[i].ItemArray[7].ToString());
                StudentDashboard_DataTabel_MLV.Items[i].SubItems.Add(StudentDataTabel.Rows[i].ItemArray[8].ToString());
                StudentDashboard_DataTabel_MLV.Items[i].SubItems.Add(StudentDataTabel.Rows[i].ItemArray[9].ToString());
                StudentDashboard_DataTabel_MLV.Items[i].SubItems.Add(StudentDataTabel.Rows[i].ItemArray[10].ToString());
            }
        }

        // Student Dashboard Rest Button
        private void StudentDashboard_ResetBtn_MB_Click(object sender, System.EventArgs e)
        {
            ClearUserInputs();
            HideErrorMessages();
        }

        private void StudentDashboard_SaveBtn_MB_Click(object sender, System.EventArgs e)
        {
            HideErrorMessages();

            // Gather User Input Values
            string studentname = StudentDashboard_StudentNameInput_MTB.Text;
            //string studentdob = StudentDashboard_DOBInput_DP.Text;
            string studentgender = StudentDashboard_GenderInput_MCB.SelectedItem.ToString();
            string studentaddress = StudentDashboard_AddressInput_MTB.Text;
            string studentcontactnumber = StudentDashboard_ContactNumberInput_MTB.Text;
            string studentguradian = StudentDashboard_GuradianInput_MTB.Text;
            string studentguradinaname = StudentDashboard_GuradianNameInput_MTB.Text;
            string studentguradiancontactnumber = StudentDashboard_GuradianContactInput_MTB.Text;
            string studentmediacalnaotes = StudentDashboard_MedicalNotesInput_MTB.Text;
            string studentspecialnotes = StudentDashboard_SpecialNotesInput_MTB.Text;

            // Input Fields Validation
            if(studentname == "")
            {
                StudentDashboard_StudentName_Error_ML.Show();
            }
            if (studentaddress == "")
            {
                StudentDashboard_Address_Error_ML.Show();
            }
            if (studentcontactnumber == "")
            {
                StudentDashboard_ContactNumber_Error_ML.Show();
            }
            if (studentguradian == "")
            {
                StudentDashboard_Guradian_Error_ML.Show();
            }
            if (studentguradinaname == "")
            {
                StudentDashboard_GuradianName_Error_ML.Show();
            }

            // Data Base Connection & Query
            if(studentname != "" && studentaddress != "" && studentcontactnumber != "" && studentguradian != "" && studentguradinaname != "") 
            {
                HideErrorMessages();

                dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
                dbConnection.Open();

                // CHeck the Status of the save button
                if (StudentDashboard_SaveBtn_MB.Text == "Save")
                {
                    // Save New Class
                    dbCommand = new SqlCommand("insert into Students(FullName, DOB, Gender, Address, ContactNumber, Guradian, GuradianName, GuradiansContactNumber, MedicalNotes, SpecialNotes) values (@a, @b, @c, @d, @e, @f, @g, @h, @i, @j)", dbConnection);
                    dbCommand.Parameters.AddWithValue("@a", studentname);
                    dbCommand.Parameters.AddWithValue("@b", StudentDashboard_DOBInput_DP.Value);
                    dbCommand.Parameters.AddWithValue("@c", studentgender);
                    dbCommand.Parameters.AddWithValue("@d", studentaddress);
                    dbCommand.Parameters.AddWithValue("@e", studentcontactnumber);
                    dbCommand.Parameters.AddWithValue("@f", studentguradian);
                    dbCommand.Parameters.AddWithValue("@g", studentguradinaname);
                    dbCommand.Parameters.AddWithValue("@h", studentguradiancontactnumber);
                    dbCommand.Parameters.AddWithValue("@i", studentmediacalnaotes);
                    dbCommand.Parameters.AddWithValue("@j", studentspecialnotes);
                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                    StudentDashboard_Success.Text = "New student is added to the system";
                    StudentDashboard_Success.Show();
                    ClearUserInputs();
                    LoadDataToListView();
                }
                else
                {
                    // Update Class Details
                    dbCommand = new SqlCommand("update Students set FullName=@a, DOB=@b, Gender=@c, Address=@d, ContactNumber=@e, Guradian=@f, GuradianName=@g, GuradiansContactNumber=@h, MedicalNotes=@i, SpecialNotes=@j where Id=@k", dbConnection);
                    dbCommand.Parameters.AddWithValue("@a", studentname);
                    dbCommand.Parameters.AddWithValue("@b", StudentDashboard_DOBInput_DP.Value);
                    dbCommand.Parameters.AddWithValue("@c", studentgender);
                    dbCommand.Parameters.AddWithValue("@d", studentaddress);
                    dbCommand.Parameters.AddWithValue("@e", studentcontactnumber);
                    dbCommand.Parameters.AddWithValue("@f", studentguradian);
                    dbCommand.Parameters.AddWithValue("@g", studentguradinaname);
                    dbCommand.Parameters.AddWithValue("@h", studentguradiancontactnumber);
                    dbCommand.Parameters.AddWithValue("@i", studentmediacalnaotes);
                    dbCommand.Parameters.AddWithValue("@j", studentspecialnotes);
                    dbCommand.Parameters.AddWithValue("@k", GlobalStudentID);
                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                    StudentDashboard_Success.Text = "Successfull Updated the student details";
                    StudentDashboard_Success.Show();
                    ClearUserInputs();
                    LoadDataToListView();
                }
            }
        }

        private void StudentDashboard_DataTabel_MLV_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (StudentDashboard_DataTabel_MLV.SelectedItems.Count == 0)
                return;
            ListViewItem item = StudentDashboard_DataTabel_MLV.SelectedItems[0];

            // Setting the Selected Data On Input Fields
            StudentDashboard_SaveBtn_MB.Text = "Update";
            GlobalStudentID = item.SubItems[0].Text;
            StudentDashboard_DOBInput_DP.Value = System.Convert.ToDateTime(item.SubItems[2].Text);

            StudentDashboard_StudentNameInput_MTB.Text = item.SubItems[1].Text;
            switch(item.SubItems[3].Text)
            {
                case "Male":
                    StudentDashboard_GenderInput_MCB.SelectedIndex = 0;
                    break;
                case "Female":
                    StudentDashboard_GenderInput_MCB.SelectedIndex = 1;
                    break;
                default:
                    break;
            }
            StudentDashboard_AddressInput_MTB.Text = item.SubItems[4].Text;
            StudentDashboard_ContactNumberInput_MTB.Text = item.SubItems[5].Text;
            StudentDashboard_GuradianInput_MTB.Text = item.SubItems[6].Text;
            StudentDashboard_GuradianNameInput_MTB.Text = item.SubItems[7].Text;
            StudentDashboard_GuradianContactInput_MTB.Text = item.SubItems[8].Text;
            StudentDashboard_MedicalNotesInput_MTB.Text = item.SubItems[9].Text;
            StudentDashboard_SpecialNotesInput_MTB.Text = item.SubItems[10].Text;
        }

        private void StudentDashboard_ViewData_Search_MB_Click(object sender, System.EventArgs e)
        {
            // Get User inputs
            String filterby = StudentDashboard_ViewData_FilterBy_MCB.SelectedItem.ToString();
            String filtervalue = StudentDashboard_ViewData_SearchValue_MTB.Text;
            String sqlsearchquery = "";

            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();

            switch (filterby)
            {
                case "Name":
                    sqlsearchquery = "select * from Students where FullName like '%" + filtervalue + "%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                case "Gender":
                    sqlsearchquery = "select * from Students where Gender like '%" + filtervalue + "%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                case "Address":
                    sqlsearchquery = "select * from Students where Address like '%" + filtervalue + "%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                case "DOB":
                    sqlsearchquery = "select * from Students where DOB like '%" + filtervalue + "%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                default:
                    sqlsearchquery = "select * from Students";
                    searchbyfilterfunction(sqlsearchquery);
                    break;

            }
        }

        // Comon Search Function
        public void searchbyfilterfunction(string sqlsearchquery)
        {
            StudentDashboard_DataTabel_MLV.Items.Clear();


            // Select All the Data From DB
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand(sqlsearchquery, dbConnection);
            dbDataAdapter = new SqlDataAdapter(dbCommand);
            DataSet StudentDataSet = new DataSet();
            dbDataAdapter.Fill(StudentDataSet, "testTabel");
            dbConnection.Close();

            DataTable StudentDataTabel = StudentDataSet.Tables["testTabel"];
            int i;
            for (i = 0; i <= StudentDataTabel.Rows.Count - 1; i++)
            {
                StudentDashboard_DataTabel_MLV.Items.Add(StudentDataTabel.Rows[i].ItemArray[0].ToString());
                StudentDashboard_DataTabel_MLV.Items[i].SubItems.Add(StudentDataTabel.Rows[i].ItemArray[1].ToString());
                StudentDashboard_DataTabel_MLV.Items[i].SubItems.Add(StudentDataTabel.Rows[i].ItemArray[2].ToString());
                StudentDashboard_DataTabel_MLV.Items[i].SubItems.Add(StudentDataTabel.Rows[i].ItemArray[3].ToString());
                StudentDashboard_DataTabel_MLV.Items[i].SubItems.Add(StudentDataTabel.Rows[i].ItemArray[4].ToString());
                StudentDashboard_DataTabel_MLV.Items[i].SubItems.Add(StudentDataTabel.Rows[i].ItemArray[5].ToString());
                StudentDashboard_DataTabel_MLV.Items[i].SubItems.Add(StudentDataTabel.Rows[i].ItemArray[6].ToString());
                StudentDashboard_DataTabel_MLV.Items[i].SubItems.Add(StudentDataTabel.Rows[i].ItemArray[7].ToString());
                StudentDashboard_DataTabel_MLV.Items[i].SubItems.Add(StudentDataTabel.Rows[i].ItemArray[8].ToString());
                StudentDashboard_DataTabel_MLV.Items[i].SubItems.Add(StudentDataTabel.Rows[i].ItemArray[9].ToString());
                StudentDashboard_DataTabel_MLV.Items[i].SubItems.Add(StudentDataTabel.Rows[i].ItemArray[10].ToString());
            }
        }

        private void StudentDashboard_Success_Click(object sender, EventArgs e)
        {

        }

        private void StudentDashboard_Error_Click(object sender, EventArgs e)
        {

        }
    }
}
