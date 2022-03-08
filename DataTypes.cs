using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Concepts
{
    class DataTypes
    {
        public void DataTypeDemo() {
            int? nul34 = null;



            int a = 34;
            short a1 = 34;
            long a2 = long.MaxValue;

            string data = "78";
            int con = Convert.ToInt32(data);


            char b = 'A';

            float c = 34.56f;  // 6 bytes scientific value
            double d = 45.56;       // 8 bytes scientific values

            byte e = 34;    //unsiged  not negative
            sbyte f = 45;   //signed  negative
            decimal g = 45.89898m;   // 18 bytes/ for financial data/ are slower/ high precesion
            string name = "Meet";
            object obj = 56;
            dynamic nm = 67;  // dynamically typed

            Console.WriteLine(byte.MaxValue);


            var namevar = "Ashu"; // only local scope/ staticaly typed/ code readability


            int? nul = null;
            int abc = Convert.ToInt32(nul);
            Console.WriteLine("Hi default Value: " + abc);


            char? ab = null;
            decimal? deci = null;
            Console.WriteLine("Decimal :" + Convert.ToDecimal(deci));

            // Nullable<int> ie = null;


            // int val=  Convert.ToInt32(a2); // error
            //decimal val2= Convert.ToDecimal(double.MaxValue); // error

            double dou = Convert.ToDouble(decimal.MaxValue); //explicit conversion
            Console.WriteLine(dou);

            double doub = long.MaxValue;  // implicit conversion


        }
    }
   
}
