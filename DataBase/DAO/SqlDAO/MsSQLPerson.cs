using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataBaseApi
{
    internal class MsSQLPerson : DbPerson
    {
        private SqlConnection connection;

        public MsSQLPerson()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\work\DataBase\DataBase\DataBase\MsSqlPerson.mdf;Integrated Security=True;");
        }

        public override void Create(Person person)
        {
            ExecComand(new SqlCommand("INSERT INTO person VALUES ('" +
                 +person.Id + "', '" + person.Fn + "', '" + person.Ln + "', '" + person.Age + "');", connection));
        }

        public override void Delete(int id)
        {
            ExecComand(new SqlCommand("DELETE FROM person " +
                 "WHERE id = '" + id + "'", connection));
        }

        public override void Update(Person person)
        {
            ExecComand(new SqlCommand("UPDATE person  SET " +
                 "firstname='" + person.Fn + "' , lastname ='" + person.Ln + "' , age='" + person.Age + "' " +
                 "WHERE id='" + person.Id + "'", connection));
        }

        public override List<Person> Read()
        {
            List<Person> persons = new List<Person>();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM person;", connection);
            SqlDataReader reader = command.ExecuteReader();
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