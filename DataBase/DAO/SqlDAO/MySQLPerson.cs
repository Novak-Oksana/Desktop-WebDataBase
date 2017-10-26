using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DataBaseApi
{
    internal class MySQLPerson : DbPerson
    {
        private MySqlConnection connection;

        public MySQLPerson()
        {
            connection = new MySqlConnection(@"Server=localhost;Database=person;Uid=root;Pwd=root;");
        }
        
        public override void Create(Person person)
        {
            ExecComand(new MySqlCommand("INSERT INTO person VALUES ('" +
                 +person.Id + "', '" + person.Fn + "', '" + person.Ln + "', '" + person.Age + "');", connection));
        }

        public override void Delete(int id)
        {
            ExecComand(new MySqlCommand("DELETE FROM person " +
                 "WHERE id = '" +id + "'", connection));
        }

        public override void Update(Person person)
        {
            ExecComand(new MySqlCommand("UPDATE person  SET " +
                 "firstname='" + person.Fn + "' , lastname ='" + person.Ln + "' , age='" + person.Age + "' " +
                 "WHERE id='" + person.Id + "'", connection));
        }

        public override List<Person> Read()
        {
            List<Person> persons = new List<Person>();
            connection.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM person;", connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string fn = reader.GetString(1);
                string ln = reader.GetString(2);
                int age = reader.GetInt32(3);
                persons.Add(new Person(id, fn, ln, age));
            }
            connection.Close();
            return persons;
        }
    }
}