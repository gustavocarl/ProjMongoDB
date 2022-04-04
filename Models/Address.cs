using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjMongoDB.Models
{
    public class Address
    {
        #region Propriedades
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();

        [BsonRepresentation(BsonType.String)]
        public string Street { get; set; }

        #endregion
    }
}
