using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebAPI.Models
{
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonElement("name")]
        public string FirstName { get; set; }
        [BsonElement("surname")]
        public string LastName { get; set; }
        [BsonElement("age")]
        public int Age { get; set; }
        [BsonElement("sex")]
        public string Gender { get; set; }
        [BsonElement("address")]
        public Address Address { get; set; }
        [BsonElement("data")]
        public string Data { get; set; }
    }
}