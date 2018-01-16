using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebAPI.Models
{
    public class Product
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("price")]
        public int Price { get; set; }
        [BsonElement("availability")]
        public bool Availability { get; set; }
        [BsonElement("User")]
        public ObjectId UserId { get; set; }
    }
}