using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Some_Learning_Stuff
{
    class Stringoperations
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
            for( int i = 0; i < ElementList.Count; i++)
            {
                Console.Write(ElementList[i] + ", ");
            }

            Console.WriteLine("\nSprawdz czy jest w liscie");
            string ListCheck = Console.ReadLine();
            
            if(ElementList.Contains(ListCheck))
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
    }
    

}
