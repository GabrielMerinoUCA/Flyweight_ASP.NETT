using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flyweight_Pattern.Buisness
{
    public class BookType
    {
        public readonly string type;
        public readonly string author;
        public readonly string other;
        public BookType(string type, string author, string other)
        {
            this.type = type;
            this.author = author;
            this.other = other;
        }

    }
}