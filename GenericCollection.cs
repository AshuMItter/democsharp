using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Demos
{
    class GenericCollection
    {
        public void GenericDictionaryDemo() {

            Dictionary<int, string> dictio = new Dictionary<int, string>();
            dictio.Add(0, "Monday");
            dictio.Add(1, "Tuesday");
            dictio.Add(2, "Wednesday");
            dictio.Add(3, "Thursday");
            dictio.Add(4, "Friday");
            dictio.Add(5, "Saturday");

            //checks if these were added return true else return false.
            Console.WriteLine(dictio.TryAdd(6, "Abc"));



            //string val = "";
            //dictio.TryGetValue(8, out val);
            //Console.WriteLine(val);

            // traversing
            foreach (var item in dictio)
            {
                Console.WriteLine(item);
            }
        }
        public void GenericListDemo()
        {

            List<string> names = new List<string>() { "Monday", "Tuesday", "Wednesday" };

            Console.WriteLine(names[2]);    
            
           

          List<string> liststring = new List<string>();
            liststring.Add("Ashu");
            liststring.Add("Meet");

           
        }
        public void GenericSortedDictionaryDemo()
        {
            SortedDictionary<int, string> sortD = new SortedDictionary<int, string>();
            sortD.Add(0, "A");
            sortD.Add(11, "D");
            sortD.Add(8, "G");
            sortD.Add(100, "F");
            sortD.Add(56, "B");
            sortD.Add(12, "C");

            sortD.Remove(12);

         
            bool val = sortD.TryAdd<int, string>(34, "Value");
           
            foreach(var item in sortD)
            {
                Console.WriteLine(item.Key);
                
            }

        }
        public void GenericQueueandList()
        {

            // queue
            Queue<int> qu = new Queue<int>();
            qu.Enqueue(1);
            qu.Enqueue(2);
            qu.Enqueue(3);
            qu.Enqueue(4);           


            foreach (var item in qu)
            {
               Console.WriteLine($"Items in the Queue :{item}");
            }
            qu.Dequeue();
            qu.Enqueue(20);
            foreach (var item in qu)
            {
               Console.WriteLine($"Items in the queue: {item}");
            }

            //stack
            Stack<int> stk = new Stack<int>();
            stk.Push(45);
            stk.Push(50);
            stk.Push(55);
            stk.Push(60);

            foreach (var item in stk)
            {
              //  Console.WriteLine(item);
            }
            stk.Pop();
            
            foreach (var item in stk)
            {
              //  Console.WriteLine(item);
            }

        }


}
    }

