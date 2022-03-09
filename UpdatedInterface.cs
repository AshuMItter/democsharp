using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Concepts
{
    class UpdatedInterface : IUpdatedInterface
    {
        public void DemoFunction()
        {
           
        }
    }
    interface IUpdatedInterface
    {
       public const int x = 89;
        void DemoFunction();
    }
}
