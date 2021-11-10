using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDoAppF
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            Console.ReadLine();
        }
        public static void CaseStudy1()
        {
            ToDo  t1 = new ToDo();
            while (true)
            {
                Console.WriteLine("Enter Y For Menu And N For Exit");
                int yesNo = Convert.ToChar(Console.ReadLine());
                while (true)
                {
                    if (yesNo == 'y')
                    {
                        Console.WriteLine("-----------------Menu-----------------");
                        Console.WriteLine("1:display");
                        Console.WriteLine("2:add");
                        Console.WriteLine("3:exit");
                        Console.WriteLine("make a choice: ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:

                                t1.Display();
                                Console.WriteLine(" ");
                                break;
                            case 2:
                                Console.WriteLine("enter the task: ");
                                string task = Convert.ToString(Console.ReadLine());
                                t1.addInList(task);
                                break;
                            case 3:

                                t1.exit();
                                break;
                        }
                    }
                    else if (yesNo == 'n')
                    {
                        t1.exit();
                    }
                }

            }
        }
    }
}
