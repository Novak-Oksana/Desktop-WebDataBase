using System.Data.Entity;

namespace DataBaseApi
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\work\DataBase\DataBase\DataBase\MsSqlPerson.mdf;Integrated Security=True")
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
