using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Database : Page
    {
        public string msg;
        protected void Page_Load(object sender, EventArgs e)
        {
            WebApplication1.Config config = new WebApplication1.Config();
            config.Exportdatabase(@$"{Server.MapPath("~")}xml\cart.xml");

            msg = msg = $"<div class=\"alert alert-success\" role=\"alert\">Files have been saved to xml folder! </div>";
        }

    }
}