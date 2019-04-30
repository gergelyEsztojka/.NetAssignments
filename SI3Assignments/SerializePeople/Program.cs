using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializePeople
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Gery", new DateTime(1989, 03, 18), Genders.Male);

            person.Serialize("gery.dat");

            Console.WriteLine("-serialized");
            Console.ReadKey();
        }
    }
}
