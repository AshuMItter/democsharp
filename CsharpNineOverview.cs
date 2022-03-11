using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Demos
{
    class CsharpNineOverview
    {

        class Students
        {
            public string FirstName { get; init; }
            public string LastName { get; init; }
        }
        public void Demo()
        {

            Student st = new() { Age = 50, Name = "Leo" };
            Console.WriteLine(IsPasses(st));

            Students stds = new Students() { FirstName = "Geet", LastName = "Meet" };


            Member mem = new Member() { Address = "Pune", FirstName = "Ameet", LastName = "Bmeet", ID = 56 };

            // adding new value;
            var newmem = mem with { Address = "Mumbai" };

            Console.WriteLine(newmem);
            




        }
        public static bool IsPasses(Student student)
        {
            return student is ({ Age: >= 40, } or { Name: "Jaggu" })
                           and not { Age: < 50 };
        }
        public record Member
        {
            public int ID { get; init; }
            public string FirstName { get; init; }
            public string LastName { get; init; }
            public string Address { get; init; }
        }


    }
    }

