using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person { Name = "Adam", BirthDate = DateTime.Now, Gender = Genders.Male };
            Person p2 = new Person { Name = "Eva", BirthDate = DateTime.Now, Gender = Genders.Female };

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Employee e1 = new Employee { Name = "Bob", BirthDate = DateTime.Now, Gender = Genders.Male, Profession = "Accountant", Salary = 1200.75m };

            Console.WriteLine(e1);

            Employee Kovacs = new Employee { Name = "Géza", BirthDate = DateTime.Now, Salary = 1000m, Profession = "léhűtő" };
            Kovacs.Room = new Room { RoomNum = 111 };
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.Room.RoomNum = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());

            Console.ReadLine();
        }
    }
}
