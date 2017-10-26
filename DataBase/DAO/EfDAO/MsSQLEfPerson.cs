using System.Collections.Generic;
using System.Linq;

namespace DataBaseApi
{
    internal class MsSQLEfPerson : DbPerson
    {
       
        public override void Create(Person person)
        {
            using (PersonContext db = new PersonContext())
            {
                db.Persons.Add(person);
                db.SaveChanges();
            }
        }

        public override void Delete(int id)
        {
            using (PersonContext db = new PersonContext())
            {
                Person pToDel = db.Persons.First(x => x.Id == id);
                db.Persons.Remove(pToDel);
                db.SaveChanges();
            }
        }

        public override List<Person> Read()
        {
            using (PersonContext db = new PersonContext())
            {
                return db.Persons.ToList();
            }
        }

        public override void Update(Person person)
        {
            using (PersonContext db = new PersonContext())
            {
                Person original = db.Persons.FirstOrDefault(x => x.Id == person.Id);
                db.Entry(original).CurrentValues.SetValues(person);
                db.SaveChanges();
            }
        }
    }
}