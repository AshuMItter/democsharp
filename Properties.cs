using System;
using System.Collections.Generic;
using System.Text;

namespace DemoOne.Concepts
{
    class Properties
    {
    }
    class Student
    {
        string _name;
        int _age;
        string _location;
        public Student()
        {

        }
        public Student(string name, int age, string location)
        {
            _name = name;
            _age = age;
            _location = location;
        }


        public int Age
        {
            get
            {

                return _age;

            }


        }

        // acess specifier data-type Functioname(paramertse, param2,param3)
        // {  
        //
        //
        // }  

        public string CreateMyFullName(string fname, string mname, string lname)
        {

            return fname + " " + mname + " " + lname;
        }
        public string CreateMyFullName(string fname)
        {


            return fname;
        }
        public string CreateMyFullName(string fname, string lname)
        {

            return fname + " " + lname;
        }

        public static int PassByRef(ref int age)
        {
            age = age + 10;
            return age;
        }








        public string CreateMyFullNameTwo(string fname = "hello", string lname = "world")
        {

            return fname + " " + lname;
        }

        public int CreateMyNameTwo(params int[] val)
        {
            return val[0];
        }












    }
}
