using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Some_Learning_Stuff
{
    class Sorting
    {

        public static void BubbleSort()
        {
            Console.Clear();

            int[] bblarr = { 800, 11, 50, 771, 649, 770, 240, 9 };
            Console.Write("input == 800, 11, 50, 771, 649, 770, 240, 9 ");
            int temp = 0;
            Console.WriteLine();
            for (int i = 0; i < bblarr.Length; i++)
            {

                for (int srt = 0; srt < bblarr.Length - 1; srt++)
                {

                    if (bblarr[srt] > bblarr[srt + 1])
                    {
                        temp = bblarr[srt + 1];

                        bblarr[srt + 1] = bblarr[srt];
                        bblarr[srt] = temp;
                    }
                }
            }
            Console.Write("output == ");
            for (int i = 0; i < bblarr.Length; i++)

                Console.Write(bblarr[i] + " ");

            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();
        }

        public static void SelectionSorting()
        {
            Console.Clear();

            int[] selsort = { 5, 3, 7, 2, 21, 713, 43170, 134, 754, 865 };
            Console.Write("input == 5, 3, 7, 2, 21, 713, 43170, 134, 754, 865");
            Console.WriteLine();
            int SelSortLength = selsort.Length;

            for (int i = 0; i < SelSortLength; i++)
            {
                int min_index = i;

                for (int y = i; y < SelSortLength; y++)
                {

                    if (selsort[min_index] > selsort[y])
                    {
                        min_index = y;
                    }
                }

                int seltemp = selsort[i];

                selsort[i] = selsort[min_index];
                selsort[min_index] = seltemp;
            }

            Console.WriteLine("Sort array in ascending order by using Selection Sort");
            Console.Write("output == ");
            foreach (int i in selsort)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
            Console.ReadKey();
        }





    }
}
