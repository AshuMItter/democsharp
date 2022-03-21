using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LInqToObjects
{
    class SetOperations
    {
        public static void Operations()
        {
            // Distinct
            var numbers = new int[] { 1, 2, 3, 1, 2, 3 };
            var distinct = numbers.Distinct();
            foreach (var item in distinct)
            {
                Console.WriteLine(item);
            }


            // Except only excepted values
            var numbers1 = new int[] { 1, 2, 3, 4, 5 };
            var numbers2 = new int[] { 4, 5, 6, 7, 8 };
            var except = numbers1.Except(numbers2);
            foreach (var item in except)
            {
                Console.WriteLine(item);
            }
        }
    }
}
