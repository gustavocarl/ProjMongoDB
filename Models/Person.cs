using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjMongoDB.Models
{
    public class Person
    {
        #region Propriedades

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        public Address Address { get; set; }

        #endregion
    }
}
