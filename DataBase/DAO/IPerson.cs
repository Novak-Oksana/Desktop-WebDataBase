using System.Collections.Generic;

namespace DataBaseApi
{
    public interface IPerson
    {
        List<Person> Read();
        void Update(Person person);
       // void Delete(Person person);
        void Delete(int id);
        void Create(Person person);
    }
}