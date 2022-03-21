using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LInqToObjects
{
    class DemoCollection
    {
        public static void CollectionDemo()
        {
            List<string> myList = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                myList.Add("Item " + i.ToString());
            }
            IEnumerator<string> lst = myList.GetEnumerator();

            Console.WriteLine(lst.Current);
            lst.MoveNext();
            Console.WriteLine(lst.Current);
            lst.MoveNext();
            Console.WriteLine(lst.Current);
            lst.MoveNext();
            Console.WriteLine(lst.Current);
            lst.MoveNext();
            Console.WriteLine(lst.Current);
            lst.MoveNext();
            lst.Reset();
            Console.WriteLine(lst.Current);

            PowersOfTwo two = new PowersOfTwo();
            foreach (var item in two)
            {
                Console.WriteLine(item);
            }

        }
    }

    class PowersOfTwo : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new PowersOfTwoEnumerator();
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class PowersOfTwoEnumerator : IEnumerator<int>
    {
        private int index = 0;

        public int Current
        {
            get { return (int)System.Math.Pow(2, index); }
        }

        object System.Collections.IEnumerator.Current
        {
            get { return Current; }
        }

        public bool MoveNext()
        {
            index++;

            if (index > 10)
                return false;
            else
                return true;
        }

        public void Reset()
        {
            index = 0;
        }

        public void Dispose()
        {
        }
    }

}
