using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace AdoForm
{
    public partial class AddEmp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS01; database=EnterpriseDB; Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = String.Format("insert into EmployeeRecord (ID, Name, Email) values ('{0}', '{1}', '{2}')",Convert.ToInt16(TextBox1.Text), TextBox2.Text.ToString(), TextBox3.Text.ToString());
                con.Open();
                int n_rows = cmd.ExecuteNonQuery();
                Label1.Text = String.Format("{0} rows affected", n_rows);
            }
        }
    }
}