using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : Page
    {
        public string errorText;
        protected void Page_Load(object sender, EventArgs e)
        {

            var coookie = "";
            try
            {
                errorText = Request.QueryString["e"];
                coookie = Request.Cookies["role"].ToString();
            }catch(Exception ex)
            {
                ex.Source = "Error";
            }
            
            if (coookie != null && coookie.Length > 0)
            {
                if (coookie == "0")
                {
                    Response.Redirect("/Dashboard");
                }
                else
                {
                    Response.Redirect("/Home");
                }
            }
            
        }
        

    }
}