using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace LInqToObjects
{
    [Serializable]
    class DemoDataOne
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {


       object abc =  Deserialization.DeSerialization();
            //data source
            List<DemoDataOne> daTa =(List<DemoDataOne>) Deserialization.DeSerialization();

            //query
            var res = from data in daTa
                      where data.Age == 22
                      select data;

            //execution

            foreach (var item in res)
            {
                Console.WriteLine(item.Name);
            }


                       



            //var res = from alpha in DAL.FetchData()
            //          orderby alpha descending
            //          select alpha;

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //SetOperations.Operations();
            //ElementOperations.FindElement();
            // Sorting.PerformSorting();
            //Joins.PerformZip();
            // ConcatinationOperation obj = new ConcatinationOperation();
            // obj.ConatinatePlease();
            //List<DemoDataOne> obj = new List<DemoDataOne>();
            //obj.Add(new DemoDataOne() { Age = 22, Name = "Joe" });
            //obj.Add(new DemoDataOne() { Age = 22, Name = "Rahul" });
            //obj.Add(new DemoDataOne() { Age = 23, Name = "Narendra" });
            //obj.Add(new DemoDataOne() { Age = 22, Name = "Kamla" });
            //obj.Add(new DemoDataOne() { Age = 22, Name = "Ashumeet" });
            //obj.Add(new DemoDataOne() { Age = 24, Name = "Yogi" });
            //obj.Add(new DemoDataOne() { Age = 22, Name = "Kalpesh" });
            //obj.Add(new DemoDataOne() { Age = 26, Name = "Kejriwal" });
            //obj.Add(new DemoDataOne() { Age = 22, Name = "Didi" });

            //var resset = obj.Where(x => x.Age == 22);

            //Filtering obj = new Filtering();
            //obj.DoFilter();
            //var names = from name in obj
            //            where name.Name == "Didi"
            //            select name;


            //foreach (var item in names)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //string[] days = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri" };

            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ////ListOfStudentData.ListOfStudents

            // List<DemoDataOne> lIts=(List<DemoDataOne>) Deserialization.DeSerialization();




            //var res = from a in numbers
            //          where a % 3 == 0
            //          select a;


            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            // Sorting.PerformSorting();
            //  Aggregate.AggregateLinq();
            //   QuantifierOperations.QuantiFyOpt();
            //  GroupingOperation.GroupElements();
            // ElementOperations.FindElement();
            // AnonymousMethods.AnonymousMethod();

            //var res = from alpha in DAL.FetchData()
            //          select alpha;

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //SetOperations.Operations();
            // DemoCollection.CollectionDemo();
        }
    }
}
   
