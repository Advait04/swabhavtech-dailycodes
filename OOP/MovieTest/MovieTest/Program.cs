using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieTest
{
    class Movie
    {
        String title;
        string genre;
        int rating;

        void PlayIt()
        {
            Console.WriteLine("Playing the Movie");
        }
    }
    public class MovieTestDrive
    { 
        static void Main(string[] args)
        {
            Movie one = new Movie();
            one.title = "GOne with the stock";
            one.genre = "Tragic";
            one.rating = -2;
            Movie two = new Movie();
            two.title = "Lost in cubical space";
            two.genre = "Comedy";
            two.rating = 5;
            two.PlayIt();
            Movie three = new Movie();
            three.title = "Byte Club";
            three.genre = " Tragic but ultimately uplifting ";
            three.rating = 127;
        }
        
    }
}
