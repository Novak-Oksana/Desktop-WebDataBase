using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DataBaseApi
{
    internal class MongoDbPerson : DbPerson
    {
        IMongoCollection<Person> collection = null;

        public MongoDbPerson()
        {
            string connection = @"mongodb://localhost:27017";// адрес сервера
            MongoClient client = new MongoClient(connection);
            IMongoDatabase database = client.GetDatabase("mongoPerson");
            collection = database.GetCollection<Person>("people");
        }

        public override void Create(Person person)
        {
            if (collection.Find(x => x.Id == person.Id).ToList().Count == 0)
            {
                collection.InsertOne(person);
            }
        }

        public override void Delete(int id)
        {
            collection.DeleteOne(x => x.Id == id);
        }

        public override List<Person> Read()
        {
            List<Person> listPerson = new List<Person>();
            listPerson = collection.Find(x => true).ToList();
            listPerson.Sort(Person.CompareById);
            return listPerson;
        }

        public override void Update(Person person)
        {
            collection.ReplaceOne(x => x.Id == person.Id, person);
        }
    }
}