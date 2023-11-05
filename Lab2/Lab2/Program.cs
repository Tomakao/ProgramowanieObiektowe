using System;

namespace Lab2
{
    class Program
    {
        static void Teoria()
        {
            Osoba osoba = new Osoba("jan", "nowak", 23);
            osoba.View();

            //tablica obiektów I sposób
            Osoba[] osobyArray = new Osoba[3];

            osobyArray[0] = new Osoba("jan", "nowak", 23);
            osobyArray[1] = new Osoba("jan1", "nowak1", 24);
            osobyArray[2] = new Osoba("jan2", "nowak2", 25);

            foreach (Osoba item in osobyArray)
            {
                item.View();
            }

            for (int i = 0; i < osobyArray.Length; i++)
            {
                osobyArray[i].View();
            }

            // II sposób
            Osoba[] osobaArray1 = new Osoba[]
            {
                new Osoba("jan", "nowak", 23),
                new Osoba("jan1", "nowak1", 24),
                new Osoba("jan2", "nowak2", 25)
            };

            // III sposób
            Osoba[] osobaArray2 = new Osoba[3];
            string[] firstName = { "jan", "jan1", "jan2" };
            string[] lastName = { "nowak", "nowak1", "nowak2" };
            int[] age = { 23, 24, 25 };
            for (int i = 0; i < osobaArray2.Length; i++)
            {
                osobaArray2[i] = new Osoba(firstName[i], lastName[i], age[i]);
                osobaArray2[i].View();
            }
        }

        static void Zadanie1()
        {
            //Licz policz = new Licz(5);
            //policz.View(3);

            Licz[] licz = new Licz[] {
                new Licz(1),
                new Licz(2),
                new Licz(3)
            };

            foreach (Licz item in licz)
            {
                item.View(2);
                Console.Write(item.ToString());
            }

        }

        static void Zadanie2()
        {

        }

        static void Main(string[] args)
        {
            //Teoria();
            Zadanie1();
        }
       
    }
}
