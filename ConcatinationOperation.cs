using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LInqToObjects
{
    class ConcatinationOperation
    {
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int[] numbers1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        string[] days = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri" };

        public void ConatinatePlease()
        {
            
            var lst = numbers.Concat(numbers1);
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
        }

        public void DemoFiltering()
        {
            
        }
    }
}
