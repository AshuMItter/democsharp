using System;
using System.Collections.Generic;
using System.Text;
using DemoOne.Concepts;
namespace DemoOne.Demos
{
    class ExceptionHandling
    {
        //intentional
        public void ExceptionHandlingBasics()
        {
           
            try
            {
                throw new DllNotFoundException();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine(e.Source);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finlalize");
            }
           

           
           
        }

        //stack overflow 
        public void Generate()
        {
            Generate();
        }
    }
}
