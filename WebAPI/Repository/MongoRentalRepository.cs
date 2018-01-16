using MongoDB.Bson;
using MongoDB.Driver;
using System;
using WebAPI.Models;

namespace WebAPI.Repository
{
    public class MongoRentalRepository : IRentalRepository
    {
        private static MongoClient client;
        private static IMongoDatabase database;
        private static IMongoCollection<Rental> collection;

        public MongoRentalRepository()
        {
            client = new MongoClient("mongodb://localhost:27017/PeopleOfEngland");
            database = client.GetDatabase("PeopleOfEngland");
            collection = database.GetCollection<Rental>("Rentals");
        }

        public Rental Delete(string Id)
        {
            return collection.FindOneAndDelete(x => x.Id == new ObjectId(Id));
        }

        public Rental[] GetAll()
        {
            return collection.Find(_ => true).ToList().ToArray();
        }

        public Rental GetById(string Id)
        {
            return collection.Find(x => x.Id == new ObjectId(Id)).ToList()[0];
        }

        public Rental Post(Rental rental)
        {
            collection.InsertOne(rental);
            return (rental);
        }
    }
}