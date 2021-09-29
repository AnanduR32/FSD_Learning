using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace AdoFormDisconnected
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString: ConfigurationManager.ConnectionStrings["BooksDB"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("select * from books_collection", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridViewAllBooks.DataSource = ds;
            GridViewAllBooks.DataBind();
        }
    }
}