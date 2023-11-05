using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Student:Osoba
    {
        public string NrAlbumu { get; set; }
        public Student(string firstName, string lastName, int age, string NrAlbumu):base(firstName, lastName, age)
        {
            this.NrAlbumu = NrAlbumu;
        }

        public override string? ToString()
        {
            return $"Imie:\t{firstName}\tNazwisko:\t{lastName}\tWiek:\t{age}\tNr Albumu:\t{NrAlbumu}";

        }
    }
}
