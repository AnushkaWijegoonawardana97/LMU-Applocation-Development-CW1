using System.Windows.Forms;
using System.Data.Sql;
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
            SettingsDashboard objSettingsDashboard = new SettingsDashboard();
            objSettingsDashboard.Show();
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
            ClearUserInputs();
            HideErrorMessages();
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
                }
            } 
        }
    }
}
