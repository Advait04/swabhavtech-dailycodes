using System;


namespace CommandLineArgusName
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter name:");
            String[] names = Console.ReadLine().Split(' ');
            Console.WriteLine("First name is:" + names[0]);
            Console.WriteLine("Middle Name is:" + names[1]);
            Console.WriteLine("Last Name is:" + names[2]);
        }
    }
}
