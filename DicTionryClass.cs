using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
namespace DemoOne.Demos
{
    class DicTionaryClass
    {

        public Dictionary<int,string> Names {
            get
            {
                return GetDictionary();
            }
            
           
        
        
        }


        public Dictionary<int,string> GetDictionary()
        {
            return new Dictionary<int, string>() { { 1, "Ashu" }, { 2, "Negar" }, { 3, "Manpreet" }, { 4, "Raghav" } };
        }
    }
}
