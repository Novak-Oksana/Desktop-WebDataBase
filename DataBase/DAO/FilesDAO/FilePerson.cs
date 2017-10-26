using System;
using System.Collections.Generic;

namespace DataBaseApi
{
    public abstract class FilePerson : IPerson
    {

        protected abstract void save(List<Person> persons, String path);
        protected abstract List<Person> load(string path);

        private string path;
        public FilePerson(string path)
        {
            this.path = path;
        }
        public  void Create(Person person)
        {
            List<Person> persons = load(path);
            persons.Add(person);
            save(persons, path);

        }

        public void Delete(int id)
        {
            List<Person> persons = load(path);
            Person toDelege = null;
            foreach (Person person in persons)
            {
                if (person.Id == id)
                {
                    toDelege = person;
                    break;
                }
            }
            if (toDelege != null)
            {
                persons.Remove(toDelege);
            }
            save(persons, path);

        }

        public List<Person> Read()
        {
            List<Person> persons = load(path);
            return persons;
        }

        public void Update(Person updatePerson)
        {
            List<Person> persons = load(path);
            Person toUpdate = null;
            foreach (Person person in persons)
            {
                if (person.Id == updatePerson.Id)
                {
                    toUpdate = person;
                    break;
                }
            }
            if (toUpdate != null)
            {
                toUpdate.Fn = updatePerson.Fn;
                toUpdate.Ln = updatePerson.Ln;
                toUpdate.Age = updatePerson.Age;
            }
            save(persons, path);

        }

    }
}
