using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace LInqToObjects
{
    class DAL
    {
        public static string[] FetchData()
        {
           string read= File.ReadAllText(@"C:\Users\ANKIT\Desktop\Demos\alpha.txt");
            string[] chunk = read.Split(",");
            return chunk;

        
        }

    }
}
