using System;
using System.Collections.Generic;
using System.Text;

namespace Some_Learning_Stuff
{
    class Games
    {
        public static void Numbers()
        {
            // ----------------------- Gra w Pytanie
            Console.Clear();
            Console.WriteLine("Gra w Pytanie!");

            Random rnd = new Random();
            int stre;

            int Liczba = rnd.Next(0, 100);
            Console.WriteLine("Podaj Liczbe!");

            for (int i = 0; i < 10; i++)
            {
                Int32.TryParse(Console.ReadLine(), out stre);

                if (stre == Liczba)
                {
                    Console.WriteLine("Nice");
                    Console.WriteLine("podjales tyle " + i + " prob");
                    System.Threading.Thread.Sleep(1000);
                    break;
                }

                if (stre > Liczba)
                {
                    Console.WriteLine("mniej!");
                }

                if (stre < Liczba)
                {
                    Console.WriteLine("wiecej!");
                }

            }

            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();

        }

        public static void Leapdays()
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("Otrzymasz 20 kolejnych dat w których znajdą się dni przestępne od podanego roku");

            int leap;
            int Year;

            Int32.TryParse(Console.ReadLine(), out Year);

            for (int i = 0; i <= 20; i++)
            {
                leap = 4 * i;
                leap += Year;
                System.Threading.Thread.Sleep(10);
                Console.WriteLine(leap + " ");
            }

            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();
        }


    }
}
