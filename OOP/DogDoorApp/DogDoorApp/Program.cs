using DogDoorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DogDoor door = new DogDoor();
            Remote remote = new Remote(door);

            Console.WriteLine("\n Fido barks to go out..");
            remote.PressButton();

            Console.WriteLine("\n Fido is out..");
            remote.PressButton();

            Console.WriteLine("\n Fido's is returning home..");
            remote.PressButton();

            Console.WriteLine("\n Fido's  back inside...");
            remote.PressButton();

            Console.ReadLine();
        }
    }
}
