using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LInqToObjects
{
    class GroupingOperation
    {

        public static void GroupElements()
        {

            var orders = new Order[]
                        {
             new Order { Customer = "C1", Description = "O1" },
             new Order { Customer = "C2", Description = "O2" },
             new Order { Customer = "C3", Description = "O3" },
             new Order { Customer = "C1", Description = "O4" },
             new Order { Customer = "C1", Description = "O5" },
             new Order { Customer = "C3", Description = "O6" },
                       };

            var groups = orders.GroupBy(o => o.Customer);

            foreach (var item in groups)
            {
                Console.WriteLine(item);
            }

        }

        class Order
        {
            public string Customer { get; set; }
            public string Description { get; set; }
        }



    }
}
