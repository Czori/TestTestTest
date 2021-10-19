using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Some_Learning_Stuff
{
    class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine(
                "1 = HelloWorld + Sprawdz czy imie to Bob lub Alice\n" +
                "2 = Wypisywanie liczb po kolei do numeru \n" +
                "3 = Tabliczka mnozeni (TOFIX) \n" +
                "4 = Liczby Pierwsze do podanej liczby \n" +
                "5 = Zgadnij Liczbe \n" +
                "6 = Dni przestepne \n" +
                "7 = Najwieksza liczba w szeregu \n" +
                "8 = Odwroc slowo \n" +
                "9 = Czy cos istnieje w szeregu \n" +
                "10 = Co 2 Liczba w szeregu \n" +
                "11 = Suma szeregu \n" +
                "12 = Sprawdz czy cos jest palindromem \n" +
                "13 = Kwadraty liczb \n" +
                "14 = Naprzemienne pokazywanie tekstu \n" +
                "15 = Naprzemiennie sortowany string \n" +
                "16 = Obrót Stringa \n" +
                "17 = 100 licz fibonacciego \n" +
                "18 = Rozbicie liczby na produkt \n" +
                "19 = Hello World w ramce \n" +
                "20 = Tlumacz z angielskiego na morsa \n" +
                "21 = Pig latin translator \n" +
                "22 = Bubble Sort \n" +
                "23 = Selection Sort \n"
                            );

            Int32.TryParse(Console.ReadLine(), out int funkcja);
            switch (funkcja)
            {
                case 1:                    
                    NameChecking.CheckName();
                    break;

                case 2:
                    NumberOperations.Iteration();
                    break;

                case 3:
                    //To Fix
                    NumberOperations.Multiplication();
                    break;

                case 4:
                    NumberOperations.PrimeNumber();
                    break;

                case 5:
                    Games.Numbers();
                    break;

                case 6:
                    // to verify
                    Games.Leapdays();
                    break;

                case 7:
                    NumberOperations.ArrayMax();
                    break;

                case 8:
                    StringOperations.ListReverse();
                    break;

                case 9:
                    StringOperations.IsInList();
                    break;

                case 10:
                    NumberOperations.OddNumbers();
                    break;

                case 11:
                    NumberOperations.ArraySum();
                    break;

                case 12:
                    StringOperations.Palindrome();
                    break;

                case 13:
                    NumberOperations.Prime();
                    break;

                case 14:
                    StringOperations.StringAlteration();
                    break;

                case 15:
                    StringOperations.TwoListMerge();
                    break;

                case 16:
                    StringOperations.ArrayOrderChange();
                    break;

                case 17:
                    Games.FibNumbers();
                    break;

                case 18:
                    NumberOperations.NumbersInList();
                    break;

                case 19:
                    Games.HelloWorldInAFrame();
                    break;

                case 20:
                    Console.Clear();
                    Translator tr = new Translator();
                    Translator.InitializeDictionary();

                    Console.WriteLine("What did you want to say?");
                    string userInput = Translator.GetUserInput();
                    Console.WriteLine("Morse alphabet output is: " + Translator.Translate(userInput));

                    Console.WriteLine("[Press ANY KEY to exit]");
                    Console.ReadLine();

                    break;

                case 21:
                    StringOperations.PigLatin();
                    break;

                case 22:
                    Sorting.BubbleSort();
                    break;

                case 23:
                    Sorting.SelectionSorting();
                    break;

                case 24:
                    Console.Clear();

                    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
                    break;

                default:
                    break;
            }   
        }
    }
}

