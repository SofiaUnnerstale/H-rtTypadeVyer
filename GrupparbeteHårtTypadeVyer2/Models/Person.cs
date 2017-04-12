using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupparbeteHårtTypadeVyer2.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public static List<Person> persons = new List<Person>
        {
            new Person{Name="Sofia", Age=35},
            new Person{Name="Henrik", Age=27},
        };

        public static List<Person> GetPersons()
        {
            return persons;
        }
    }
}
