using System.Threading;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.Services
{
    public class RentalService : IRentalService
    {
        IRentalRepository rentalRepository;
        public RentalService(IRentalRepository rentalRepository)
        {
            this.rentalRepository = rentalRepository;
        }
        public Rental Delete(string Id, CancellationToken cancellationToken)
        {
            return rentalRepository.Delete(Id);
        }

        public Rental[] GetAll(CancellationToken cancellationToken)
        {
            return rentalRepository.GetAll();
        }

        public Rental GetById(string Id, CancellationToken cancellationToken)
        {
            return rentalRepository.GetById(Id);
        }

        public Rental Post(Rental rental, CancellationToken cancellationToken)
        {
            return rentalRepository.Post(rental);
        }
    }
}