using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Cart : Page
    {
        public int cartTotal = 0;
        public string msg = "";
        public string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CookieManager.GetCookieValue("role") == "0")
            {
                Response.Redirect("/Dashboard");
            }
            {
                
            }
            id = "";var role = "";
            try
            {
                id = Request.Cookies["id"].ToString();
                role = Request.Cookies["role"].ToString();
            }
            catch(Exception em)
            {

            }
            
            if (id == "")
            {
                Response.Redirect("/Login",true);
            }
            if (role == "0")
            {
                Response.Redirect("/Dashboard");
            }
            if(IsPostBack)
            {
                string userId = Request.Cookies["id"].ToString();
                Config config = new Config();
                SqlConnection conn = new SqlConnection(config.dbConnection);
                string fruitID = Request.Form["item_id"];
                conn.Open();
                string query = $"update cart set bought = 1 where user_id = {userId}";
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    msg = $"<div class=\"alert alert-success\">Your items will be shipped to : {Request.Cookies["address"]} !.</div><br />";
                }
            }

        }

    }
}