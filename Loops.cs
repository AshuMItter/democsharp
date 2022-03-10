using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Demos
{
    class Loops
    {
        public void SetUpLoops()
        {
            

            for (int i = 0; i < 45; i++)
            {

            }
            int k = 0;
            //while( k >= 56)
            //{
            //    Console.WriteLine("Happy Learning");
            //    k++;
            //}

            //do
            //{
            //    k++;
            //    Console.WriteLine("Hello from while loop");

            //} while (k <= 10);

            string backing = "STRING";

            foreach (var item in backing.ToCharArray())
            {
                
                Console.WriteLine(item);
            }
          
        }
    }
}
