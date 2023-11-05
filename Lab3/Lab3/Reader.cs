using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Reader:Person
    {
        Book[] bookArray = new Book[10];

        public Reader(string firstName, string lastName, int age, Book[] bookArray) : 
            base(firstName, lastName, age)
        {
            this.bookArray = bookArray;
        }

        public void ViewBook()
        {
            Console.WriteLine($"Tytuł książki {bookArray}");
        }
    }
}
