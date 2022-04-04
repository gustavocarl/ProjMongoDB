using System.Collections.Generic;
using MongoDB.Driver;
using ProjMongoDB.Models;
using ProjMongoDB.Utils;

namespace ProjMongoDB.Services
{
    public class PersonService
    {
        private readonly IMongoCollection<Person> _persons;

        public PersonService(IProjMongoDatabaseSettings settings)
        {
            var person = new MongoClient(settings.ConnectionString);
            var database = person.GetDatabase(settings.DatabaseName);
            _persons = database.GetCollection<Person>(settings.PersonCollectionName);
        }

        public List<Person> Get() => _persons.Find(person => true).ToList();

        public Person Get(string id) => _persons.Find<Person>(person => person.Id == id).FirstOrDefault();

        public Person Create(Person person)
        {
            _persons.InsertOne(person);
            return person;
        }

        public void Update(string id, Person personIn) => _persons.ReplaceOne(person => person.Id == id, personIn);

        public void Remove(Person personIn) => _persons.DeleteOne(person => person.Id == personIn.Id);

        public void Remove(string id) =>
            _persons.DeleteOne(person => person.Id == id);
    }
}
