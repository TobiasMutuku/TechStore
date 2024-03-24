using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1;

namespace TechStore
{
    public partial class ProcessLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //after loggin get the id , name , role , address and save to cookie
            var email = Request.Form["email"];
            var password = Request.Form["pwd"];

            Config config = new Config();
            SqlConnection conn = new SqlConnection(config.dbConnection);
            string query = @$"select * from users where email = '{email}' and password = '{password}'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    SetCookie("role", rdr["role"].ToString());
                    SetCookie("id", rdr["id"].ToString());
                    SetCookie("address", rdr["address"].ToString());
                    SetCookie("phone", rdr["phone"].ToString());
                    SetCookie("name", rdr["name"].ToString());
                    SetCookie("email", rdr["email"].ToString());
                    if (rdr["role"].ToString() == "0")
                    {
                        Response.Redirect("/Dashboard");
                    }
                    else
                    {
                        Response.Redirect("/Home");
                    }
                }
            }
            else
            {
                var em = HttpUtility.UrlEncode("Invalid Credentials");
                Response.Redirect($"/Login?e={em}");
            }
        }
        protected void SetCookie(string key, string role)
        {
            // Create a new HttpCookie
            HttpCookie cookie = new HttpCookie(key, role);

            // Set cookie properties
            cookie.Expires = DateTime.Now.AddDays(5);
            cookie.Path = "/";

            // Add the cookie to the response
            Response.Cookies.Add(cookie);
        }
    }
}