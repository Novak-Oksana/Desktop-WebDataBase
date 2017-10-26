using System.Collections.Generic;
using System.Linq;

namespace DataBaseApi
{
    class PersonDAO_Mock : IPerson
    {
        SortedSet<Person> people = null;

        public PersonDAO_Mock()
        {
            people = new SortedSet<Person>();
            people.Add(new Person(1, "Hermione", "Granger", 21));
            people.Add(new Person(2, "Ron", "Weasley", 22));
            people.Add(new Person(10, "Lord", "Voldemort", 112));
            people.Add(new Person(145, "Severus", "Snape", 45));
            people.Add(new Person(1318, "Harry", "Potter", 20));

        }

        public void Create(Person p)
        {
            people.Add(p);
        }

        public void Delete(int id)
        {
            Person p = new Person();
            if (p.Id == id)
            people.Remove(p);
        }

        public List<Person> Read()
        {
            return people.ToList();
        }

        public void Update(Person p)
        {
            //
        }
    }
}