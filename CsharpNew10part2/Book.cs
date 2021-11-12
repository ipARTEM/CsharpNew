using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNew10part2
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }

        public Book(string title, Author author) =>
            (Title ,Author)=(title, author);

        public static bool doesHaveDiscount(Book book) =>
            book switch
            {
                { Author: { LastName: "Richter" } }
                or
                {
                    Author: { LastName: "Price" }
                } => true, _=>false
            };

        public static bool doesHaveDiscountNew(Book book) =>
            book switch
            {
                { Author.LastName: "Richter" } 
                or
                {
                  Author.LastName: "Price" 
                } => true,
                _ => false
            };

    }
}



