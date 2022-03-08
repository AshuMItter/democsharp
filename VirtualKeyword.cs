using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Concepts
{
    class VirtualKeyword
    {
    }
    class AB
    {
        public virtual void ParentClass()
        {
            Console.WriteLine("Hello from AB");
        }
    }
    class ABC : AB
    {
        public override void ParentClass()
        {
            Console.WriteLine("Hello from ABC");
        }

    }
}

