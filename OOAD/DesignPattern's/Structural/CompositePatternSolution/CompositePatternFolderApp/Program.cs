using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternFolderApp
{
     class Program
    {
        static void Main(string[] args)
        {
            var movies = new Folder("Movies");
            movies.AddItem(new File("Titanic", "600MB"));
            var comedy = new Folder("Comedy Movies");
            comedy.AddItem(new File("3 Idiots", "900MB"));
            var horrorComedy = new Folder("HorrorComedy");
            horrorComedy.AddItem(new File("Horror Movie", "300MB"));
            comedy.AddItem(horrorComedy);
            movies.AddItem(comedy);
            movies.Display();

        }
    }
}
