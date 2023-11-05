using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Osoba
    {
        //pola klasy
        string firstName, lastName;
        public int age;
        protected int rokUrodzenia;

        //konstruktor

        public Osoba(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        //metody
        public void View()
        {
            Console.WriteLine($"Imie {firstName}, " +
                $"Nazwisko {lastName}, wiek {age}");
        }
    }
}
