using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Sumator
    {
        public int[] Liczby;

        public Sumator(int[] arrayLiczby)
        {
            Liczby = arrayLiczby;
        }

        private int Suma()
        {
            int wynik = 0;
            foreach (int item in Liczby)
            {
                wynik += item;
            }
            return wynik;
        }
        private int SumaPodziel2()
        {
            int wynik = 0;
            foreach (int item in Liczby)
            {
                if(item % 2 == 0)
                    wynik += item;
            }
            return wynik;
        }

        private int IleElementow()
        {
            return Liczby.Length;
        }

        private void View()
        {
            foreach (int item in Liczby )
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

    }
}
