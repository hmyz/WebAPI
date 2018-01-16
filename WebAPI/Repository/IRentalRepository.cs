using WebAPI.Models;

namespace WebAPI.Repository
{
    public interface IRentalRepository
    {
        Rental Delete(string Id);
        Rental[] GetAll();
        Rental GetById(string Id);
        Rental Post(Rental rental);
    }
}