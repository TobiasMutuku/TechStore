using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace WebApplication1
{
    
    
    public class Config()
    {
        public string dbConnection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TechStore;Integrated Security=True;Pooling=False";
        
        public void GenAllItems(String items)
        {
            
            SqlConnection conn = new SqlConnection(dbConnection);
            string queryAllFruits = "select * from Items";
            conn.Open();
            SqlCommand cmd = new SqlCommand(queryAllFruits, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = (" ");
                settings.CloseOutput = true;
                settings.OmitXmlDeclaration = false;
                
                
                    using (XmlWriter writer = XmlWriter.Create(items, settings))
                    {
                    writer.WriteStartElement("items");
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

        public void GenAllUsers(String users)
        {
            SqlConnection conn = new SqlConnection(dbConnection);
            string queryAllUsers = "select * from users ";
            conn.Open();
            SqlCommand cmd = new SqlCommand(queryAllUsers, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = (" ");
                settings.CloseOutput = true;
                settings.OmitXmlDeclaration = false;


                using (XmlWriter writer = XmlWriter.Create(users, settings))
                {
                    writer.WriteStartElement("users");
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

        public void GenAllOrders(String orders)
        {
            SqlConnection conn = new SqlConnection(dbConnection);
            string queryAllOrders = "select item_id,user_id,bought,Items.name,Items.price,Items.description,Items.image,users.email,users.address,users.phone,users.name as username from cart join Items on Items.id = cart.item_id join users on users.id = cart.user_id where bought = 1";
            conn.Open();
            SqlCommand cmd = new SqlCommand(queryAllOrders, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = (" ");
                settings.CloseOutput = true;
                settings.OmitXmlDeclaration = false;


                using (XmlWriter writer = XmlWriter.Create(orders, settings))
                {
                    writer.WriteStartElement("orders");
                    while (rdr.Read())
                    {
                        writer.WriteStartElement("order");
                        writer.WriteElementString("itemId", rdr["item_id"].ToString());
                        writer.WriteElementString("userId", rdr["user_id"].ToString());
                        writer.WriteElementString("bought", rdr["bought"].ToString());
                        writer.WriteElementString("itemName", rdr["name"].ToString());
                        writer.WriteElementString("price", rdr["price"].ToString());
                        writer.WriteElementString("description", rdr["description"].ToString());
                        writer.WriteElementString("image", rdr["image"].ToString());
                        writer.WriteElementString("email", rdr["email"].ToString());
                        writer.WriteElementString("address", rdr["address"].ToString());
                        writer.WriteElementString("phone", rdr["phone"].ToString());
                        writer.WriteElementString("username", rdr["username"].ToString());
                        writer.WriteEndElement();
                    }


                    writer.Flush();
                }

            }
        }

        public void Exportdatabase(String cart)
        {
            string tableCart = "select * from cart";

            SqlConnection conn = new SqlConnection(dbConnection);
            conn.Open();
            SqlCommand cmd = new SqlCommand(tableCart, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = (" ");
                settings.CloseOutput = true;
                settings.OmitXmlDeclaration = false;


                using (XmlWriter writer = XmlWriter.Create(cart, settings))
                {
                    writer.WriteStartElement("items");
                    while (rdr.Read())
                    {
                        writer.WriteStartElement("cartItem");
                        writer.WriteElementString("id", rdr["id"].ToString());
                        writer.WriteElementString("item_id", rdr["item_id"].ToString());
                        writer.WriteElementString("user_id", rdr["user_id"].ToString());
                        writer.WriteElementString("bought", rdr["bought"].ToString());
                        writer.WriteEndElement();
                    }


                    writer.Flush();
                }

            }


        }
    }

  
}
