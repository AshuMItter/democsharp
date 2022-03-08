using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Concepts
{
    class MethodOverloadingDemo
    {
        static void MethodOverloading(string name)
        {

        }
        // overloaded method
        static void MethodOverloading(int age)
        {

        }
        // overloaded method
        static void MethodOverloading(string name, int age)
        {

        }
        // overloaded method
        static void MethodOverloading(int age, string name)
        {

        }
    }
}
