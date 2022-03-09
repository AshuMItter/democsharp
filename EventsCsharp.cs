using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Demos
{
    class EventsCsharp
    {
        public delegate void DoSomething();

        //event delegate anyeventname
        event DoSomething MyEvent;
        public EventsCsharp()
        {

        }

        public void SetupEvent()
        {
            DoSomething obj = new DoSomething(EventHandler1);
            MyEvent = obj;
           MyEvent += new DoSomething(EventHandler2);
        }
        public void FireEvent()
        {
            MyEvent.Invoke();
        }
        public void EventHandler1()
        {
            Console.WriteLine("Event Fired Once");
        }
        public void EventHandler2()
        {
            Console.WriteLine("Events Fired Twice");
        }
    }
}
