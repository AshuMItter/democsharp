using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject1
{
    
   public interface IDependecy
    {
        string DependetMethod();
    }

    public class MockDependencyObjet : IDependecy
    {
        public string DependetMethod()
        {
            return "I am from Mock object";
            // dome logic
        }
    }

    public class DepedencyObject
    {
        public string DependetMethod()
        {
            return "I am from Dependecy object or Real Production Code";
        }
    }

    public class ProductionObject {

        IDependecy reference;
        public ProductionObject(IDependecy dependency)
        {
            reference = dependency;
        }

        public int TightlyCoupledFunction()
        {

           
            reference.DependetMethod();
            // further logic
            return 45;
        }
    }



    public interface IManager
        {
            Boolean CheckExtension(string FileName);
        }

    //Stub implementation to bypass actual E manager class.  
    public class StubEManager : IManager
    {
        public bool CheckExtension(string FileName)
        {
            return true;
            //IAm obj = new Dummy();
            //obj.abc();

            //IAm objR = new Real();
            //objR.abc();
        }
    }

    // actual production code
    public class EManager :IManager
        {
        //
            public bool CheckExtension(string FileName)
            {
            //Some complex business logic - db logic  
            throw new Exception("This object should be mocked...");

           // return false;
            }
        }

       

        public class FileChecker
        {
            IManager objmanager = null;
            //Default constructor  
            public FileChecker()
            {
                objmanager = new EManager();
              
        }
        //parameterized constructor  
        public FileChecker(IManager tmpManager)
            {
                objmanager = tmpManager;
            }

            public int CheckFile(String FileName)
            {
           
            // depenedeny 
          var value =    objmanager.CheckExtension(FileName);
            // //
            //...
            int val = 10 + 10 + 5;
            return val;
        }
        }
    }

