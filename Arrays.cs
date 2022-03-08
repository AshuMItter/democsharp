using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Concepts
{
    class Arrays
    {
        public void InitiateArrays()
        {
            //arrys 
            //1D
            int[] array1 = new int[5] { 34, 56, 23, 56, 23 };

            // data-type[] identifier = new data-type[length];
















            //
            Console.WriteLine(array1.Length);
            int[]? array2 = new int[5];

            // specific index
            Array.Copy(array1, array2, 2);

            //sort
            Array.Sort(array1);

            //running inbult query methods
            int[] arr = Array.FindAll(array2, x => x == 34);

            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }



            int[,] darrays = new int[2, 2] { { 1, 2 }, { 3, 5 } };

            foreach (var item in darrays)
            {
                Console.WriteLine("2d arrays " + item);
            }


            //arrays
            //2D                 //rows - columns
            int[,] arr2d = new int[3, 2]{  // [00,01
                                           //  10,11
                                           //  20,21]
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };
            //0  1    2
            //1
            //2

            //  arr2d[0, 0]; //returns 1
            //  arr2d[0, 1]; //returns 2
            //  arr2d[1, 0]; //returns 3
            //  arr2d[1, 1]; //returns 4
            //   arr2d[2, 0]; //returns 5
            //   arr2d[2, 1]; //returns 6
            //arr2d[3, 0]; //throws run-time error as there is no 4th row


            // int[,,,,] array3d = new int[5,3, 2, 2, 2] {}

            //3d arrays
            int[,,] arr3d1 = new int[1, 2, 2]{
                { { 1, 2}, { 3, 4} }
            };

            int[,,] arr3d2 = new int[2, 2, 2]{
                { {1, 2}, {3, 4} },
                { {5, 6}, {7, 8} }
            };

            int[,,] arr3d3 = new int[2, 2, 3]{
                { { 1, 2, 3}, {4, 5, 6} },
                { { 7, 8, 9}, {10, 11, 12} }
            };
            //   arr3d2[0, 0, 0]; // returns 1 
            //    arr3d2[0, 0, 1]; // returns 2 
            //    arr3d2[0, 1, 0]; // returns 3 
            //     arr3d2[0, 1, 1]; // returns 4 
            //     arr3d2[1, 0, 0]; // returns 5 
            //     arr3d2[1, 0, 1]; // returns 6 
            //      arr3d2[1, 1, 0]; // returns 7 
            //      arr3d2[1, 1, 1]; // returns 8 

            Console.WriteLine(arr3d2[1, 1, 1]);

            // Declare a jagged array.
            int[][] jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array structure.
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };


            int[][] jagarray = new int[5][];

            jagarray[0] = new int[3] { 1, 2, 4 };
            jagarray[1] = new int[3] { 1, 2, 4 };

            jagarray[2] = new int[3] { 1, 2, 4 };

            jagarray[3] = new int[3] { 1, 2, 4 };
            jagarray[4] = new int[3] { 1, 2, 4 };


            // arrays
            int[] intarray = new int[] { 23, 56, 23, 45, 34, 23, 45, 23 };

            object[] objarray = new object[] { "ashu", 78, 'C', 34.67d, 89.45m, 56.990 };

            // Array.Sort(objarray);

            string[] days = new string[] { "A", "C", "B", "D" };


            int[] val = Array.FindAll(intarray, x => x == 23);


            foreach (var anyname in objarray)
            {
                Console.WriteLine(anyname);
            }



            Console.WriteLine(intarray[0]);








        }
    }
}
