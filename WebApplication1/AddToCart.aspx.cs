using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AddToCart : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OnPost();
        }
        public void OnPost()
        {
            var coookie = Request.Cookies["id"];
            if (coookie == null)
            {
                Response.Redirect("/Login");
            }

            string userId = Request.Cookies["id"].ToString();
            Config config = new Config();
            SqlConnection conn = new SqlConnection(config.dbConnection);
            string itemID = Request.Form["item_id"];
            string query = $"insert into cart(item_id,user_id,bought) values('{itemID}','{userId}',0)";
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