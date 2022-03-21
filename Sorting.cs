using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LInqToObjects
{
    class Sorting
    {
        public static void PerformSorting()
        {
            string[] words = { "On", "a","the", "quick", "brown", "fox", "jumps", "oceanWave" };

            int[] marks = new int[] { 90, 56, 23, 78, 56, 90, 100, 24 };
            // ascendig sort


            //var  query = from word in marks
            //             orderby word descending
            //             select word;

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}

            //// descding sort
            //var numbers = new int[] { 5, 4, 8, 2, 7, 1, 9, 3, 6 };
            //var ordered = from n in numbers
            //              orderby n descending
            //              select n;
            //// ordered = { 9, 8, 7, 6, 5, 4, 3, 2, 1 }


            char[] arr = new char[] { 'a', 'z', 'b', 'c', 'x' };

            var value = from chr in arr
                        orderby chr descending
                        select chr;

            foreach (var item in value)
            {
                Console.WriteLine(item);
            }


            //// secondary sort in descending - two variants for sorting
            string[] words1 = { "the", "quick", "brown", "fox", "jomps" };

            words1.OrderBy(x => x.Length).ThenBy(x => x.Contains("o"));

            var ordered1 = from w in words1
                           orderby w.Length, w.Contains("o")
                           select w;
            foreach (var item in ordered1)
            {
                Console.WriteLine(item);
            }
            // ordered1 = { "fox", "the", "brown", "jumps", "quick" }



        }
    }
}
