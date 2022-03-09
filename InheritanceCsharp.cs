using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Concepts
{
    class InheritanceCsharp
    {
        interface Iface
        {
            // constants are allowed
            const int X = 0;
            static Iface()
            {

            }

        }
        public sealed class D
        {
            // Class members here.
        }
        abstract class BaseClass
        {
            public void MethodInBaseClass()
            {
                Console.WriteLine("Method in base Class");
            }
            public virtual void MethodCanBeExtended()
            {
                Console.WriteLine("Base Class Method");
            }



        }
        class ChildClass : BaseClass
        {
            public void MethodInChildClass()
            {
                Console.WriteLine("Method in Child Class");
            }

            //sealed
            public override void MethodCanBeExtended()
            {
                base.MethodCanBeExtended();
                Console.WriteLine("Method in Child Class Ovveride");
            }

        }
        class NextLevel : ChildClass
        {
            public void MethodInNextLevel()
            {
                Console.WriteLine("Method in Next Level");
            }
            public override void MethodCanBeExtended()
            {
                base.MethodCanBeExtended();
                Console.WriteLine("Method in Next Level Ovveride");
            }
        }
        class NextToNextLevel : NextLevel
        {

            public void MethodInNextToNextLevel()
            {
                Console.WriteLine("Method in Next to Next Level");
            }
            public override void MethodCanBeExtended()
            {
                base.MethodCanBeExtended();
                Console.WriteLine("Method in Next to Next Level Ovveride");
            }
        }



      
    }
}
