using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<String> printHowdy = (n) =>
             Console.WriteLine("Howdy Says " + n);
                printHowdy("Advait");

            Action<String, String> printFullName = (fn, ln) =>
             Console.WriteLine("irst Name is {0} Last Name{1}", fn, ln);

            Func<int, int, long> calRectArea = (w, h) => w * h;
            Console.WriteLine("Result Of Area Calculation :" + calRectArea(5, 6));

            Predicate<String> isLongName = (name) => name.Length>8;
            Console.WriteLine(isLongName("ababdbdbdbdbd"));

            String userName = "SwabhavTechLabs";
            Console.WriteLine("Is{0} A Long Name ? {1} ", userName, isLongName(userName));
        }
    }
}
