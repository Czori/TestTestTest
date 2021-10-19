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

        public static void FibNumbers()
        {
            Console.Clear();

            Int64 FibonnaciPierwsza = 0;
            Int64 FibonacciDruga = 1;

            Console.WriteLine("Ile chcesz Liczb fibonacciego?");
            int KtoraliczbaFib = 0;

            Int32.TryParse(Console.ReadLine(), out KtoraliczbaFib);
            for (int i = 0; i <= KtoraliczbaFib; i++)
            {
                Int64 FibTemporary = FibonnaciPierwsza;
                FibonnaciPierwsza = FibonacciDruga;
                FibonacciDruga = FibTemporary + FibonacciDruga;

                Console.WriteLine("Liczba numer" + i + " " + FibTemporary);
                System.Threading.Thread.Sleep(100);
            }

            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();
        }

        public static void HelloWorldInAFrame()
        {
            Console.Clear();

            List<string> framing = new List<string>()
                    {
                        "Hello",
                        "world",
                        "in",
                        "a",
                        "frame"
                    };

            for (int i = 0; i <= framing.Count; i++)
            {
                System.Threading.Thread.Sleep(10);
                Console.Write("**");
            }

            Console.WriteLine();

            foreach (string value in framing)
            {
                System.Threading.Thread.Sleep(10);
                Console.WriteLine("* " + value + "\t   *");
            }

            for (int i = 0; i <= framing.Count; i++)
            {
                System.Threading.Thread.Sleep(10);
                Console.Write("**");
            }

            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();
        }

    }
}
