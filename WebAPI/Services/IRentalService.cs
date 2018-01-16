using System.Threading;
using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IRentalService
    {
        Rental[] GetAll(CancellationToken cancellationToken);
        Rental GetById(string Id, CancellationToken cancellationToken);
        Rental Delete(string Id, CancellationToken cancellationToken);
        Rental Post(Rental rental, CancellationToken cancellationToken);
    }
}