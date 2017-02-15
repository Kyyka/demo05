using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht02
{
    class CD
    {
        public string Artist { get; set; }
        public string CdName { get; set; }
        public double Price { get; set; }
        public List<Track> Tracks = new List<Track>();

        public void AddTrack(string name, string length)
        {
            Tracks.Add(new Track { Name = name, Length = length });
        }

        public override string ToString()
        {
            string Songs = "";
            foreach(Track item in Tracks)
            {
                Songs = Songs + item.ToString() + "\n";
            }
            return "CD data: \n- CD name: " + CdName + "\n- Artist: " + Artist + "\n- Price: " + Price + "\n- Songs: \n" + Songs;
        }
    }
}
