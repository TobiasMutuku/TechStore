using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Add : Page
    {
        public string msg = "";
        string role = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            var coookie = "";
            try
            {
                coookie = Request.Cookies["role"].ToString();
            }catch(Exception ex)
            {

            }

            if (CookieManager.GetCookieValue("role") != "0")
            {
                Response.Redirect("/Home");
            }
            
        }

    }
}