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

        public Rental[] GetAll()
        {
            return collection.Find(_ => true).ToList().ToArray();
        }

        public Rental GetById(string Id)
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

        public Rental GetByProductId(string Id)
        {
            if (!IdValid(Id))
                return null;
            try
            {
                return collection.Find(x => x.ProductId == Id).ToList()[0];
            }
            catch (ArgumentOutOfRangeException e)
            {
                return null;
            }
        }

        public Rental GetByUserId(string Id)
        {
            if (!IdValid(Id))
                return null;
            try
            {
                return collection.Find(x => x.UserId == Id).ToList()[0];
            }
            catch (ArgumentOutOfRangeException e)
            {
                return null;
            }
        }

        public Rental Post(Rental rental)
        {
            collection.InsertOne(rental);
            return (rental);
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