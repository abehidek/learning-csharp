using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_course.poo_concepts
{
    class PooConcepts
    {
        public static void AllPooConcepts()
        {
            // INHERITANCE
            //Chef chef = new Chef();
            //chef.MakeChicken();
            //chef.MakeSpecialDish();
            //ItalianChef italianchef = new ItalianChef();
            //italianchef.MakeChicken();
            //italianchef.MakePasta();
            /*italianchef.MakeSpecialDish();*/ // THIS IS AN OVERWRITTED METHOD

            // ----------
            // STATIC METHODS
            //Console.WriteLine(Math.Sqrt(144)); // EXAMPLE OF STATIC METHOD, YOU DON'T NEED TO CREATE AN OBJECT IN ORDER TO ACCESS IT.
            //UsefulTools.SayHi("Abe");

            // ----------
            // STATIC CLASS ATRIBUTTES
            //Song holiday = new Song("Holiday", "Green Day", 200);
            //Console.WriteLine(Song.songCount);
            //Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            //Console.WriteLine(Song.songCount);

            // ----------
            //GET AND SET
            //Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            //Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            //shrek.Rating = "Dog";
            //Console.WriteLine(shrek.Rating);
            // BESIDES SETTING SHREK.RATING "DOG", SINCE IT'S BEING CATCHED BY THE SETTER OF THE CLASS,
            // INSTEAD OF BEING SETTED FOR "DOG", IT WILL SET "NR" BECAUSE OF THE IF IMPLEMENTED IN THE CLASS.

            // ----------
            //OBJECT METHODS
            //Student student1 = new Student("Adam", "Physics", 3.2);
            //Student student2 = new Student("Beatrice", "Literature", 3.9);

            //Console.WriteLine(student1.HasHonnors());
            //Console.WriteLine(student2.HasHonnors());

            Console.ReadLine();
        }
    }
}
