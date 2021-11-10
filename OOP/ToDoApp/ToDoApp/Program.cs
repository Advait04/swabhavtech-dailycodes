
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
 
namespace Todolist
{
    class Program
    {
         static void Main(string[] args)
        {
            List<string> todolist = new List<string>();
            Console.WriteLine("**** Welcome to TodoApp ****");
            Console.WriteLine("**** App Developed By Advait Kunte ****");
            bool loop  = true;
            while (loop)
            {
                Console.WriteLine();
                Console.WriteLine("1.Display List");
                Console.WriteLine("2.Add To List");
                Console.WriteLine("3.Remove From List");
                Console.WriteLine("4.Exit App");
                Console.WriteLine();
                Console.WriteLine("Choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    if (todolist.Count == 0)
                    {
                        Console.WriteLine("Empty List");
                    }
                    foreach (var t in todolist)
                    {
                         Console.WriteLine(t);
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter item to Add:");
                    string newItem = Console.ReadLine();
                    todolist.Add(newItem);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Enter item to Remove: ");
                    string newItem = Console.ReadLine();
                    todolist.Remove(newItem);
                }
                else
                {
                    Console.WriteLine("Thank you for using Application");
                    loop = false;
                }

            }

            Console.ReadLine();
        }
    }
}