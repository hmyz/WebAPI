using System.Threading;
using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IProductService
    {
        Product[] GetAll(CancellationToken cancellationToken);
        Product GetById(string Id, CancellationToken cancellationToken);
        Product Delete(string Id, CancellationToken cancellationToken);
        bool Post(Product Product, CancellationToken cancellationToken);
    }
}