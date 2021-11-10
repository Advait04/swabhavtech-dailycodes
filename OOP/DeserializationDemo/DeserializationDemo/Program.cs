using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DeserializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            string path = "D:/Serialization1";
            Stream stream = File.Open(path, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            list = (List<string>)bf.Deserialize(stream);
            Console.WriteLine("Deserialize Object :");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
                  

        }
    }
}
