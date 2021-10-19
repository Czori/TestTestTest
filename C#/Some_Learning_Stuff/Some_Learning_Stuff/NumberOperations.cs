using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Some_Learning_Stuff
{
    class NumberOperations
    {
        public static void Iteration()
        {
            Console.Clear();
            Console.WriteLine("Podaj Liczbe");
            int Secret;

            Secret = 1;
            Int32.TryParse(Console.ReadLine(), out Secret);

            for (int i = 0; i <= Secret; i++)
            {
                Console.WriteLine(i + " ");
                System.Threading.Thread.Sleep(10);
            }

            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();

        }


        public static void Multiplication()
        {
            // ------------------------- tabliczka mnozenia
            Console.Clear();

            Console.WriteLine("od jakiej liczby chcesz zaczac tabliczke mnozenia?");
            Int32.TryParse(Console.ReadLine(), out int EndOfMultiplication);

            Console.WriteLine("jak duża chcesz tabliczke mnozenia?");
            Int32.TryParse(Console.ReadLine(), out int StartOfMultiplication);

            for (int i = EndOfMultiplication; i <= StartOfMultiplication; i++)
            {
                Console.WriteLine();



                for (int j = EndOfMultiplication; j <= StartOfMultiplication; j++)
                {
                    Console.Write((i * j).ToString() + "\t ");

                }
            }

            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();

        }

        public static void PrimeNumber()
        {
            // ------------------------- Liczby Pierwsze
            Console.WriteLine();
            Console.Clear();

            Console.WriteLine("Podaj Liczbe! \n");
            int LiczbaPierwsza = 0;

            Int32.TryParse(Console.ReadLine(), out LiczbaPierwsza);
            Console.WriteLine("\n to Liczby pierwsze do liczby " + LiczbaPierwsza);

            for (int counter = 0; counter <= LiczbaPierwsza; counter++)
            {
                bool notPrime = false;
                for (var i = 2; i <= counter; i++)

                {

                    if (counter % i == 0 && i != counter)
                    {
                        notPrime = true;
                    }
                }

                if (notPrime == false)
                {
                    Console.Write(counter + " ");
                    System.Threading.Thread.Sleep(10);
                }
            }

            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();
        }

        public static void ArrayMax()
        {
            // --------------- Max int in Array
            Console.Clear();
            Console.WriteLine("Ile Liczb chcesz sprawdzic?");

            Int32.TryParse(Console.ReadLine(), out int ArrayLength);

            int[] MaxArrayNumber = new int[99];
            for (int i = 1; i <= ArrayLength; i++)
            {

                Console.WriteLine("Podaj " + i + " Liczbe");
                Int32.TryParse(Console.ReadLine(), out MaxArrayNumber[i]);


            }

            Console.WriteLine("Najwieksza w Array");
            Console.Write(MaxArrayNumber.Max());
            Console.WriteLine();
            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();
        }

        public static void OddNumbers()
        {
            Console.Clear();

            Console.WriteLine("Ile liczb chcesz podać?");
            Int32.TryParse(Console.ReadLine(), out int ArrayLength);

            var OddNumberInt = new List<int>();
            for(int i = 0; i < ArrayLength; i++)
            {
                Console.WriteLine("Podaj " + (i + 1) + " Liczbe");
                Int32.TryParse(Console.ReadLine(), out int Number);
                OddNumberInt.Add(Number);
            }

            for (int i = 1; i <= OddNumberInt.Count; i += 2)
            {
                try
                {
                    Console.Write(OddNumberInt[i] + ", ");
                }
                catch
                {
                }
            }
            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();
        }

        public static void ArraySum()
        {
            Console.Clear();
            Console.WriteLine("Ile Liczb chcesz sprawdzic?");
            Int32.TryParse(Console.ReadLine(), out int ArrayLength);

            int[] ArraySumNumber = new int[ArrayLength];
            for (int i = 1; i <= ArrayLength; i++)
            {
                Console.WriteLine("Podaj " + i + " Liczbe");
                Int32.TryParse(Console.ReadLine(), out ArraySumNumber[i-1]);
            }

            Console.WriteLine("Suma Szeregu");

            Console.WriteLine(ArraySumNumber.Sum());

            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();
        }

        public static void Prime()
        {
            Console.Clear();
            Console.WriteLine("Sprawdz kwadrat liczby");

            Int32.TryParse(Console.ReadLine(), out int prime);
            prime *= prime;
            Console.WriteLine(prime);

            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();
        }

        public static void NumbersInList()
        {
            Console.Clear();

            List<double> numberToList(string num)
            {
                List<double> newList = new List<double>();
                char[] tempArr;

                tempArr = num.ToCharArray();
                foreach (var value in tempArr)
                {
                    double digit = char.GetNumericValue(value);
                    System.Threading.Thread.Sleep(10);

                    newList.Add(digit);
                }
                return newList;
            }

            Console.WriteLine("Podaj Liczbe do zmiany na produkt");
            string liczbad = Console.ReadLine();

            foreach (var value in numberToList(liczbad))
            {
                Console.Write(value + ", ");
            }

            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();
        }





    }
}
