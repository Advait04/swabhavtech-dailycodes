using System;


namespace CmdArgsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = { 1, 2, 3, 4, 5 }; 
            foreach(string i in args)
            {
                Console.WriteLine(i);
            }      
        
           
                Console.WriteLine("No arguments passes.plzz pass arguments");
            }
    }
}
