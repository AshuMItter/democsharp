using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LInqToObjects
{
    class Filtering
    {
        public void DoFilter()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


          // var res =  numbers.Where(x => x > 3);
            // filtering
            var list = numbers.Where(x => x > 4);

            object[] obj = new object[] { 34, "Ashu", 56, 67.89m, "Light" };

            // or query
            var res1 = from num in numbers where num > 4 select num;

            // ofType

            var ofType = obj.OfType<string>();

            var res = obj.OfType<int>();

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

        }
    }
}
