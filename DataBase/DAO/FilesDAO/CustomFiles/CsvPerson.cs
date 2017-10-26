using System.Collections.Generic;
using System.IO;
using System;
using Microsoft.VisualBasic.FileIO;
using System.Collections;
using System.Linq;
using System.Text;

namespace DataBaseApi
{
    internal class CsvPerson : FilePerson
    {
        static string path = @"E:\work\DataBase\DataBase\csv_db.csv";
        public CsvPerson() : base(path)
        {

        }

        protected override List<Person> load(string path)
        {
            List<Person> persons = new List<Person>();
            using (TextFieldParser parser = new TextFieldParser(path))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                int i = 0;
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if (i != 0)
                    {
                        Person person = new Person();
                        person.Id = Int32.Parse(fields[0]);
                        person.Fn = fields[1];
                        person.Ln = fields[2];
                        person.Age = Int32.Parse(fields[3]);
                        persons.Add(person);
                    }
                    i++;
                }
            }
            return persons;
        }

        protected override void save(List<Person> persons, string path)
        {
            StringBuilder csv = new StringBuilder();
            csv.AppendLine("Id,Fn,Ln,Age");

            foreach (Person p in persons)
            {
                csv.Append(p.Id + "," + p.Fn + "," + p.Ln + "," + p.Age);
                csv.AppendLine();
            }
            File.WriteAllText(path, csv.ToString());
        }

    }
}