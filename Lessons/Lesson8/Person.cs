using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Person:ICloneable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person ()
        {
            Name = "Igor";
            Surname = "Lebedev";
            Age = 30;
        }

        public static bool operator == (Person p1, Person p2)
        {
            return p1.Name == p2.Name & p1.Surname == p2.Surname & p1.Age == p2.Age;
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return p1.Name != p2.Name | p1.Surname != p2.Surname | p1.Age != p2.Age;
        }      

        public static string operator +(Person p1, Person p2)
        {
            
            return p1.Name + p2.Name;
        }

        public object Clone()
        {
            return new Person();
        }

        public override string ToString()
        {
            return String.Join(" ", new string[] { Name, Surname, Age.ToString() });
        }
    }
}
