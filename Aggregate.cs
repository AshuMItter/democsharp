using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LInqToObjects
{
    class Aggregate
    {
        public static void AggregateLinq()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var product = numbers.Aggregate(1, (acc, n) => acc * n);

           var values =  numbers.Aggregate(1, (a, b) => a * b);

            Console.WriteLine(numbers.Average());

            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(values);

            // select min(Price) from TableName

            var p = numbers.Aggregate(1, (n,a) => n*a );
            Console.WriteLine(p);
        }
    }
}
