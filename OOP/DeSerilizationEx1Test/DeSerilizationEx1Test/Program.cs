using DeSerilizationEx1Test.Model;
using SerilizationExp1Test.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace DeSerilizationEx1Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
        string path = @"D:\Serialised.txt";
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Person person = (Person)formatter.Deserialize(stream);
            Console.WriteLine("Name  : " + person.Name);
            Console.WriteLine("Rollno: " + person.LastName);

            stream.Close();

            
                 
        }
    }
}
