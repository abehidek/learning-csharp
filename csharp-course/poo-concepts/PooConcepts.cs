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
            // GET AND SET

            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            shrek.Rating = "Dog";
            Console.WriteLine(shrek.Rating);

            //OBJECT METHODS
            //Student student1 = new Student("Adam", "Physics", 3.2);
            //Student student2 = new Student("Beatrice", "Literature", 3.9);

            //Console.WriteLine(student1.HasHonnors());
            //Console.WriteLine(student2.HasHonnors());

            Console.ReadLine();
        }
    }
}
