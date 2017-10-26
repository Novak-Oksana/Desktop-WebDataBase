using System.Collections.Generic;
using System.Data.Common;

namespace DataBaseApi
{
    public abstract class DbPerson : IPerson
    {
        public void ExecComand(DbCommand command)
        {
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
        }
        public abstract List<Person> Read();
        public abstract void Update(Person person);
       // public abstract void Delete(Person person);
        public abstract void Delete(int id);
        public abstract void Create(Person person);
    }
}
