using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class Program
    {
        static void Main(string[] args)
        {
            CD disc = new teht02.CD();
            disc.CdName = "Endless Forms Most Beautiful";
            disc.Artist = "Nightwish";
            disc.Price = 29.90;
            disc.AddTrack("Shudder Before the Beautiful", "6:29");
            disc.AddTrack("Weak Fantasy", "5:23");
            disc.AddTrack("Elan", "4:45");
            disc.AddTrack("Yours Is an Empty Hope", "5:34");
            disc.AddTrack("Our Decades in the Sun", "6:37");
            disc.AddTrack("My Walden", "4:38");
            disc.AddTrack("Endless Forms Most Beautiful", "5:07");
            disc.AddTrack("Edema Ruh", "5:15");
            disc.AddTrack("Alpenglow", "4:45");
            disc.AddTrack("The Eyes of Sharbat Gula", "6:03");
            disc.AddTrack("The Greatest Show on Earth", "24:00");
            Console.WriteLine(disc.ToString());
        }
    }
}
