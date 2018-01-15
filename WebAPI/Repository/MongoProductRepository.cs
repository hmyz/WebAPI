using WebAPI.Models;

namespace WebAPI.Repository
{
    public class MongoProductRepository : IProductRepository
    {
        public MongoProductRepository()
        {

        }

        public Product[] GetAll()
        {
            return new Product[0];
        }

    }
}