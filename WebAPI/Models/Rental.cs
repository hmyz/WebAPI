using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebAPI.Models
{
    public class Rental
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("userId")]
        public string UserId { get; set; }
        [BsonElement("productId")]
        public string ProductId { get; set; }
    }
}