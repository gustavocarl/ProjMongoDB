﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProjMongoDB.Models
{
    public class Address
    {
        #region Propriedades

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }

        public string Street { get; set; }

        #endregion
    }
}