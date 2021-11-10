using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileReadWriteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                {
                    try
                    {
                       
                        StreamWriter sw = new StreamWriter("D:\\Demo.txt");
                       
                        sw.WriteLine("File Created");
                       
                        sw.WriteLine("Succesfully");
                       
                        sw.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Executing finally block.");
                    }
                }
            }
        }
    }
}
