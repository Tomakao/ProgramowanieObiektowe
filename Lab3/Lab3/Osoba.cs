using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Osoba
    {
        private string name;
        /*
        public string Name //właściwości pola
        {
            get { return name; }
            set { name = value; }
        }
        */
        // Lub:
       // public string Name { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public Osoba() { }

        public Osoba(string firstname, string lastname, int age)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.age = age;
        }

        /*
        public override string View()
        {
            Console.WriteLine($"Imie:\t{firstName}\tNazwisko:\t{lastName}\tWiek:\t{age}");
        }
        */

        public override string? ToString()
        {
            return $"Imie:\t{firstName}\tNazwisko:\t{lastName}\tWiek:\t{age}";

        }

    }
}
