using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class History : Page
    {
        public string msg = "";
        string role = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (CookieManager.GetCookieValue("role") == "0")
            {
                Response.Redirect("/Dashboard");
            }
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

        }

    }
}