using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Concepts
{
    class MethodParameters
    {
        // optional parameters
        public static int AddUs(int num1, int num2 = 0)
        {

            return num1 + num2;
        }
        // parameters
        public int AddAgain(int num1, int num2)
        {
            return num1 + num2;
        }
        //must be single dimensionl array
        public int Add(params int[] val)
        {

            return 23 + 23;
        }

    }
}
