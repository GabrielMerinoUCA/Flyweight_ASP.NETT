using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Flyweight_Pattern.Buisness
{
    public class BookTypeFactory
    {
        public  Dictionary<string, BookType> bookTypes;

        public BookTypeFactory()
        {
            this.bookTypes = new Dictionary<string, BookType>();
        }

        public BookType getBookType(string types, string author, string other)
        {
            if (!bookTypes.ContainsKey(types))
            {
                bookTypes.Add(types, new BookType(types, author, other));
            }
            return bookTypes[types];
        }
        
    }
}