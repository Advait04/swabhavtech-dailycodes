using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using SerilizationExp1Test.Model;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerilizationExp1Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Serialised.txt";
            FileStream stream  = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Person person = new Person("Advait", "Kunte");
            formatter.Serialize(stream, person);
            stream.Close();
            Console.WriteLine("File created And Saved:" + path);
            Console.ReadLine();

            
           
        }
    }
}
