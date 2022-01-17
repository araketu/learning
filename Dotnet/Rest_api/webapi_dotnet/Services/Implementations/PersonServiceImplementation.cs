using System;
using System.Collections.Generic;
using System.Threading;
using webapi_dotnet.Model;

namespace webapi_dotnet.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long Id)
        {
            
        }

        public List<Person> Findall()
        {
            List<Person> persons = new List<Person>();
            for (int i =0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }



        public Person FindById(long Id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Diogo",
                LastName = "Ghizoni",
                Address = "Brasília",
                Gender = "Male"
            };
        }


        public Person Update(Person person)
        {
            return person;
        }


        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }


        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Fulano" + i,
                LastName = "Siclano" + i,
                Address = "BSB" + i,
                Gender = "Male"
            };
        }

    }
}
