using MongoDB.Bson.Serialization.Attributes;

namespace WebAPI.Models
{
    public class Address
    {
        [BsonElement("city")]
        public string City { get; set; }
        [BsonElement("street")]
        public string Street { get; set; }
        [BsonElement("number")]
        public int Number { get; set; }
    }
}