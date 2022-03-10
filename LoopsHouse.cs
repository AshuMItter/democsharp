using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Demos
{
    class LoopsHouse
    {
        static short a, b;

        public static void MakeAHutOfNumbers()
        {

            a = 30;
            b = 46;

            for (int i = 17; i < 20; i++)
            {

                Console.SetCursorPosition(0, i);
                for (int t = 0; t < 80; t++)
                {
                    if (t <= 24)
                    {
                        Console.Write("+");
                    }
                    else if (t >= 56)
                    {
                        Console.SetCursorPosition(t, i);
                        Console.Write("+");
                    }


                }
            }
            for (int p = 8; p < 15; p++)
            {
                Console.SetCursorPosition(b + 3, p);
                Console.Write(1);
                b++;
            }
            for (int q = 15; q < 20; q++)
            {
                Console.SetCursorPosition(b + 2, q);
                Console.WriteLine(1);
            }
            for (int s = 43; s < 55; s++)
            {
                Console.SetCursorPosition(s, 19);
                Console.Write(s);
            }
            for (int t = 16; t < 19; t++)
            {
                Console.SetCursorPosition(47, t);
                Console.WriteLine(t.ToString() + t.ToString());
            }
            for (int i = 8; i < 15; i++)
            {

                Console.SetCursorPosition(a, i);
                a--;
                for (int j = 0; j < 15; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
                if (a == 23)
                {
                    for (int m = 14; m < 19; m++)
                    {
                        Console.SetCursorPosition(a, m + 1);


                        for (int j = 15; j < 25; j++)
                        {
                            Console.Write(j);
                        }
                        Console.WriteLine("");
                    }
                }

            }


        }
    }
}
