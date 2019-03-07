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
        public DateTime BirthDate { get; set; }
        public Genders Gender { get; set; }

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
