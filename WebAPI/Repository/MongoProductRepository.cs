using MongoDB.Bson;
using MongoDB.Driver;
using System;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class MongoProductRepository : IProductRepository
    {
        private static MongoClient client;
        private static IMongoDatabase database;
        private static IMongoCollection<Product> collection;

        public MongoProductRepository()
        {
            client = new MongoClient("mongodb://localhost:27017/PeopleOfEngland");
            database = client.GetDatabase("PeopleOfEngland");
            collection = database.GetCollection<Product>("Products");
        }

        public Product Delete(string Id)
        {
            return collection.FindOneAndDelete(x => x.Id == new ObjectId(Id));
        }

        public Product[] GetAll()
        {
            return collection.Find(_ => true).ToList().ToArray();
        }

        public Product GetById(string Id)
        {
            return collection.Find(x => x.Id == new ObjectId(Id)).ToList()[0];
        }

        public Product Post(Product product)
        {
            collection.InsertOne(product);
            return (product);
        }
    }
}