using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DataBaseApi
{
    public class Person
    {
        [BsonId]
        public int Id { get; set; }
        public string Fn { get; set; }
        public string Ln { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }

        public Person(int id, string fn, string ln, int age)
        {
            this.Id = id;
            this.Fn = fn;
            this.Ln = ln;
            this.Age = age;
        }

        public static int CompareById(Person x, Person y)
        {
            if (x.Id > y.Id)
                return 1;
            else if (x.Id < y.Id)
                return -1;
            else
                return 0;
        }
    }
}

