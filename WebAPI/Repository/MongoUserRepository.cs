using MongoDB.Bson;
using MongoDB.Driver;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class MongoUserRepository : IUserRepository
    {
        private static MongoClient client;
        private static IMongoDatabase database;
        private static IMongoCollection<User> collection;

        public MongoUserRepository()
        {
            client = new MongoClient("mongodb://localhost:27017/PeopleOfEngland");
            database = client.GetDatabase("PeopleOfEngland");
            collection = database.GetCollection<User>("Users");
        }

        public User Delete(string Id)
        {
            return collection.FindOneAndDelete(x => x.Id == new ObjectId(Id));
        }

        public User[] GetAll()
        { 
            return collection.Find(_ => true).ToList().ToArray();
        }
        public User GetById(string Id)
        {
            return collection.Find(x => x.Id == new ObjectId(Id)).ToList()[0];
        }
        public User Post(User user)
        {
            collection.InsertOne(user);
            return (user);
        }

    }
}