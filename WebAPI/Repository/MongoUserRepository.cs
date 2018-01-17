using MongoDB.Bson;
using MongoDB.Driver;
using System;
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
            if (!IdValid(Id))
                return null;
            try
            {
                return collection.FindOneAndDelete(x => x.Id == new ObjectId(Id));
            }
            catch (ArgumentOutOfRangeException e)
            {
                return null;
            }
        }

        public User[] GetAll()
        { 
            return collection.Find(_ => true).ToList().ToArray();
        }
        public User GetById(string Id)
        {
            if (!IdValid(Id))
                return null;
            try
            {
                return collection.Find(x => x.Id == new ObjectId(Id)).ToList()[0];
            }
            catch (ArgumentOutOfRangeException e)
            {
                return null;
            }
        }
        public User Post(User user)
        {
            collection.InsertOne(user);
            return (user);
        }

        private bool IdValid(string Id)
        {
            try
            {
                var objectId = new ObjectId(Id);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}