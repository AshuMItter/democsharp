using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Concepts
{
    class DependecyInjection
    {
        public void DependecyInjectedHereas(IDependency iobj) {
            iobj.SomeMethod();
        }
    }

    interface IDependency
    {
        void SomeMethod();
    }

    class DependenyCreatingClassA : IDependency
    {
        public void SomeMethod()
        {
            Console.WriteLine("Method from Class A Called");
           // throw new NotImplementedException();
        }
    }
    class DependecyCreatingClassB : IDependency
    {
        public void SomeMethod()
        {
            Console.WriteLine("Method from Class B Called");
          //  throw new NotImplementedException();
        }
    }
}
