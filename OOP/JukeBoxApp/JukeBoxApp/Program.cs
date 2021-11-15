using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JukeBoxApp
{
    class Program
    {
        static void Main(string[] args)
        {
            JukeBox jk = new JukeBox();
            jk.ReadSongsFromFile("Songs.txt");
            jk.Songs.Sort();
            DisplayItems(jk.Songs);
            Console.ReadLine();
        }

        private static void DisplayItems(ArrayList songs)
        {
            throw new NotImplementedException();
        }

        public static void DisplayItems(ArrayList arrList)
        {
            foreach (string item in arrList) Console.WriteLine(item);
        }
    }
}

