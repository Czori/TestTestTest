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
    
    
        public static void TwoListMerge()
        {
            Console.Clear();

            List<int> simultaneousMergeAndSort(List<int> FirstList, List<int> SecondList)
            {
                int firstIndex = 0;
                int secondIndex = 0;

                int lengthOfList = FirstList.Count() + SecondList.Count();
                List<int> newList = new List<int>(lengthOfList);

                while (firstIndex < FirstList.Count() || secondIndex < SecondList.Count())
                {
                    System.Threading.Thread.Sleep(10);
                    if (firstIndex != FirstList.Count() && secondIndex != SecondList.Count())
                    {
                        if (FirstList[firstIndex] <= SecondList[secondIndex])
                        {
                            newList.Add(FirstList[firstIndex]);
                            firstIndex++;
                        }
                        else
                        {
                            newList.Add(SecondList[secondIndex]);
                            secondIndex++;
                        }
                    }
                    else if (secondIndex == SecondList.Count())
                    {
                        newList.Add(FirstList[firstIndex]);
                        firstIndex++;
                    }
                    else
                    {
                        newList.Add(SecondList[secondIndex]);
                        secondIndex++;
                    }
                }

                return newList;
            }

            List<int> first = new List<int>() { 1, 4, 6, 8, 10 };
            List<int> second = new List<int>() { 2, 3, 5, 7, 9 };

            foreach (var num in simultaneousMergeAndSort(first, second))
            {
                System.Threading.Thread.Sleep(10);
                Console.Write(num + ", "); // { 1, 2, 3, 4, 5, 6 }
            }

            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();

        }
    
        public static void ArrayOrderChange()
        {
            Console.Clear();

            void printArray(int[] Arraytest, int size)
            {
                for (int i = 0; i < size; i++)
                    Console.Write(Arraytest[i] + " ");

                System.Threading.Thread.Sleep(10);
            }

            void leftRotate(int[] Arraytest, int d,
                                         int n)
            {
                for (int i = 0; i < d; i++)
                    leftRotatebyOne(Arraytest, n);
            }

            void leftRotatebyOne(int[] Arraytest, int n)
            {
                int i, TempArray = Arraytest[0];
                for (i = 0; i < n - 1; i++)
                    Arraytest[i] = Arraytest[i + 1];

                Arraytest[i] = TempArray;
            }

            Console.WriteLine("How much do you want to rotate?");
            int Rotationint = 0;

            Int32.TryParse(Console.ReadLine(), out Rotationint);
            int[] RotateArray = { 1, 2, 3, 4, 5, 6, 7 };

            leftRotate(RotateArray, Rotationint, 7);
            printArray(RotateArray, 7);

            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();
        }
    
        public static void PigLatin()
        {
            Console.Clear();

            string[] english1 = new string[4] { "hey", "look", "now", "shrek" };

            for (int i = 0; i < english1.Length; i++)
            {
                String output = String.Join(" ", english1[i].Split(' '));
                char[] test = new char[4] { ' ', ' ', ' ', ' ' };
                foreach (char s in output)
                {
                    test[i] = output[0];
                }
                Console.Write((english1[i].Trim(test[i])) + output[0] + "ay ");

            }

            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();
        }
    
    
    
    
    
    
    
    
    
    
    
    }

}
