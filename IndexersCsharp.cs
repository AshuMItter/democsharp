using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
namespace DemoOne.Demos
{
    class IndexersCsharp
    {
    }
    public class Days
    {
        private string[] Day = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        
         public int this[string day]
        {
            get
            {
                return Array.IndexOf(Day,day);
            }
        }
      
     
    }
    public class Person
    {
       
        private string[] names = new string[20];
      
       
        public string this[int i]
        {
            get
            {
                return names[i];
            }
            set
            {
                names[i] = value;
            }
        }
        interface IFace
        {

            public string this[int i]
            {
                get;
                set;
            }
        }


    }
}
