using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flyweight_Pattern.Buisness
{
    public static class Store
    {
        public static List<Book> books = new List<Book>();
        public static void storeBook(string title, float price, string type, string author, string other)
        {
            BookType bookType = BookTypeFactory.getBookType(type, author, other);
            books.Add(new Book(title, price, bookType));
        }

    }
}