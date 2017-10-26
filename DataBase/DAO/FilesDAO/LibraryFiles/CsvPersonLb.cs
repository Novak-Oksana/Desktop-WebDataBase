using System.Collections.Generic;
using ServiceStack.Text;
using System.IO;

namespace DataBaseApi
{
    public class CsvPersonLb : FilePerson
    {
        static string path = @"E:\work\DataBase\DataBase\csv_db.csv";
        public CsvPersonLb() : base(path)
        {

        }
        protected override List<Person> load(string path)
        {
            string csvString = File.ReadAllText(path);
            List<Person> persons;
            if (csvString.Length == 0)
                persons = new List<Person>();
            else
                persons = CsvSerializer.DeserializeFromString<List<Person>>(csvString);
            return persons;
        }

        protected override void save(List<Person> persons, string path)
        {
            string csvString = CsvSerializer.SerializeToCsv(persons);
            File.WriteAllText(path, csvString);
        }
    }
}