using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate;
        public Genders Gender;

        public override string ToString()
        {
            return "Person[ Name = " + Name + ", BirthDate = " + BirthDate + ", Gender = " + Gender + "]"; 
        }
    }

    enum Genders
    {
        Male,
        Female
    }
}
