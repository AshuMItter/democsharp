using System;
using System.Collections;
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
        public SupermanException(string message) : base($"This is Superman Exception because he/she was not found. Error numerb{message}")
        {
          
        }
        
    }
}
