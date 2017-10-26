using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DataBaseApi
{
    internal class BinaryLPerson : FilePerson
    {
        static string path = @"E:\work\DataBase\DataBase\BinaryL_db.txt";
        public BinaryLPerson() : base(path)
        {

        }

        protected override List<Person> load(string path)
        {
            List<Person> persons = new List<Person>();
            if (File.Exists(path) == false)
            {
                return persons;
            }
            else
            {
                string[] ls = File.ReadAllLines(path);
                if (ls.Length == 0)
                    return persons;
            }
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                persons = (List<Person>)bf.Deserialize(fs);
            }
            return persons;
        }

        protected override void save(List<Person> persons, string path)
        {
            BinaryFormatter bf = new BinaryFormatter();//&&
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                bf.Serialize(fs, persons);
            }
        }
    }
}