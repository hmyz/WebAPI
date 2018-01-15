using WebAPI.Models;

namespace WebAPI.Repository
{
    public interface IProductRepository
    {
        Product[] GetAll();
    }
}