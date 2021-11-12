using LspSolutionApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LspSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle:");
            ShouldNotChangeWidthIfHeightIsModified(new Rectangle(20,30));
            Console.ReadKey();
        }
        public static void ShouldNotChangeWidthIfHeightIsModified(Rectangle rectangle)
        {
            var before = rectangle.Width;
            rectangle.Height += 10;
            var after = rectangle.Width;
            Console.WriteLine(before == after);
            Console.WriteLine(before);
            Console.WriteLine(after);
        }
    }
    
}
