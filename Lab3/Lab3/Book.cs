using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Book
    {
        public string title { get; set; }
        public string dataWydania { get; set; }
        Person author;

        public Book(string title, Person author, string datawydania) {
            this.title = title;
            this.author = author;
            this.dataWydania = datawydania;
        }

        public void View()
        {
            Console.WriteLine($"Title: {title}\tData wydania: {dataWydania}");
            author.View();
        }
    }
}
