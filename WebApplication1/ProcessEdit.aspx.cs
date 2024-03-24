using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using WebApplication1;

namespace TechStore
{
    public partial class ProcessEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["area"];
            string name = Request.Form["name"];
            string desc = Request.Form["description"];
            string price = Request.Form["price"];
            Config config = new Config();
            SqlConnection conn = new SqlConnection(config.dbConnection);
            string query = $"update Items set name= '{name}',description = '{desc}',price='{price}' where id='{id}'";
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            var result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                Response.Redirect("/Dashboard");
            }
        }
    }
}