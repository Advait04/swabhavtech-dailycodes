using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ToDoAppF
{
    class ToDo
    {
        private readonly string FilePath = "D:/SwabhavTech/OOP/ToDo.txt";
        public string[] _toDoArrey = new string[10];





        public void Display()
        {
            FileStream fs = new FileStream("D:/SwabhavTech/OOP/ToDo.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            Console.ReadLine();
            fs.Close();
            sr.Close();
        }

        public void addInList(string task)
        {
            using (StreamWriter writer = new StreamWriter(FilePath, true))
            {
                writer.WriteLine(task.ToString());
                Console.WriteLine("task added");
                Console.WriteLine(" ");
                writer.Close();
            }

        }

        public void exit()
        {
            FileStream fs1 = new FileStream(FilePath, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs1);
            Console.WriteLine("saving!");
            Environment.Exit(1);
        }
    }
}
