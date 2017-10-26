using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataBaseApi
{
    internal class YamlPerson : FilePerson
    {
        static string path = @"E:\work\DataBase\DataBase\yaml_db.yaml";
        public YamlPerson() : base(path)
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
                str1 = str.Trim();
                if (str.Contains("-"))
                {
                    person = new Person();
                    persons.Add(person);
                    str1 = str.Substring(2);
                }

                string[] mas = str1.Split(':');
                string value = mas[1].Trim();
                if (mas[0] == "Id")
                {
                    person.Id = Int32.Parse(value);
                }
                if (mas[0] == "Fn")
                {
                    person.Fn = value;
                }
                if (mas[0] == "Ln")
                {
                    person.Ln = value;
                }
                if (mas[0] == "Age")
                {
                    person.Age = Int32.Parse(value);
                }
            }
            return persons;
        }

        protected override void save(List<Person> persons, string path)
        {
            StringBuilder yaml = new StringBuilder();

            foreach (Person p in persons)
            {

                yaml.Append("- Id: " + p.Id);
                yaml.AppendLine();
                yaml.Append("  Fn: " + p.Fn);
                yaml.AppendLine();
                yaml.Append("  Ln: " + p.Ln);
                yaml.AppendLine();
                yaml.Append("  Age: " + p.Age);
                yaml.AppendLine();
            }
            File.WriteAllText(path, yaml.ToString());
        }
    }

}
