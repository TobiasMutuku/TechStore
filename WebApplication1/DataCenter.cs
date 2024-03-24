using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Xml;
using System.Xml.Linq;

/// <summary>
/// this class provides access to the database and returns the results from the respective functions
/// </summary>
public class DataCenter
{
    //declare global variables for the class
    public string connectionUrl = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UrbanStyle;Integrated Security=True;Pooling=False";
    private SqlConnection connection;
    public string hostingUrl = HostingEnvironment.MapPath("~").ToString() + "/assets/xml/";
    public DataCenter()
    {
        //on every call, inititalize the variables and start the connection
        connection = new SqlConnection(connectionUrl);
        connection.Open();
    }
    //perform insert update queries on this instance of the database
    public bool executeNonQuery(string query)
    {
        //initialize the query with the connection
        SqlCommand cmd = new SqlCommand(query, connection);
        if (cmd.ExecuteNonQuery() > 0)
        {
            //query success return true
            return true;
        }
        else
        {
            return false;
        }
    }
    //function t execute select statements
    public SqlDataReader executeQuery(string query)
    {
        //initialise the connection and set up the reader
        SqlCommand cmd = new SqlCommand(query, connection);
        SqlDataReader rdr = cmd.ExecuteReader();
        //check if the reader has rows or no record was found
        if(rdr.HasRows)
        {
            //return the reader to handle the data appropriately
            return rdr;
        }
        else
        {
            //no data therefore return null reader which we will check in the implimentation
            return null;
        }
    }
    public void GenAllClothes()
    {
        string queryAllFruits = "select * from Items";
        SqlCommand cmd = new SqlCommand(queryAllFruits, connection);
        SqlDataReader rdr = cmd.ExecuteReader();
        //check if there are rows in the database
        if (rdr.HasRows)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = (" ");
            settings.CloseOutput = true;
            settings.OmitXmlDeclaration = false;

            //start the xml writer which will write the file for us
            using (XmlWriter writer = XmlWriter.Create($@"{hostingUrl}items.xml", settings))
            {
                writer.WriteStartElement("item");
                //loop through the items one after the other and add them to the xml
                while (rdr.Read())
                {
                    writer.WriteStartElement("item");
                    writer.WriteElementString("id", rdr["id"].ToString());
                    writer.WriteElementString("name", rdr["name"].ToString());
                    writer.WriteElementString("price", rdr["price"].ToString());
                    writer.WriteElementString("description", rdr["description"].ToString());
                    writer.WriteElementString("image", rdr["image"].ToString());
                    writer.WriteEndElement();
                }
                writer.Flush();
            }

        }
    }
    //generate xml of all the clothes in the system
    public void GenAllUsers()
    {
        string queryAllUsers = "select * from users ";
        SqlCommand cmd = new SqlCommand(queryAllUsers, connection);
        SqlDataReader rdr = cmd.ExecuteReader();
        //check if there are users in the system
        if (rdr.HasRows)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = (" ");
            settings.CloseOutput = true;
            settings.OmitXmlDeclaration = false;


            using (XmlWriter writer = XmlWriter.Create($"{hostingUrl}users.xml", settings))
            {
                writer.WriteStartElement("users");
                //loop throught the users and add them to the xml file one after the other
                while (rdr.Read())
                {
                    writer.WriteStartElement("user");
                    writer.WriteElementString("id", rdr["id"].ToString());
                    writer.WriteElementString("name", rdr["name"].ToString());
                    writer.WriteElementString("password", rdr["password"].ToString());
                    writer.WriteElementString("email", rdr["email"].ToString());
                    writer.WriteElementString("role", rdr["role"].ToString());
                    writer.WriteElementString("address", rdr["address"].ToString());
                    writer.WriteElementString("phone", rdr["phone"].ToString());
                    writer.WriteEndElement();
                }


                writer.Flush();
            }

        }
    }
    //generate xml of all the users in the system
    public void GenCart(String userId)
    {
        string queryAllUsers = $"select * from cart where userId = '{userId}' ";
        SqlCommand cmd = new SqlCommand(queryAllUsers, connection);
        SqlDataReader rdr = cmd.ExecuteReader();
        //check if there are items in the cart for the specified user
        if (rdr.HasRows)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = (" ");
            settings.CloseOutput = true;
            settings.OmitXmlDeclaration = false;


            using (XmlWriter writer = XmlWriter.Create($@"{hostingUrl}cart-{userId}.xml", settings))
            {
                writer.WriteStartElement("cart");
                //loop through the data and add the items of the current user to their respective xml file
                while (rdr.Read())
                {
                    writer.WriteStartElement("item");
                    writer.WriteElementString("id", rdr["id"].ToString());
                    writer.WriteElementString("name", rdr["name"].ToString());
                    writer.WriteElementString("password", rdr["password"].ToString());
                    writer.WriteElementString("email", rdr["email"].ToString());
                    writer.WriteElementString("role", rdr["role"].ToString());
                    writer.WriteElementString("address", rdr["address"].ToString());
                    writer.WriteElementString("phone", rdr["phone"].ToString());
                    writer.WriteEndElement();
                }


                writer.Flush();
            }

        }
    }
    //generate all orders and store in xml which we will perform the xslt on
    public void GenAllOrders()
    {
        string queryAllUsers = "select * from orders ";
        SqlCommand cmd = new SqlCommand(queryAllUsers, connection);
        SqlDataReader rdr = cmd.ExecuteReader();
        //check if we have items which have been paid for
        if (rdr.HasRows)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = (" ");
            settings.CloseOutput = true;
            settings.OmitXmlDeclaration = false;


            using (XmlWriter writer = XmlWriter.Create($@"{hostingUrl}orders.xml", settings))
            {
                writer.WriteStartElement("orders");
                //loop through the orders and create the xml file for them
                while (rdr.Read())
                {
                    writer.WriteStartElement("order");
                    writer.WriteElementString("id", rdr["id"].ToString());
                    writer.WriteElementString("qty", rdr["qty"].ToString());
                    writer.WriteElementString("price", rdr["price"].ToString());
                    writer.WriteElementString("status", rdr["status"].ToString());
                    writer.WriteElementString("userId", rdr["userId"].ToString());
                    writer.WriteElementString("address", rdr["address"].ToString());
                    writer.WriteElementString("date", rdr["date"].ToString());
                    writer.WriteEndElement();
                }


                writer.Flush();
            }

        }
    }
    //provide a way to close the database connection
    public void closeConnection()
    {
        connection.Close();
    }
    //generate pants
    public void GenPants()
    {
        string queryAllFruits = "select * from Items where category = 'pants'";
        SqlCommand cmd = new SqlCommand(queryAllFruits, connection);
        SqlDataReader rdr = cmd.ExecuteReader();
        //check if there are rows in the database
        if (rdr.HasRows)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = (" ");
            settings.CloseOutput = true;
            settings.OmitXmlDeclaration = false;

            //start the xml writer which will write the file for us
            using (XmlWriter writer = XmlWriter.Create($@"{hostingUrl}pants.xml", settings))
            {
                writer.WriteStartElement("item");
                //loop through the items one after the other and add them to the xml
                while (rdr.Read())
                {
                    writer.WriteStartElement("item");
                    writer.WriteElementString("id", rdr["id"].ToString());
                    writer.WriteElementString("name", rdr["name"].ToString());
                    writer.WriteElementString("price", rdr["price"].ToString());
                    writer.WriteElementString("description", rdr["description"].ToString());
                    writer.WriteElementString("photo", rdr["photo"].ToString());
                    writer.WriteElementString("quantity", rdr["quantity"].ToString());
                    writer.WriteEndElement();
                }
                writer.Flush();
            }

        }
    }
    //generate shirts
    public void GenShirts()
    {
        string queryAllFruits = "select * from Items where category = 'shirt'";
        SqlCommand cmd = new SqlCommand(queryAllFruits, connection);
        SqlDataReader rdr = cmd.ExecuteReader();
        //check if there are rows in the database
        if (rdr.HasRows)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = (" ");
            settings.CloseOutput = true;
            settings.OmitXmlDeclaration = false;

            //start the xml writer which will write the file for us
            using (XmlWriter writer = XmlWriter.Create($@"{hostingUrl}shirts.xml", settings))
            {
                writer.WriteStartElement("item");
                //loop through the items one after the other and add them to the xml
                while (rdr.Read())
                {
                    writer.WriteStartElement("item");
                    writer.WriteElementString("id", rdr["id"].ToString());
                    writer.WriteElementString("name", rdr["name"].ToString());
                    writer.WriteElementString("price", rdr["price"].ToString());
                    writer.WriteElementString("description", rdr["description"].ToString());
                    writer.WriteElementString("photo", rdr["photo"].ToString());
                    writer.WriteElementString("quantity", rdr["quantity"].ToString());
                    writer.WriteEndElement();
                }
                writer.Flush();
            }

        }
    }
}