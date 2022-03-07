using System;
using System.Text;
using DemoOne.Properties;
using DemoOne.Calculator;

namespace DemoOne
{
   class MyProperties
    {
        int _age = 45;
        string _name=" ";

        public string Name {

            get {
               
                return _name;
            }
            set
            {

                _name = value;
            }
        
        
        }
        public int Age {

            get
            {

                return _age;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Wrong Entry! Value did not save");
                }
                else
                {
                    _age = value;
                }
            }
        
        }



    }
    class Program
    {

        int _age;


        public int Age {

            get {
                return _age;
            }
            set
            {
                   
                _age = value;
            }


           
        
        
        }


        // auto implemented propertie
        // public int Age { get; set; }
        static void Main(string[] args)
        {

            int age = 50;
            Student.PassByRef(ref age);
            Console.WriteLine(age);
                


            int num = 1; //memory address not the value
            IncrementExample(ref num);
            // num is now 2
            Console.WriteLine(num);



            Student student = new Student();

            Console.WriteLine(student.CreateMyFullName("Joe", "Biden"));



            student.CreateMyNameTwo(3, 4, 6, 35, 78, 23, 67, 89, 12, 34, 89, 40, 34);





















      //  string string2 = new string('c', 20);

           // string string2 = new string('c', 40);

           // string namestring = new string("Number One String");
          //  Console.WriteLine(namestring);
         //   Console.WriteLine(string2);


            string vaLue = "Squence of Character";
            string nm1 = "Joe" ;
            string address = "Pune" +nm1;

            string neWay = $"My name is {nm1}. I live in {address}. ";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("I am From Russia");
            sb.AppendLine("I am From Russia");
            sb.AppendLine("I am From Russia");
            sb.AppendLine("I am From Ukraine");


            Console.WriteLine(sb);

           
            
            
            // char[] charArray = vaLue.ToCharArray();
           // Console.WriteLine(information);
            //inbuilt string methods

        //    Console.WriteLine(information.Trim());


            










            // arrays
            int[] intarray = new int[] {23,56,23,45,34,23,45,23};

            object[] objarray = new object[] { "ashu", 78, 'C', 34.67d, 89.45m, 56.990 };

           // Array.Sort(objarray);

            string[] days = new string[] { "A","C","B","D" };


            int[] val = Array.FindAll(intarray, x => x == 23);
           

            foreach (var anyname in objarray)
            {
                Console.WriteLine(anyname);
            }

            

            Console.WriteLine(intarray[0]);




















            MyProperties props = new MyProperties();
            Console.WriteLine(props.Age);
            props.Age =0;
            Console.WriteLine(props.Age);

            //calling
            Console.WriteLine(AddUs(34));
            


         

            Console.WriteLine(num);

            //string builder
            //mutable
            StringBuilder sb1 = new StringBuilder("Hello World");
            sb1.Append("All ");
            sb1.Append("Yes you all!");
            sb1.Replace('A', 't');

            Console.WriteLine(sb1);
            




            //strin concatination
            string userName = "<<Type your name here>>";
            string date = DateTime.Today.ToShortDateString();

            // Use string interpolation to concatenate strings.
            string str = $"Hello {userName}. Today is {date}.";
            System.Console.WriteLine(str);

            // var cv = 56;   // statically typed - 


            // data-type identifier = value ;

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
            Console.WriteLine("Hi default Value: "+abc);


            char? ab = null;
            decimal? deci = null;
            Console.WriteLine("Decimal :"+Convert.ToDecimal(deci));

           // Nullable<int> ie = null;
            






         // int val=  Convert.ToInt32(a2); // error
         //decimal val2= Convert.ToDecimal(double.MaxValue); // error

            double dou = Convert.ToDouble(decimal.MaxValue); //explicit conversion
            Console.WriteLine(dou);

            double doub = long.MaxValue;  // implicit conversion



            //arrys 
            //1D
            int[] array1 = new int[5] { 34, 56, 23, 56, 23 };

            // data-type[] identifier = new data-type[length];


            













            //
            Console.WriteLine(array1.Length);
            int[]? array2 = new int[5];

            // specific index
            Array.Copy(array1, array2,2);

            //sort
            Array.Sort(array1);

            //running inbult query methods
            int[] arr = Array.FindAll(array2, x => x == 34);

            foreach (var item in array2)
            {
                Console.WriteLine(item);
            }



            int[,] darrays = new int[2,2] { {1,2 },{ 3, 5 } };

            foreach (var item in darrays)
            {
                Console.WriteLine("2d arrays "+item);
            }


            //arrays
            //2D                 //rows - columns
            int[,] arr2d = new int[3, 2]{  // [00,01
                                           //  10,11
                                           //  20,21]
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };        
            //0  1    2
            //1
            //2

            //  arr2d[0, 0]; //returns 1
            //  arr2d[0, 1]; //returns 2
            //  arr2d[1, 0]; //returns 3
            //  arr2d[1, 1]; //returns 4
            //   arr2d[2, 0]; //returns 5
            //   arr2d[2, 1]; //returns 6
            //arr2d[3, 0]; //throws run-time error as there is no 4th row


           // int[,,,,] array3d = new int[5,3, 2, 2, 2] {}

            //3d arrays
            int[,,] arr3d1 = new int[1, 2, 2]{
                { { 1, 2}, { 3, 4} }
            };

            int[,,] arr3d2 = new int[2, 2, 2]{
                { {1, 2}, {3, 4} },
                { {5, 6}, {7, 8} }
            };

            int[,,] arr3d3 = new int[2, 2, 3]{
                { { 1, 2, 3}, {4, 5, 6} },
                { { 7, 8, 9}, {10, 11, 12} }
            };
            //   arr3d2[0, 0, 0]; // returns 1 
            //    arr3d2[0, 0, 1]; // returns 2 
            //    arr3d2[0, 1, 0]; // returns 3 
            //     arr3d2[0, 1, 1]; // returns 4 
            //     arr3d2[1, 0, 0]; // returns 5 
            //     arr3d2[1, 0, 1]; // returns 6 
            //      arr3d2[1, 1, 0]; // returns 7 
            //      arr3d2[1, 1, 1]; // returns 8 

            Console.WriteLine(arr3d2[1, 1, 1]);

            // Declare a jagged array.
            int[][] jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array structure.
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };


            int[][] jagarray = new int[5][];

            jagarray[0] = new int[3] { 1, 2, 4 };
            jagarray[1] = new int[3] { 1, 2, 4 };

            jagarray[2] = new int[3] { 1, 2, 4 };

            jagarray[3] = new int[3] { 1, 2, 4 };
            jagarray[4] = new int[3] { 1, 2, 4 };


            //string builder






        }
        // pass by ref example
        static void IncrementExample(ref int abc)
        {
            //We need to initialize the variable in the method before we can do anything

            abc = abc + 1;
        }

        public static int AddUs(int num1,int num2=0)
        {
           
            return num1 + num2;
        }
        // parameters
        public int AddAgain(int num1,int num2)
        {
            return num1 + num2;
        }
        //must be single dimensionl array
        public int Add(params int[] val)
        {
            
            return 23 + 23;
        }
       
        // overloaded method
        static void MethodOverloading(string name)
        {

        }
        // overloaded method
        static void MethodOverloading(int age)
        {

        }
        // overloaded method
        static void MethodOverloading(string name, int age)
        {

        }
        // overloaded method
        static void MethodOverloading(int age ,string name)
        {

        }

    }
   
           
        
    }

