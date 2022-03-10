using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DemoOne.Demos
{
    class CollectionsCsharp
    {
        public void ArrayListDemo()
        {
            
            // to store hetrogenous data 
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add("Hello");
            myArrayList.Add(34);
            //boxing 
            myArrayList.Add(56.56m);

           
            //unboxing 
            int a = Convert.ToInt32(myArrayList[2]);

            // boxing - value to object
            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }

            //object to int
            // int a = myArrayList[1];

            Queue obj = new Queue();
            obj.Enqueue(34);
            obj.Enqueue("Ashu");
            obj.Enqueue(34.67m);

            // object only
            Object d = obj.Peek();

            

           
            
        }
    }
}
