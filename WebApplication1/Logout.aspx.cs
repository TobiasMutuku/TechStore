using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Logout : Page
    {
        public string errorText;
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cookies["id"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["role"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["address"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["phone"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["rname"].Expires = DateTime.Now.AddDays(-1);
            Response.Cookies["email"].Expires = DateTime.Now.AddDays(-1);

            Response.Redirect("/Home");

        }

    }
}