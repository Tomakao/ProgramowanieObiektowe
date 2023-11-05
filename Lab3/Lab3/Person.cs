using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int wiek { get; set; }

        public Person(string firstname, string lastname, int wiek) 
        { 
            this.firstName = firstname;
            this.lastName = lastname;
            this.wiek = wiek;
        }

        public void View()
        {
            Console.WriteLine($"Imie:\t{firstName}\tNazwisko:\t{lastName}\tWiek:\t{wiek}");
        }

    }
}
