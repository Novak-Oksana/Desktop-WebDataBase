using System.Collections.Generic;
using System.IO;
using YamlDotNet.Serialization;

namespace DataBaseApi
{
    public class YamlPersonLb : FilePerson
    {
        static string path = @"E:\work\DataBase\DataBase\yaml_db.yaml";
        public YamlPersonLb() : base(path)
        {

        }

        protected override List<Person> load(string path)
        {
            List<Person> persons;
            string yamlString = File.ReadAllText(path);
            Deserializer deserializer = new Deserializer();
            if (yamlString.Length == 0)
                persons = new List<Person>();
            else
                persons = deserializer.Deserialize<List<Person>>(yamlString);
            return persons;
        }

        protected override void save(List<Person> persons, string path)
        {
            Serializer serializer = new Serializer();
            string yamlString = serializer.Serialize(persons);
            File.WriteAllText(path, yamlString);
        }
    }
}