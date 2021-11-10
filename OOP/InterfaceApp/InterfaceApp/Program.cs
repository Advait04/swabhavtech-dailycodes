using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Man m = new Man();
            Boy b = new Boy();
            
            AtThePartyHall(m);
            AtThePartyHall(b);
            AtTheCinemaHall(b);
            AtTheCinemaHall(m);
            

        }
        public static void AtThePartyHall(IManner obj)
        {
            Console.WriteLine("At the Party");
            obj.Wish();
            obj.Depart();

        }
        public static void AtTheCinemaHall(IEmotion obj)
        {
            Console.WriteLine("At The Cinema Hall");
            obj.Cry();
            obj.Laugh();
        }
    }
}
