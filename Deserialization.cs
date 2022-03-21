using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace LInqToObjects
{
    class Deserialization
    {
        public static object DeSerialization()
        {
            FileStream fs = new FileStream(@"C:\Users\ANKIT\Desktop\PhD\daTa.bin", FileMode.Open, FileAccess.Read);

            BinaryFormatter bf = new BinaryFormatter();
            return bf.Deserialize(fs);

            fs.Close();
            fs.Flush();
            fs.Dispose();
        }
    }
}
