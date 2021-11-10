using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Advait");
            list.Add("Vallabh");
            list.Add("Yogeshwar");
            list.Add("Arati");
            string path = "D:/Serialization1.txt";

            Stream stream = File.Open(path, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, list);
            stream.Close();
            Console.WriteLine("File Created And Saved:" + path);
            Console.ReadLine();

        }
    }
}
