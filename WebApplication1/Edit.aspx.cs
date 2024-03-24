using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Edit : Page
    {
        public string id = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["area"];

        }

    }
}