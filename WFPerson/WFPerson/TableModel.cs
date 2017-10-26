using DataBaseApi;
using System.Collections.Generic;
using System.Data;

namespace WFPerson
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

        public DataTable Read()
        {
            DataTable dt = new DataTable();
            List<Person> persons = db.Read();

            dt.Columns.Add(new DataColumn("id"));
            dt.Columns.Add(new DataColumn("fn"));
            dt.Columns.Add(new DataColumn("ln"));
            dt.Columns.Add(new DataColumn("age"));

            foreach (Person person in persons)
            {
                DataRow row = dt.NewRow();
                row[0] = person.Id;
                row[1] = person.Fn;
                row[2] = person.Ln;
                row[3] = person.Age;
                dt.Rows.Add(row);
            }

            return dt;
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
