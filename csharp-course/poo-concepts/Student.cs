using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_course.poo_concepts
{
    class Student
    {
        // CLASS ATTRIBUTTES
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa) // CONSTRUCTORS 
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }
        public bool HasHonnors() // OBJECT METHOD
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }

    }
}
