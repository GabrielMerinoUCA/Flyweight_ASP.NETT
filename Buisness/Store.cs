using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Flyweight_Pattern.Buisness
{
    public class Store
    {
        public List<Book> books;
        private BookTypeFactory btf;

        public Store()
        {
            btf = new BookTypeFactory();
            books = new List<Book>();
        }

        public void storeBook(string title, float price, string type, string author, string other)
        {
            BookType bookType = btf.getBookType(type, author, other);
            books.Add(new Book(title, price, bookType));
        }

        public void LoadFromDataBase()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string query = "select b.title, b.price, bt.author, bt.bookType, bt.other from Book b join BookType bt on b.bookType = bt.id";
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string title = reader.GetString(0);
                    float price = (float)reader.GetDouble(1);
                    string author = reader.GetString(2);
                    string bookType = reader.GetString(3);
                    string other = reader.GetString(4);

                    this.storeBook(title, price, bookType, author, other);
                }
                reader.Close();
            }
        }
        public void saveToDataBase(string title, float price, string type, string author, string other)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmdB; //Book insert
                SqlCommand cmdBT; //BookType insert
                SqlCommand cmdFK;
                con.Open();

                // insert BookType if it doesn't exist
                if (!btf.bookTypes.ContainsKey(type))
                {
                    string bookTypeQuery = "Insert into BookType(author, bookType, other) " +
                        "Values(" +
                        "'" + author + "', " +
                        "'" + type + "', " +
                        "'" + other + "')";

                    cmdB = new SqlCommand(bookTypeQuery, con);
                    cmdB.ExecuteNonQuery();
                }

                // need foreign key for Book insert
                string foreignKeyQuery = "select id from BookType where bookType = '"+ type + "'";
                cmdFK = new SqlCommand(foreignKeyQuery, con);
                SqlDataReader sdrForeignKey = cmdFK.ExecuteReader();
                int foreignKey = 0;

                while (sdrForeignKey.Read())
                {
                    foreignKey = sdrForeignKey.GetInt32(0);
                }
                sdrForeignKey.Close();

                // insert Book
                string bookQuery = "Insert into Book(title, price, bookType) " +
                    "Values(" +
                    "'" + title + "', " +
                    price + ", " +
                    foreignKey + ")";
                cmdBT = new SqlCommand(bookQuery, con);
                cmdBT.ExecuteNonQuery();

            }
        }
    }
}