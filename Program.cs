using System;
using EFOscilationsDemo.Repository;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFOscilationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            //Console.WriteLine("Hello All from Oscilations!");
            //Person person = new Person() { Age = 125, LocationOfthePerson = "Russia", NameOfthePerson = "Vladimier Putin" };
            //Console.WriteLine(OscilationsCRUDOperations.CreateData(person));
            //Person row = new Person();
            //row.LocationOfthePerson = "India";
            //row.NameOfthePerson = "Rakesh";
            //row.Age = 23;
            //OscilationsCRUDOperations.UpdateData(row);



            // Console.WriteLine(OscilationsCRUDOperations.DeleteDate(new Person() { NameOfthePerson= "Rakesh" }));
            
            var res = from person in OscilationsCRUDOperations.FetchData()
                     
                      select person;

            foreach (var item in res)
            {
                Console.WriteLine($"{item.NameOfthePerson,5}");
                Console.WriteLine($"{item.LocationOfthePerson,15}");
                Console.WriteLine($"{item.Age,25}");
                
            }
           
        }
    }




    static class OscilationsCRUDOperations
    {
        public static int CreateData(Person data)
        {
            var ctx = new OscilationsContext();
            ctx.People.Add(data);

            return ctx.SaveChanges();
        }
        public static int UpdateData(Person data)
        {
            var ctx = new OscilationsContext();
            var row = ctx.People.First(x => x.RollNo == 2);

            row.LocationOfthePerson = data.LocationOfthePerson;
            row.NameOfthePerson = data.NameOfthePerson;
            row.Age = data.Age;

           // ctx.People.Add(row);
           return ctx.SaveChanges();

        }

        public static int DeleteDate(Person data)
        {
            var ctx = new OscilationsContext();

            var res = ctx.People.First(x=>x.NameOfthePerson== data.NameOfthePerson);

            ctx.People.Remove(res);

            return ctx.SaveChanges();


        }

        public static DbSet<Person> FetchData()
        {
            var ctx = new OscilationsContext();
            return ctx.People;
        }


    }

}
