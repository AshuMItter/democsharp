using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LInqToObjects
{
    class QuantifierOperations
    {
    public static void QuantiFyOpt()
        {

          List<Market> markets = new List<Market>
          {
          new Market { Name = "Emily", Items = new string[] { "kiwi", "cheery", "banana" } },
          new Market { Name = "Kim", Items = new string[] { "melon", "mango", "olive" } },
          new Market { Name = "Adam", Items = new string[] { "kiwi", "apple", "orange" } },
          };

            // Determine which market have all fruit names length equal to 5
            var names = from market in markets
                        where market.Items.All(x => x.Length == 5)
                        select market.Name;

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
          

            

        }
    }
    class Market
    {
        public string Name { get; set; }
        public string[] Items { get; set; }
    }

    
}
