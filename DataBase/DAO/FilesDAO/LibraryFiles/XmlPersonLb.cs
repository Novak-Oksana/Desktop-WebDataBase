using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DataBaseApi
{
    public class XmlPersonLb : FilePerson
    {
        static string path = @"E:\work\DataBase\DataBase\xml_db.xml";
        public XmlPersonLb():base(path)
        {

        }

        protected override List<Person> load(String path)
        {
            TextReader reader = File.OpenText(path);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            List<Person> persons;
            try
            {
                persons = (List<Person>)serializer.Deserialize(reader);
            }
            catch (Exception exception)
            {
                persons = new List<Person>();
            }
            reader.Close();
            return persons;
        }

        protected override void save(List<Person> persons, String path)
        {
            TextWriter writer = File.CreateText(path);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            serializer.Serialize(writer, persons);
            writer.Close();
        }

    }
}
