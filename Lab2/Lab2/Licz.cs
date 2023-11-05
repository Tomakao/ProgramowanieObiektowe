using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Licz
    {
        public double value;
        private double Dodaj(double a)
        {
            return value += a;
        }

        private double Odejmij(double a)
        {
            return value -= a;
        }

        public void View(double a)
        {
            Console.WriteLine($"Wartość początkowa: {value}, " +
                $"\nWartość po dodaniu {a} = {Dodaj(a)}," +
                $"\nWartość po odjęciu {a} = {Odejmij(a)}\n");
        }

        public Licz(double value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
