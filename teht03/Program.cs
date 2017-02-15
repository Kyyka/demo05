using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Program
    {
        //Listataan pelikehittäjiä ja heidän pelejään.
        static void Main(string[] args)
        {
            List dev = new teht03.List();
            dev.Developer = "Bethesda Softworks";
            dev.AddGame("The Elder Scrolls", 1994);
            dev.AddGame("Terminator", 1995);
            Console.WriteLine(dev.ToString());

            List dev2 = new teht03.List();
            dev2.Developer = "id Software";
            dev2.AddGame("Quake", 1996);
            dev2.AddGame("Quake II", 1997);
            dev2.AddGame("Quake III Arena", 1999);
            Console.Write(dev2.ToString());
        }
    }
}
