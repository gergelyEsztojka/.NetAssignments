using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person, ICloneable
    {
        public decimal Salary { get; set; }
        public string Profession { get; set; }

        public Room Room = new Room { RoomNum = 12 };

        public override string ToString()
        {
            return "Employee[ Name = " + Name + ", BirthDate = " + BirthDate + ", Gender = " + Gender 
                + ", Salary = " + Salary + ", Profession = " + Profession + ", RoomNum = " + Room.RoomNum + "]";
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.Room = new Room { RoomNum = Room.RoomNum };
            return newEmployee;
        }
    }
}
