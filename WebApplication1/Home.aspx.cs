using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Home : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CookieManager.GetCookieValue("role") == "0")
            {
                Response.Redirect("/Dashboard");
            }
        }
    }
}