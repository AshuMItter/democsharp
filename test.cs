using System;
using System.Collections.Generic;
using System.Text;
using TestProject1;
namespace TestProject1
{
    class SuperTest{
        }
    class test : SuperTest
    {

        public int a = 90;
        public static int Largest(int[] list)
        {
            throw new InvalidCastException("Messsage");
            int index, max = 5;
            for (index=0; index<list.Length;index++)
            {
                if(list[index] > max)
                {
                    max = list[index];
                }
            }
            return max;
        }
      
       

        

    }
}
    

