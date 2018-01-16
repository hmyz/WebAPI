using WebAPI.Models;

namespace WebAPI.Repository
{
    public interface IProductRepository
    {
        Product Delete(string Id);
        Product[] GetAll();
        Product GetById(string Id);
        Product Post(Product product);
    }
}