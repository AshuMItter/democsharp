using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Concepts
{
    class StringConcatimationcSharp
    {
        public void StringConcat()
        {

            //strin concatination
            string userName = "<<Type your name here>>";
            string date = DateTime.Today.ToShortDateString();

            // Use string interpolation to concatenate strings.
            string str = $"Hello {userName}. Today is {date}.";
            System.Console.WriteLine(str);


            string vaLue = "Squence of Character";
            string nm1 = "Joe";
            string address = "Pune" + nm1;

            string neWay = $"My name is {nm1}. I live in {address}. ";


        }
    }
}
