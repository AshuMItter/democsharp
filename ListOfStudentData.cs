using System;
using System.Collections.Generic;
using System.Text;

namespace LInqToObjects
{
    class ListOfStudentData
    {
        public static List<DemoDataOne> ListOfStudents {

            get {
                List<DemoDataOne> daTa = new List<DemoDataOne>();
                daTa.Add(new DemoDataOne() { Age = 22, Name = "Neelam" });
                daTa.Add(new DemoDataOne() { Age = 22, Name = "Rohan" });

                daTa.Add(new DemoDataOne() { Age = 21, Name = "Roshan" });

                daTa.Add(new DemoDataOne() { Age = 22, Name = "Seema" });

                daTa.Add(new DemoDataOne() { Age = 23, Name = "Joe" });

                daTa.Add(new DemoDataOne() { Age = 22, Name = "Rekha" });

                daTa.Add(new DemoDataOne() { Age = 22, Name = "Sridharan" });

                return daTa;
            }




        }
    }
}
