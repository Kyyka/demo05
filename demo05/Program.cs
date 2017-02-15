using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo05
{
    class Program
    {
        static void Main(string[] args)
        {
            //create Persons(collection)
            Persons myFriends = new Persons();

            //create a few Person objects
            Person person1 = new Person
            {
                Firstname = "Sika",
                Lastname = "Rykä",
                SocialSecurityNumber = "010101-123A"
            };
            Person person2 = new Person
            {
                Firstname = "Teppo",
                Lastname = "Matikainen",
                SocialSecurityNumber = "030303-222B"
            };

            //add person objects to persons (myfriends)
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);

            //get one more person
            Person person3 = myFriends.GetPerson(0);
            if (person3 != null)
            {
                Console.WriteLine(person3.ToString());
            } else
            {
                Console.WriteLine("Can't find that person.");
            }
            //prtin collection
            myFriends.PrintData();

            //search person
            string sotu = "030303-222B";
            Console.WriteLine("Etsi henkilö, jolla sotu: " + sotu);
            Person person4 = myFriends.FindPerson(sotu);
            if (person4 != null)
            {
                Console.WriteLine("Haulla löytyi seuraava henkilö:");
                Console.WriteLine(person4.ToString());
            }else
            {
                Console.WriteLine("Kyseistä henkilöä ei löydy valitulla sotulla");
            }
        }
    }
}
