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
    public partial class AllUser : Form
    {
        // Database Connection
        SqlConnection dbConnection;
        SqlCommand dbCommand;
        SqlDataAdapter dbDataAdapter;


        public AllUser()
        {
            InitializeComponent();
            loadDataToTabel();
        }

        public void loadDataToTabel()
        {
            dbConnection = new SqlConnection(@"Data Source=ANUSHKA97DEADSH\MSSQLSERVER01;Initial Catalog=LMUSMSCW1;Integrated Security=True");
            dbConnection.Open();
            dbDataAdapter = new SqlDataAdapter("Select Id, Username, Name, AccessLeve, UserConfirmed from Userprofiles", dbConnection);
            DataTable dt = new DataTable();
            dbDataAdapter.Fill(dt);

            foreach (DataRow row in dt.Rows) 
            {
                ListViewItem item = new ListViewItem(row["Id"].ToString());
                item.SubItems.Add(row["Username"].ToString());
                UserDashboard_ALU_ListView_MLV.Items.Add(item);
                MessageBox.Show(row["Id"].ToString());
            }

            UserDashboard_ALU_ListView_MLV.View = View.List;
        }
    }
}
