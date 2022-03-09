using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Demos
{
    class CustomException
    {
    }
    class SupermanException : Exception
    {
        public SupermanException()
        {

        }
        public SupermanException(string message) : base($"Superman is not found named: {message}")
        {
           
        }
    }
}
