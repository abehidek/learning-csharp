using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_course.poo_concepts
{
    static class UsefulTools // IF A CLASS IS STATIC THEN IT CANNOT BE ABLE TO CREATE A NEW OBJECT OF THAT CLASS
    {
        public static void SayHi (string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
