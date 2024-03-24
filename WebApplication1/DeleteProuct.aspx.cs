using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DeleteProuct : Page
    {
        public int cartTotal = 0;
        public string msg = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            string fruitId = Request.QueryString["area"];
            Config config = new Config();

            string query = $"delete from Items where id = '{fruitId}'";
            SqlConnection conn = new SqlConnection(config.dbConnection);
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