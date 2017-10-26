using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataBaseApi
{
    internal class XmlPerson : FilePerson
    {
        static string path = @"E:\work\DataBase\DataBase\xml_db.xml";
        public XmlPerson() : base(path)
        {

        }
        protected override List<Person> load(string path)
        {
            List<Person> persons = new List<Person>();
            string[] lines = File.ReadAllLines(path);
            Person person = null;
            for (int i = 3; i < lines.Length; i++)
            {
                string str = lines[i].Substring(4);
                string[] mas = str.Split('<', '>', '/');
                if (mas[1] == "Id")
                {
                    person = new Person();
                    persons.Add(person);
                    person.Id = Int32.Parse(mas[2]);
                }
                if (mas[1] == "Fn")
                {
                    person.Fn = mas[2];
                }
                if (mas[1] == "Ln")
                {
                    person.Ln = mas[2];
                }
                if (mas[1] == "Age")
                {
                    person.Age = Int32.Parse(mas[2]);
                }

            }
            return persons;
        }

        protected override void save(List<Person> persons, string path)
        {
            StringBuilder xml = new StringBuilder();
            xml.Append("<?xml version="+'"'+"1.0"+'"'+" encoding=" +'"'+ "utf-8" + '"'+"?>");
            xml.AppendLine();
            xml.Append("<ArrayOfPerson xmlns:xsi="+'"'+"http://www.w3.org/2001/XMLSchema-instance"+'"'
                +" xmlns:xsd="+'"'+"http://www.w3.org/2001/XMLSchema"+'"'+">");
            xml.AppendLine();
            foreach (Person p in persons)
            {
                xml.Append("  <Person>");
                xml.AppendLine();
                xml.Append("    <Id>"+ p.Id+ "</Id>");
                xml.AppendLine();
                xml.Append("    <Fn>" + p.Fn + "</Fn>");
                xml.AppendLine();
                xml.Append("    <Ln>" + p.Ln + "</Ln>");
                xml.AppendLine();
                xml.Append("    <Age>" + p.Age + "</Age>");
                xml.AppendLine();
                xml.Append("  </Person>");
                xml.AppendLine();
            }
            xml.Append("</ArrayOfPerson>");
            File.WriteAllText(path, xml.ToString());
        }


    }
}