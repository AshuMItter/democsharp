using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Concepts
{
    class PassByRef
    {
        public int IncrementExample(ref int num)
        {
         
            num = num + 1;
            return num;
        }
    }
}
