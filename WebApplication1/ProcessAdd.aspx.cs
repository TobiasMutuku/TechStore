using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1;

namespace TechStore
{
    public partial class ProcessAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string imagePath = "",image = "";
                var file = Request.Files[0];
                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    image = fileName;
                    imagePath = Server.MapPath("~/img/") + fileName;
                    file.SaveAs(imagePath);
                }

                var name = Request.Form["name"];
                var description = Request.Form["desc"];
                var price = Request.Form["price"];

                Config config = new Config();
                SqlConnection conn = new SqlConnection(config.dbConnection);
                string query = $"insert into Items(name,price,description,image) values('{name}',{price},'{description}','{image}')";
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    string msg = HttpUtility.UrlEncode($"<div class=\"alert alert-success text-white\" role=\"alert\">{name} has been added</div>");
                    Response.Redirect($"/Add?m={msg}");
                }
                else
                {
                    string msg = HttpUtility.UrlEncode($"<div class=\"alert alert-warning text-white\" role=\"alert\">Could not add {name}</div>");
                    Response.Redirect($"/Add?m={msg}");
                }
            }
        }
    }
}