using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Concepts
{
    class StringBuildescsharp
    {
        public void StringBuidingDemo()
        {
            //string builder
            //mutable
            StringBuilder sb1 = new StringBuilder("Hello World");
            sb1.Append("All ");
            sb1.Append("Yes you all!");
            sb1.Replace('A', 't');

            Console.WriteLine(sb1);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("I am From Russia");
            sb.AppendLine("I am From Russia");
            sb.AppendLine("I am From Russia");
            sb.AppendLine("I am From Ukraine");
        }
    }
}
