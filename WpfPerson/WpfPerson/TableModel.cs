using DataBaseApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPerson
{
    class TableModel
    {
        IPerson db = null;

        public void SetDataBase(string key)
        {
            db = DBFactory.getInstance(key);
        }

        public void Create(Person person)
        {
            db.Create(person);
        }

        public List<Person> Read()
        {
            return db.Read();
        }

        public void Update(Person person)
        {
            db.Update(person);
        }

        public void Delete(int id)
        {
            db.Delete(id);
        }
    }
}
