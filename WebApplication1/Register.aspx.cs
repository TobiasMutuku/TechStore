using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Register : Page
    {
        public string errorText;
        public string name;
        public string email;
        public string phone;
        public string address;
        public string password;
        public string msg;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                OnPost();
            }
            
        }
        public void OnPost()
        {

            name = Request.Form["name"];
            email = Request.Form["email"];
            phone = Request.Form["phone"];
            address = Request.Form["address"];
            password = Request.Form["pwd"];
            Config config = new Config();
            SqlConnection conn = new SqlConnection(config.dbConnection);
            string query = $"insert into users(name,password,email,role,address,phone) values('{name}','{password}','{email}',1,'{address}','{phone}')";
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                Response.Redirect("/Login");
            }
            else
            {
                msg = $"<div class=\"alert alert-warning\" role=\"alert\">Could not create account for {name}</div>";
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