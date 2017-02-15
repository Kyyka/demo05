using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Game
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + " | Price: " + Year;
        }
    }
}
