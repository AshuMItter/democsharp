using System;
using System.Text;
using DemoOne.Concepts;
namespace DemoOne
{
    class Program
    {

        


        // auto implemented propertie
        // public int Age { get; set; }
        static void Main(string[] args)
        {

            DependecyInjection objDI = new DependecyInjection();

            DependenyCreatingClassA classA = new DependenyCreatingClassA();
            DependecyCreatingClassB classB = new DependecyCreatingClassB();

            objDI.DependecyInjectedHereas(classA);

            //pass by ref.
            int num = 1;
            Console.WriteLine(num);
            PassByRef objPassbyRef = new PassByRef();
            objPassbyRef.IncrementExample(ref num);
            Console.WriteLine(num);


        }
        

    }
   
           
        
    }

