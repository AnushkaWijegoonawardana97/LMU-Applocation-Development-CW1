using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace LMUSMSCW1
{
    public partial class StaffDashboard : Form
    {
        // Database Connection
        SqlConnection dbConnection;
        SqlCommand dbCommand;
        SqlDataAdapter dbDataAdapter;

        public StaffDashboard()
        {
            InitializeComponent();
        }

        // Setting Public DataSets
        public static string GlobalStaffID;

        // School Dashboard Button
        private void StaffDashboard_ScD_MLB_Click(object sender, EventArgs e)
        {
            SchoolDashboard objSchoolDashboard = new SchoolDashboard();
            objSchoolDashboard.Show();
            this.Hide();
        }

        // class Dashboard Button
        private void StaffDashboard_CD_MLB_Click(object sender, EventArgs e)
        {
            ClassDashboard objClassDashboard = new ClassDashboard();
            objClassDashboard.Show();
            this.Hide();
        }

        // Student Dashboard Button
        private void StaffDashboard_StuD_MLB_Click(object sender, EventArgs e)
        {
            StudentDashboard objStudentDashboard = new StudentDashboard();
            objStudentDashboard.Show();
            this.Hide();
        }

        // Staff Dashboard Button
        private void StaffDashboard_StfD_MLB_Click(object sender, EventArgs e)
        {
            StaffDashboard objStaffDashboard = new StaffDashboard();
            objStaffDashboard.Show();
            this.Hide();
        }

        // Subject Dashboard Button
        private void StaffDashboard_SubD_MLB_Click(object sender, EventArgs e)
        {
            SubjectDashboard objSubjectDashboard = new SubjectDashboard();
            objSubjectDashboard.Show();
            this.Hide();
        }

        // User Dashboard Button
        private void StaffDashboard_UD_MLB_Click(object sender, EventArgs e)
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

        // Back to Main Dashboard Button
        private void StaffDashboard_BackTDB_MLB_Click(object sender, EventArgs e)
        {
            AdminDashboard objAdminDashboard = new AdminDashboard();
            objAdminDashboard.Hide();
            this.Show();
        }


        // Settings Dashboard Button
        private void StaffDashboard_Settings_MLB_Click(object sender, EventArgs e)
        {
            SettingsDashboard objSettingDashboard = new SettingsDashboard();
            objSettingDashboard.Show();
            this.Hide();
        }

        // Logout Button
        private void StaffDashboard_Logout_MLB_Click(object sender, EventArgs e)
        {
            LoginForm objLoginForm = new LoginForm();
            objLoginForm.Show();
            this.Hide();
        }

        // Staff Dashboard On Loading Function
        private void StaffDashboard_Load(object sender, EventArgs e)
        {
            HideErrorMessages();
            ClearInputFields();

            // Creating the Tabs in the list view
            StaffDashboard_DataTabel_MLV.Columns.Add("Id", 50);
            StaffDashboard_DataTabel_MLV.Columns.Add("Full Name", 150, HorizontalAlignment.Center);
            StaffDashboard_DataTabel_MLV.Columns.Add("DOB", 150, HorizontalAlignment.Center);
            StaffDashboard_DataTabel_MLV.Columns.Add("Gender", 150, HorizontalAlignment.Center);
            StaffDashboard_DataTabel_MLV.Columns.Add("Address", 150, HorizontalAlignment.Center);
            StaffDashboard_DataTabel_MLV.Columns.Add("Contact Number", 150, HorizontalAlignment.Center);
            StaffDashboard_DataTabel_MLV.Columns.Add("Email", 150, HorizontalAlignment.Center);
            StaffDashboard_DataTabel_MLV.Columns.Add("NIC", 150, HorizontalAlignment.Center);
            StaffDashboard_DataTabel_MLV.Columns.Add("Last Service", 150, HorizontalAlignment.Center);
            StaffDashboard_DataTabel_MLV.Columns.Add("Joined Date", 150, HorizontalAlignment.Center);
            StaffDashboard_DataTabel_MLV.Columns.Add("HE Qulification", 150, HorizontalAlignment.Center);
            StaffDashboard_DataTabel_MLV.Columns.Add("Qulification", 150, HorizontalAlignment.Center);
            StaffDashboard_DataTabel_MLV.Columns.Add("Specilized Subjects", 150, HorizontalAlignment.Center);
            StaffDashboard_DataTabel_MLV.Columns.Add("Admin Account State", 150, HorizontalAlignment.Center);
            StaffDashboard_DataTabel_MLV.View = View.Details;

            // Check Wether Alreday there is a Staff Members created
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("Select count(*) from StaffMember", dbConnection);
            int results = (int)dbCommand.ExecuteScalar();
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
            StaffDashboard_StaffNameInput_Error.Hide();
            StaffDashboard_AddressInput_Error.Hide();
            StaffDashboard_ContactNumberInput_Error.Hide();
            StaffDashboard_EmailInput_Error.Hide();
            StaffDashboard_NICInput_Error.Hide();
            StaffDashboard_SpecilizedSubjectsInput_Error.Hide();
            StaffDashboard_Error.Hide();
            StaffDashboard_Success.Hide();
        }

        // Clear Input Fields Function
        public void ClearInputFields()
        {
            StaffDashboard_StaffNameInput_MTB.Text = "";
            StaffDashboard_DOBInput_DP.MaxDate = DateTime.Today;
            StaffDashboard_DOBInput_DP.Value = DateTime.Today;
            StaffDashboard_GenderInput_MCB.SelectedIndex = 0;
            StaffDashboard_AddressInput_MTB.Text = "";
            StaffDashboard_ContactNumberInput_MTB.Text = "";
            StaffDashboard_EmailInput_MTB.Text = "";
            StaffDashboard_NICInput_MTB.Text = "";
            StaffDashboard_LastServiceInput_MTB.Text = "";
            StaffDashboard_JoinDateInput_MTB.Text = DateTime.UtcNow.ToString();
            StaffDashboard_HEQulificationInput_MTB.Text = "";
            StaffDashboard_QulificationsInput_MTB.Text = "";
            StaffDashboard_SpecilizedSubjectsInput_MTB.Text = "";
            StaffDashboard_ViewData_FilterBy_MCB.Text = "";
            StaffDashboard_ViewData_SearchValue_MTB.Text = "";

        }

        // Load Staff Member Data To List View
        public void LoadDataToListView()
        {
            StaffDashboard_DataTabel_MLV.Items.Clear();


            // Select All the Data From DB
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("Select * from StaffMember", dbConnection);
            dbDataAdapter = new SqlDataAdapter(dbCommand);
            DataSet StaffDataSet = new DataSet();
            dbDataAdapter.Fill(StaffDataSet, "testTabel");
            dbConnection.Close();

            DataTable StaffDataTabel = StaffDataSet.Tables["testTabel"];
            int i;
            for (i = 0; i <= StaffDataTabel.Rows.Count - 1; i++)
            {
                StaffDashboard_DataTabel_MLV.Items.Add(StaffDataTabel.Rows[i].ItemArray[0].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[1].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[2].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[3].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[4].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[5].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[6].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[7].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[8].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[9].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[10].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[11].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[12].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[13].ToString());
            }
        }

        // Rest Button Function
        private void StaffDashboard_ResetBtn_MB_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            HideErrorMessages();
        }

        // Save & Update BUtton Function
        private void StaffDashboard_SaveBtn_MB_Click(object sender, EventArgs e)
        {
            HideErrorMessages();

            // Gather User Input Values
            string staffname = StaffDashboard_StaffNameInput_MTB.Text;
            string staffgender = StaffDashboard_GenderInput_MCB.SelectedItem.ToString();
            string staffaddress = StaffDashboard_AddressInput_MTB.Text;
            string staffcontactnumber = StaffDashboard_ContactNumberInput_MTB.Text;
            string staffemail = StaffDashboard_EmailInput_MTB.Text;
            string staffnic = StaffDashboard_NICInput_MTB.Text;
            string stafflastservice = StaffDashboard_LastServiceInput_MTB.Text;
            string staffjoindate = StaffDashboard_JoinDateInput_MTB.Text;
            string staffhequlification = StaffDashboard_HEQulificationInput_MTB.Text;
            string staffqulification = StaffDashboard_QulificationsInput_MTB.Text;
            string staffspecilizedsubject = StaffDashboard_SpecilizedSubjectsInput_MTB.Text;

            // Input Fields Validation
            if (staffname == "")
            {
                StaffDashboard_StaffNameInput_Error.Show();
            }
            if (staffaddress == "")
            {
                StaffDashboard_AddressInput_Error.Show();
            }
            if (staffcontactnumber == "")
            {
                StaffDashboard_ContactNumberInput_Error.Show();
            }
            if (staffemail == "")
            {
                StaffDashboard_EmailInput_Error.Show();
            }
            if (staffnic == "")
            {
                StaffDashboard_NICInput_Error.Show();
            }
            if (staffspecilizedsubject == "")
            {
                StaffDashboard_SpecilizedSubjectsInput_Error.Show();
            }

            // Data Base Connection & Query
            if (staffname != "" && staffaddress != "" && staffcontactnumber != "" && staffemail != "" && staffnic != "" && staffspecilizedsubject != "")
            {
                HideErrorMessages();

                dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
                dbConnection.Open();

                // CHeck the Status of the save button
                if (StaffDashboard_SaveBtn_MB.Text == "Save")
                {
                    // Save New Staff Member
                    dbCommand = new SqlCommand("insert into StaffMember(FullName, DOB, Gender, Address, ContactNumber, Email, NIC, LastService, JoinDate, HEQulification, Qulifications, SpecializedSubjects, AdminAccountStatus) values (@a, @b, @c, @d, @e, @f, @g, @h, @i, @j, @k, @l, @m)", dbConnection);
                    dbCommand.Parameters.AddWithValue("@a", staffname);
                    dbCommand.Parameters.AddWithValue("@b", StaffDashboard_DOBInput_DP.Value);
                    dbCommand.Parameters.AddWithValue("@c", staffgender);
                    dbCommand.Parameters.AddWithValue("@d", staffaddress);
                    dbCommand.Parameters.AddWithValue("@e", staffcontactnumber);
                    dbCommand.Parameters.AddWithValue("@f", staffemail);
                    dbCommand.Parameters.AddWithValue("@g", staffnic);
                    dbCommand.Parameters.AddWithValue("@h", stafflastservice);
                    dbCommand.Parameters.AddWithValue("@i", staffjoindate);
                    dbCommand.Parameters.AddWithValue("@j", staffhequlification);
                    dbCommand.Parameters.AddWithValue("@k", staffqulification);
                    dbCommand.Parameters.AddWithValue("@l", staffspecilizedsubject);
                    dbCommand.Parameters.AddWithValue("@m", "NotCreated");
                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                    StaffDashboard_Success.Text = "New Staff member is added to the system";
                    StaffDashboard_Success.Show();
                    ClearInputFields();
                    LoadDataToListView();
                }
                else
                {
                    // Update Staff Member Details
                    dbCommand = new SqlCommand("update StaffMember set FullName=@a, DOB=@b, Gender=@c, Address=@d, ContactNumber=@e, Email=@f, NIC=@g, LastService=@h, JoinDate=@i, HEQulification=@j, Qulifications=@k, SpecializedSubjects=@l where Id=@m", dbConnection);
                    dbCommand.Parameters.AddWithValue("@a", staffname);
                    dbCommand.Parameters.AddWithValue("@b", StaffDashboard_DOBInput_DP.Value);
                    dbCommand.Parameters.AddWithValue("@c", staffgender);
                    dbCommand.Parameters.AddWithValue("@d", staffaddress);
                    dbCommand.Parameters.AddWithValue("@e", staffcontactnumber);
                    dbCommand.Parameters.AddWithValue("@f", staffemail);
                    dbCommand.Parameters.AddWithValue("@g", staffnic);
                    dbCommand.Parameters.AddWithValue("@h", stafflastservice);
                    dbCommand.Parameters.AddWithValue("@i", staffjoindate);
                    dbCommand.Parameters.AddWithValue("@j", staffhequlification);
                    dbCommand.Parameters.AddWithValue("@k", staffqulification);
                    dbCommand.Parameters.AddWithValue("@l", staffspecilizedsubject);
                    dbCommand.Parameters.AddWithValue("@m", GlobalStaffID);
                    dbCommand.ExecuteNonQuery();
                    dbConnection.Close();
                    StaffDashboard_Success.Text = "Successfull Updated the staff member details";
                    StaffDashboard_Success.Show();
                    ClearInputFields();
                    LoadDataToListView();
                }
            }
        }

        // Comon Search Function
        public void searchbyfilterfunction(string sqlsearchquery)
        {
            StaffDashboard_DataTabel_MLV.Items.Clear();


            // Select All the Data From DB
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbCommand = new SqlCommand("Select Id, FullName, DOB, Gender, Address, ContactNumber, Email, NIC, JoinDate, SpecializedSubjects from StaffMember", dbConnection);
            dbDataAdapter = new SqlDataAdapter(dbCommand);
            DataSet StaffDataSet = new DataSet();
            dbDataAdapter.Fill(StaffDataSet, "testTabel");
            dbConnection.Close();

            DataTable StaffDataTabel = StaffDataSet.Tables["testTabel"];
            int i;
            for (i = 0; i <= StaffDataTabel.Rows.Count - 1; i++)
            {
                StaffDashboard_DataTabel_MLV.Items.Add(StaffDataTabel.Rows[i].ItemArray[0].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[1].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[2].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[3].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[4].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[5].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[6].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[7].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[8].ToString());
                StaffDashboard_DataTabel_MLV.Items[i].SubItems.Add(StaffDataTabel.Rows[i].ItemArray[9].ToString());
            }
        }

        private void StaffDashboard_ViewData_Search_MB_Click(object sender, EventArgs e)
        {
            // Get User inputs
            String filterby = StaffDashboard_ViewData_FilterBy_MCB.SelectedItem.ToString();
            String filtervalue = StaffDashboard_ViewData_SearchValue_MTB.Text;
            String sqlsearchquery = "";

            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();

            switch (filterby)
            {
                case "Name":
                    sqlsearchquery = "select * from StaffMember where FullName like '%" + filtervalue + "%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                case "NIC":
                    sqlsearchquery = "select * from StaffMember where Gender like '%" + filtervalue + "%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                case "Joined Date":
                    sqlsearchquery = "select * from StaffMember where Address like '%" + filtervalue + "%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                case "Specialized Subject":
                    sqlsearchquery = "select * from StaffMember where DOB like '%" + filtervalue + "%'";
                    searchbyfilterfunction(sqlsearchquery);
                    break;
                default:
                    sqlsearchquery = "select * from StaffMember";
                    searchbyfilterfunction(sqlsearchquery);
                    break;

            }
        }


        // On List view Intem Click function
        private void StaffDashboard_DataTabel_MLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StaffDashboard_DataTabel_MLV.SelectedItems.Count == 0)
                return;
            ListViewItem item = StaffDashboard_DataTabel_MLV.SelectedItems[0];

            // Setting the Selected Data On Input Fields
            StaffDashboard_SaveBtn_MB.Text = "Update";
            GlobalStaffID = item.SubItems[0].Text;

            StaffDashboard_StaffNameInput_MTB.Text = item.SubItems[1].Text;
            StaffDashboard_DOBInput_DP.Value = System.Convert.ToDateTime(item.SubItems[2].Text);
            switch (item.SubItems[3].Text)
            {
                case "Male":
                    StaffDashboard_GenderInput_MCB.SelectedIndex = 0;
                    break;
                case "Female":
                    StaffDashboard_GenderInput_MCB.SelectedIndex = 1;
                    break;
                default:
                    break;
            }
            StaffDashboard_AddressInput_MTB.Text = item.SubItems[4].Text;
            StaffDashboard_ContactNumberInput_MTB.Text = item.SubItems[5].Text;
            StaffDashboard_EmailInput_MTB.Text = item.SubItems[6].Text;
            StaffDashboard_NICInput_MTB.Text = item.SubItems[7].Text;
            StaffDashboard_LastServiceInput_MTB.Text = item.SubItems[8].Text;
            StaffDashboard_JoinDateInput_MTB.Text = item.SubItems[9].Text;
            StaffDashboard_HEQulificationInput_MTB.Text = item.SubItems[10].Text;
            StaffDashboard_QulificationsInput_MTB.Text = item.SubItems[11].Text;
            StaffDashboard_SpecilizedSubjectsInput_MTB.Text = item.SubItems[12].Text;
        }
    }
}
