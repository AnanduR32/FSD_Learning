using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Newtonsoft.Json;
using System.IO;

namespace AdoFormDisconnected
{
    public partial class Dashboard : Page
    {
        private static string path = HttpContext.Current.Request.MapPath("Models/data/");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString: ConfigurationManager.ConnectionStrings["BooksDB"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter(
                "select ISBN, Title, Author, Category from books_collection;" +
                "select ISBN, Format, Rating, Price from books_collection;",
                conn
                );
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridViewBookPrimary.DataSource = ds.Tables[0];
            GridViewBookPrimary.DataBind();
            GridViewBookMisc.DataSource = ds.Tables[1];
            GridViewBookMisc.DataBind();


            DataSet dataset = getDataSet();
            
            GridViewGeneratedEmp.DataSource = dataset.Tables[0];
            GridViewGeneratedEmp.DataBind();

            GridViewGeneratedDept.DataSource = dataset.Tables[1];
            GridViewGeneratedDept.DataBind();

        }

        public DataTable GetEmployeeTable()
        {
            // create table
            DataTable empTable = new DataTable("Employee");

            // create columns
            empTable.Columns.Add(new DataColumn("EmpId", typeof(int)));
            empTable.Columns.Add(new DataColumn("EmpName", typeof(string)));
            DataColumn dcDeptID = new DataColumn("DeptID", typeof(int));
            empTable.Columns.Add(dcDeptID);
            // empTable.PrimaryKey = new DataColumn[] { dcDeptID };

            // create rows
            empTable.Rows.Add(1, "Mark", 101);
            empTable.Rows.Add(2, "Paul", 101);
            empTable.Rows.Add(3, "Watson", 103);

            return empTable;
        }
        public DataTable GetDepartmentTable()
        {
            // create table
            DataTable deptTable = new DataTable("Department");

            // create column            
            DataColumn dcDeptID = new DataColumn("DeptID", typeof(int));
            deptTable.Columns.Add(dcDeptID);
            deptTable.PrimaryKey = new DataColumn[] { dcDeptID };

            deptTable.Columns.Add(new DataColumn("DeptName", typeof(string)));

            // creating a row
            deptTable.Rows.Add(101, "Admin");
            deptTable.Rows.Add(102, "Sales");
            deptTable.Rows.Add(103, "IT");

            return deptTable;
        }
        public DataSet getDataSet()
        {
            DataTable empTable = GetEmployeeTable();
            DataTable deptTable = GetDepartmentTable();
            DataSet dataset = new DataSet();
            dataset.Tables.Add(empTable);
            dataset.Tables.Add(deptTable);
            dataset.Relations.Add(
                    new DataRelation(
                        "department_relations",
                        dataset.Tables["Department"].Columns["DeptID"],
                        dataset.Tables["Employee"].Columns["DeptID"]
                    )
            );
            return dataset;
        }

        protected void ButtonConvJSON_Click(object sender, EventArgs e)
        {
            DataSet dataset = getDataSet();
            string jsonData = JsonConvert.SerializeObject(dataset);
            
            StreamWriter SW = File.CreateText(path+"Data.json");
            SW.WriteLine(jsonData);
            SW.Close();
        }

        protected void ButtonConvXML_Click(object sender, EventArgs e)
        {
            DataSet dataset = getDataSet();
            dataset.WriteXml(path+"Data.xml");
        }
    }
}