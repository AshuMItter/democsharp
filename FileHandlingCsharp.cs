using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DemoOne.Demos
{
    class FileHandlingCsharp
    {
        public void DemoFileHAndling()
        {
            // MemoryStream ms = new MemoryStream();

            //FileStream fs = new FileStream(@"C:\Users\ANKIT\Desktop\PhD\DemoFile.txt", FileMode.Append, FileAccess.Write);


            //BinaryWriter binWriter = new BinaryWriter(fs);

            //binWriter.Write("Hello World Again written from BinaryWriter");
            //binWriter.Flush();
            //binWriter.Close();


            //StreamWriter bs = new StreamWriter(fs);


            //bs.WriteLine("Hello World");
            //bs.WriteLine("Hello World");
            //bs.WriteLine("Hello World");
            //bs.WriteLine("Hello World");
            //bs.Flush();
            //bs.Close();

            //fs.Close();
            //fs.Dispose();

            //FileInfo info = new FileInfo(@"C:\Users\ANKIT\Desktop\PhD\PhdDetails.jpg");
            //Console.WriteLine(info.FullName);
            //Console.WriteLine(info.Name);
            //Console.WriteLine(info.Extension);
            //Console.WriteLine(info.CreationTime);

            //Console.WriteLine(info.DirectoryName);








            // directory info class
            //DirectoryInfo dirInfo = new DirectoryInfo(@"C:\DemoDirectory");

            //if (dirInfo.Exists == false)
            //{
            //    dirInfo.Create();
            //}


            //Console.WriteLine(dirInfo.FullName);
            //Console.WriteLine(dirInfo.Name);
            //Console.WriteLine(dirInfo.Parent);
            //// Console.WriteLine(dirInfo.);

            ////dirInfo.CreateSubdirectory("DirSub");
            ////dirInfo.CreateSubdirectory(@"DirSub\SubD");
            ////dirInfo.CreateSubdirectory(@"DirSub\SubD\ChildSubD");

            //// true for deleting if directory is not empty.
            //dirInfo.Delete(true);


            //StringReader reader = new StringReader("I am a string");

            //StringWriter writer = new StringWriter();
            //writer.WriteLine("String Writer");

           
            //StringWriter sw = new StringWriter();
            //sw.WriteLine("string writer");
            //Console.WriteLine(sw.ToString());


        }
        string path = @"C:\Users\ANKIT\Desktop\PhD\MyFileIO.txt";
        public void Write(string content)
        {
            
            File.AppendAllText(path,content+". ");
            
        }
        public void Read()
        {
            string result = File.ReadAllText(path);
           Console.WriteLine(result);
        }
        public void Update(string value, string with)
        {
            string result = File.ReadAllText(path);


           string newStr = result.Replace(value, with);
            File.WriteAllText(path,newStr);
        }
        public void Delete(string delete)
        {
           string result = File.ReadAllText(path);
           string newStr= result.Replace(delete, "");
           File.WriteAllText(path, newStr);
        }
        public void DeleFile()
        {
            File.Delete(path);
        }
    }
}
