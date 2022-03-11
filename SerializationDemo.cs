using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace DemoOne.Demos
{
    class SerializationDemo
    {
        public void PerformSerialization() {
            Student student = new Student() { Age = 45, Name = "Ashu" };

            FileStream fs = new FileStream(@"C:\Users\ANKIT\Desktop\PhD\Student.bin",FileMode.Create,FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, student);
            fs.Flush();
            fs.Close();
            fs.Dispose();
           
        }
        public void PerformDeseriaalization()
        {
            FileStream fs = new FileStream(@"C:\Users\ANKIT\Desktop\PhD\Student.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            Student student = (Student)  bf.Deserialize(fs);

            Console.WriteLine(student.Age+" "+student.Name);
            fs.Flush();
            fs.Close();
            fs.Dispose();
        }
        
    }
    [Serializable]
    class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
