using System.Collections.Generic;
using System.IO;

namespace DataBaseApi
{
    internal class BinaryPerson : FilePerson
    {
        static string path = @"E:\work\DataBase\DataBase\Binary_db.txt";
        public BinaryPerson() : base(path)
        {

        }

        protected override List<Person> load(string path)
        {
            List<Person> persons = new List<Person>();
            FileStream sr = new FileStream(path, FileMode.OpenOrCreate);
            BinaryReader br = new BinaryReader(sr);
            while (br.BaseStream.Position != br.BaseStream.Length)
            {
                Person p = new Person();
                p.Id = br.ReadInt32();
                br.ReadString();//'\n'
                p.Fn = br.ReadString();
                br.ReadString();//'\n'
                p.Ln = br.ReadString();
                br.ReadString();//'\n'
                p.Age = br.ReadInt32();
                br.ReadString();//'\n'
                persons.Add(p);
            }
            sr.Close();
            return persons;
            // throw new System.NotImplementedException();
        }

        protected override void save(List<Person> persons, string path)
        {
            FileStream sw = new FileStream(path, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(sw);
            foreach (Person p in persons)
            {
                bw.Write(p.Id);
                bw.Write("\n");
                bw.Write(p.Fn);
                bw.Write("\n");
                bw.Write(p.Ln);
                bw.Write("\n");
                bw.Write(p.Age);
                bw.Write("\n");
            }
            sw.Close();
            // throw new System.NotImplementedException();
        }
    }
}