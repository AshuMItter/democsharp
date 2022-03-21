using System;
using System.Collections.Generic;
using System.Text;

namespace LInqToObjects
{
    class AnonymousMethods
    {
        public delegate void Print (int a);

        public static void NormalMethod()
        {
            Print print = new Print(DoPriting);

        }
        
        public static void AnonymousMethod()
        {
            Print print = delegate (int a)
            {
                Console.WriteLine(a);
            };
            print(34);
        }
       
        public static void Lambda()
        {
            int ab = 90;
            Print print = new Print( a =>  Console.WriteLine(a) );
             // list.FirstOrDefault(x => x == 23)

        }
        public static void DoPriting(int a)
        {
            Console.WriteLine(a);
        }





    }
}
