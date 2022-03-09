using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Demos
{
    class DelegatesCSharp
    {
        public delegate int MyDelegate(string s);
        public delegate int AnyName(int id, int age);

        public int AnyNameoftheDemoth(int one, int two)
        {
            return 0;
        }

        public int DemoDelgateMethod1(string value)
        {
            Console.WriteLine(value+" from MyDelegate");
            return 34;
        }
        public int DemoDelgateMethod2(string value)
        {
            Console.WriteLine(value + "from Method 2");
            return 34;
        }
        public int DemoDelgateMethod3(string value)
        {
            Console.WriteLine(value + "from Method 3");
            return 34;
        }

        public void SetUpDelegate()
        {
           

            // singlecast
            

            MyDelegate delegte = new MyDelegate(DemoDelgateMethod1);

           // delegte.Invoke("String");
           // delegte("Referenced Method called");




            MyDelegate delMultiple;



            MyDelegate del = new MyDelegate(DemoDelgateMethod1);
            MyDelegate del2 = new MyDelegate(DemoDelgateMethod2);

            MyDelegate del3 = new MyDelegate(DemoDelgateMethod3);

            // multicast delegate
            delMultiple = del;
            del += del2;
            del += del3;

            del("hello from delegate");
            
        }
        public void MethodAsParameters(string name, MyDelegate del)
        {
            del(name);
        }
    }
}
