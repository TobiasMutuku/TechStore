using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Profile : Page
    {
        public string msg = "";
        string role = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            string userId = "";
            try
            {
                userId = Request.Cookies["id"].ToString();
                role = Request.Cookies["role"].ToString();

            }
            catch(Exception ex)
            {

            }
            
            if (userId == "")
            {
                Response.Redirect("/Login",true);
            }
            if (role == "0")
            {
                Response.Redirect("/Dashboard");
            }

            if(IsPostBack)
            {
                int userI = int.Parse(Request.Cookies["id"].ToString());
                Config config = new Config();
                string phone = Request.Form["phone"];
                string name = Request.Form["name"];
                string email = Request.Form["email"];
                string address = Request.Form["address"];
                string password = Request.Form["pwd"];
                SqlConnection conn = new SqlConnection(config.dbConnection);
                string query = $"update users set password = '{password}', phone = '{phone}' , name = '{name}',email = '{email}',address = '{address}' where id = {userI}";

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    msg = $"<div class=\"alert alert-success\" role=\"alert\">{name} has been modified</div>";
                }
                else
                {
                    msg = $"<div class=\"alert alert-warning\" role=\"alert\">Could not modify {name}</div>";
                }
            }
        }

    }
}