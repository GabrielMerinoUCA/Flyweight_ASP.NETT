using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Flyweight_Pattern.Buisness;

namespace Flyweight_Pattern.Buisness
{
    public class Book
    {
        public string title;
        public float price;
        public BookType type;

        public Book(string title, float price, BookType type)
        {
            this.title = title;
            this.price = price;
            this.type = type;
        }
    }
}