using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DataBaseApi
{
    internal class JsonPerson : FilePerson
    {
        static string path = @"E:\work\DataBase\DataBase\jsn_db.json";
        public JsonPerson() : base(path)
        {

        }
        protected override List<Person> load(string path)
        {
            List<Person> persons = new List<Person>();
            string[] lines = File.ReadAllLines(path);
            Person person = null;
            foreach (string str in lines)
            {
                string str1 = str;
                string[] mas = str1.Split(',', '{', '}', '[', ']');
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] != "")
                    {
                        string[] mas1 = mas[i].Split(':');
                        if (mas1[0].Contains("Id"))
                        {
                            person = new Person();
                            persons.Add(person);
                        }
                        string value = mas1[1];
                        if (mas1[0].Contains("Id"))
                        {
                            person.Id = Int32.Parse(value);
                        }
                        if (mas1[0].Contains("Fn"))
                        {
                            person.Fn = value.Replace('"', ' ').Trim();
                        }
                        if (mas1[0].Contains("Ln"))
                        {
                            person.Ln = value.Replace('"', ' ').Trim();
                        }
                        if (mas1[0].Contains("Age"))
                        {
                            person.Age = Int32.Parse(value);
                        }
                    }
                }
            }
            return persons;
        }

        protected override void save(List<Person> persons, string path)
        {
            StringBuilder jsn = new StringBuilder();
            jsn.Append('[');
            int i = 0;
            foreach (Person p in persons)
            {
                i++;
                jsn.Append("{"+ '"'+"Id"+'"'+":" + p.Id + "," + '"'+ "Fn"+ '"' + ":" + '"'+ p.Fn + '"'
                    + "," + '"' + "Ln" + '"' + ":" + '"' + p.Ln + '"' + "," + '"' + "Age" + '"' + ":" + p.Age + "}");
                if (i == persons.Count)
                    jsn.Append("");
                else
                    jsn.Append(",");
            }
            jsn.Append(']');
            File.WriteAllText(path, jsn.ToString());

        }
    }
}