using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Some_Learning_Stuff
{
    class StringOperations
    {
        public static void ListReverse()
        {
            Console.Clear();

            Console.WriteLine("Podaj slowo do odwrocenia \n");
            string InputStringToReverse = Console.ReadLine();

            //  string InputStringToReverse = "Hej kej Tej Lej";
            Console.WriteLine("przed zamiana \n" + InputStringToReverse);

            string resultString = string.Join(" ", InputStringToReverse.Split(' ').Select(x => new String(x.Reverse().ToArray())));

            Console.WriteLine("po zamianie \n" + resultString);

            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();


        }

        public static void IsInList()
        {
            Console.Clear();

            var ElementList = new List<string>();
            ElementList.Add("kot");
            ElementList.Add("pies");
            ElementList.Add("cma");


            Console.WriteLine("Podaje Liste");
            for (int i = 0; i < ElementList.Count; i++)
            {
                Console.Write(ElementList[i] + ", ");
            }

            Console.WriteLine("\nSprawdz czy jest w liscie");
            string ListCheck = Console.ReadLine();

            if (ElementList.Contains(ListCheck))
            {
                Console.WriteLine(ListCheck + " zostal odnaleziony");
            }
            else
            {
                Console.WriteLine(ListCheck + " nie zostal odnaleziony");
            }

            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();
        }


        public static void Palindrome()
        {
            Console.Clear();

            Console.WriteLine("Write to check Palindrome!");

            String palindrome = Console.ReadLine();
            Console.WriteLine(palindrome.SequenceEqual(palindrome.Reverse()));

            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();
        }


        public static void StringAlteration()
        {
            Console.Clear();

            List<int> ListAlternate = new List<int>()
                    {
                        1,
                        2,
                        3,
                        4,
                        5,
                        6
                    };

            string[] AlternateLetters = { "a", "b", "c", "d", "e", "f" };

            Console.WriteLine(ListAlternate + "\n" + AlternateLetters);

            for (int i = 0; i < AlternateLetters.Length; i++)
            {
                System.Threading.Thread.Sleep(10);
                Console.Write(ListAlternate[i] + ", " + AlternateLetters[i] + ", \n");
            }

            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();
        }
    }

}
