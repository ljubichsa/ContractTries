using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractTries
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listOfPersons = new List<Person>();
           // listOfPersons.Add(new Person("", 21));
            listOfPersons.Add(new Person("John", 1));
            listOfPersons.Add(new Person("Pablo", 22));

            foreach (Person pers in listOfPersons)
            {
                Console.WriteLine("Name: {0}; Age: {1}",pers.PersonName, pers.PersonAge);
            }
            Console.ReadLine();
        }
    }

// [ContractClass(typeof(Person))]
    class Person
    {
        public string PersonName { get; set; } 
        public int PersonAge { get; set; }

        public Person(string personName, int personAge)
        {
            Contract.Requires(!string.IsNullOrWhiteSpace(personName));
            Contract.Requires(personAge > 18);

            PersonName = personName;
            PersonAge = personAge;
        }
    }
}
