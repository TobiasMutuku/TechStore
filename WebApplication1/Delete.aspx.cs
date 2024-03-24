using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string cart_id = Request.QueryString["area"];
            Config config = new Config();
            SqlConnection conn = new SqlConnection(config.dbConnection);
            string query = $"delete from cart where id = {cart_id}";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            var result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                Response.Redirect("/Cart");
            }
        }

    }
}