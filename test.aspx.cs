using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace test
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
            string connectionString = "Server=DUMIDU-K;Database=sssss;User Id=sa;Password=123;";
            string query = "Select Id,Name FROM New1";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}");
                        ss.Text = reader["Name"].ToString();
                    }
                }
            }

            ASP();
            avc();
        }

        public static void ASP()
        {
            string connectionString = "Server=DUMIDU-K;Database=sssss;User Id=sa;Password=123;";
            string query = "Select Id,Name FROM New1";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}");
                        //ss.Text = reader["Name"].ToString();
                    }
                }
            }
        }
        public static void avc() 
        { 
        
        }


	}

}