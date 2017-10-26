using System;


namespace DataBaseApi
{
    public class DBFactory
    {
        public static IPerson getInstance(string key)
        {
            IPerson db = null;

            switch (key)
            {
                case "Binary":
                    db = new BinaryPerson();
                    break;
                case "BinaryL":
                    db = new BinaryLPerson();
                    break;
                case "MsSQL":
                    db = new MsSQLPerson();
                    break;
                case "MySQL":
                    db = new MySQLPerson();
                    break;
                case "H2":
                    db = new H2Person();
                    break;
                case "JsonLb":
                    db = new JsonPersonLb();
                    break;
                case "XmlLb":
                    db = new XmlPersonLb();
                    break;
                case "CsvLb":
                    db = new CsvPersonLb();
                    break;
                case "YamlLb":
                    db = new YamlPersonLb();
                    break;
                case "Json":
                    db = new JsonPerson();
                    break;
                case "Xml":
                    db = new XmlPerson();
                    break;
                case "Csv":
                    db = new CsvPerson();
                    break;
                case "Yaml":
                    db = new YamlPerson();
                    break;
                case "MongoDb":
                    db = new MongoDbPerson();
                    break;
                case "MsSQLEf":
                    db = new MsSQLEfPerson();
                    break;
                case "Mock":
                    db = new PersonDAO_Mock();
                    break;
                default: throw new ArgumentException();

            }
            return db;
        }
    }
}
