using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LInqToObjects
{
    class ElementOperations
    {
        public static void FindElement()
        {
            // ElementAt -Returns the element at a specified index in a collection.
            //var strings = new string[] { "zero", "one", "two", "three" };
            //var str = strings.ElementAt(2);

            //Console.WriteLine(str);

            //var str1 = strings.ElementAtOrDefault(6);
            //Console.WriteLine(str1);

            int[] num = new int[] { 2, 3, 4, 5, 6, 7, 5,2 };
            //// Returns the first element of a collection, or the first element that satisfies a condition.
            //var first = num.First();
            //Console.WriteLine(first);


            // Returns the first element of a collection, or the first element that satisfies a condition. Returns a default value if no such element exists.

            //var val = num.FirstOrDefault(x => x < 0);
            //Console.WriteLine(val);

            //LAST and LASTorDefault

            // Returns the only element of a collection or the only element that satisfies a condition.
            var numbers = new int[] { 1,3,5,7 };
            var single = numbers.Single();
            Console.WriteLine(single);

        }
    }
}
