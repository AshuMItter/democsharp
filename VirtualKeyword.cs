using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Concepts
{
    
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
            base.ParentClass();
            Console.WriteLine("Hello from ABC");
        }

    }
    class ABCD : ABC
    {
        public override void ParentClass()
        {
            base.ParentClass();
            Console.WriteLine("Hello from ABCD");

        }
    }
}

