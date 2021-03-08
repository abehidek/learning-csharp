using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_course.poo_concepts
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;

        public static int songCount = 0; // STATIC CLASS ATRIBUTTE -> is a atribute about the class, not of the object

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }
    }
}
