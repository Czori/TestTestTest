using System;
using System.Collections.Generic;
using System.Text;

namespace Some_Learning_Stuff
{
    class Namechecking
    {
        public static void CheckName(){
        Console.Clear();
                    Console.WriteLine("Hello World!");

                    String WhatName;
        WhatName = ("ss");

                    Console.WriteLine("What's Your name?");
                    WhatName = Console.ReadLine();

                    if ((WhatName == "Bob") || (WhatName == "Alice"))
                    {
                        Console.WriteLine("Hello " + WhatName + "!");
                    }

    Console.WriteLine("\n Wciśnij klawisz aby wyjsc");
                    Console.ReadKey();
        }
    }
}
