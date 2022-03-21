using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LInqToObjects
{
    class Joins
    {
        public static void PerfromJoin()
        {
            //right table
            var customers = new Customer[]
                {
               new Customer { Id = 1, Name = "C1", Age = 45 },
               new Customer { Id = 2, Name = "C2", Age = 40 },
               new Customer { Id = 3, Name = "C3", Age = 40 },
               new Customer { Id = 4, Name = "C4", Age = 40 },
               new Customer { Id = 5, Name = "C5", Age = 40 },
                new Customer { Id = 6, Name = "C6", Age = 40 },
                 new Customer { Id = 7, Name = "C7", Age = 40 },
                 
            };
            // left table
               var orders = new Order[]
            {
             new Order { Description = "O1", CustomerId = 1, Price = 23 },
             new Order { Description = "O2", CustomerId = 2,Price = 23 },
             new Order { Description = "O3", CustomerId = 3,Price = 23 },
             new Order { Description = "O4", CustomerId = 4,Price = 23 },
              new Order { Description = "O5", CustomerId = 5,Price = 23 },
               new Order { Description = "O6", CustomerId = 6,Price = 23 },
                 new Order { Description = "O7", CustomerId = 7,Price = 23 },
                   new Order { Description = "O8", CustomerId = 8,Price = 23 },
            };
          //  join in on equals
            var join = customers.Join(orders, c => c.Id, o => o.CustomerId, (c, o) => c.Name + " _ " + o.Description);

            var res = from c in customers
                      join o in orders
                      on c.Id equals o.CustomerId
                      select o.Description + "_" + c.Name +"_"+o.Price+"_"+c.Age;

            //var res1 = from o in orders
            //           join c in customers
            //           on o.CustomerId equals c.Id  into OC_Group
            //           select OC_Group;

            //foreach (IEnumerable<Customer> productGroup in res1)
            //{
            //   // Console.WriteLine("Group");
            //    foreach (var item in productGroup)
            //    {
            //        Console.WriteLine(item.Name);
            //    }
            //}


            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        public static void PerformZip()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] name = new string[] { "Ashu", "Lashu", "Pashu" };
         //   string[] name1 = new string[] { "Ashu", "Lashu", "Pashu" };

            var res = numbers.Zip(name, (numbers,name) => name + "_" + numbers);

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

        }
    }
   
    class Customer { 

 public int Id { get; set; }
    public string Name { get; set; }
        public int Age { get; set; }
    }

class Order
{
    public string Description { get; set; }
    public int CustomerId { get; set; }
        public int Price { get; set; }
    }



}
