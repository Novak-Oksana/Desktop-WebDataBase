using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace DataBaseApi
{
    public class JsonPersonLb : FilePerson
    {
        static string path = @"E:\work\DataBase\DataBase\jsn_db.json";
        //static string path = "jsn_db.json";
        public JsonPersonLb() : base(path)
        {
        }

        protected override List<Person> load(String path)
        {
            string jsonString = File.ReadAllText(path);
            List<Person> persons = JsonConvert.DeserializeObject<List<Person>>(jsonString);
            if (persons == null)
                persons = new List<Person>();
            return persons;
        }
        protected override void save(List<Person> persons, String path)
        {
            string jsonString = JsonConvert.SerializeObject(persons);
            File.WriteAllText(path, jsonString);
        }
    }
}
