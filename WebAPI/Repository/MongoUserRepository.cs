using MongoDB.Driver;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class MongoUserRepository : IUserRepository
    {
        private static MongoClient client = new MongoClient("mongodb://localhost:27017/PeopleOfEngland");
        private static IMongoDatabase database = client.GetDatabase("PeopleOfEngland");
        private static IMongoCollection<User> collection = database.GetCollection<User>("People");

        public MongoUserRepository()
        {

        }

        public User[] GetAll()
        {
            return collection.Find(_ => true).ToList().ToArray();
        }

    }
}