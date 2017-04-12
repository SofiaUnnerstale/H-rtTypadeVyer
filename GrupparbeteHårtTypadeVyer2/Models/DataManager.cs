using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupparbeteHårtTypadeVyer2.Models
{
    public class DataManager
    {
        public static List<Person> persons = new List<Person>
        {
            new Person{Name="Sofia", Age=35},
            new Person{Name="Henrik", Age=27},
        };

        public static void AddPerson(Person person)
        {
            persons.Add(person);
        }

        public static List<Person> GetPersons()
        {
            return persons;
        }
    }
}
