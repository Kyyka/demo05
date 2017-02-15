using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class List
    {
        public string Developer { get; set; }
        public List<Game> Games = new List<Game>();

        public void AddGame (string name, int year)
        {
            Games.Add(new Game { Name = name, Year = year });
        }

        public override string ToString()
        {
            string DevGames = "";
            foreach(Game item in Games)
            {
                DevGames = DevGames + item.ToString() + "\n";
            }
            return "------------------------\nDeveloper: " + Developer + "\n-----List of games:-----\n" + DevGames;
        }
    }
}
