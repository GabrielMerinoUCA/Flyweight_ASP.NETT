using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flyweight_Pattern.Buisness
{
    public static class BookTypeFactory
    {
        public static Dictionary<string, BookType> bookTypes = new Dictionary<string, BookType>();
        public static BookType getBookType(string types, string author, string other)
        {
            if (!bookTypes.ContainsKey(types))
            {
                bookTypes.Add(types, new BookType(types, author, other));
            }
            return bookTypes[types];
        }
    }
}