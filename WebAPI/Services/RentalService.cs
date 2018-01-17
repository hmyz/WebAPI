using System.Threading;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.Services
{
    public class RentalService : IRentalService
    {
        IRentalRepository rentalRepository;
        IProductRepository productRepository;
        IUserRepository userRepository;
        public RentalService(IRentalRepository rentalRepository, IProductRepository productRepository, IUserRepository userRepository)
        {
            this.rentalRepository = rentalRepository;
            this.productRepository = productRepository;
            this.userRepository = userRepository;
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
            bool IsValid =
                (productRepository.GetById(rental.ProductId) != null) &&
                (userRepository.GetById(rental.UserId) != null);
            return IsValid ? rentalRepository.Post(rental) : null;
        }

        public bool HasRelationship(Product product)
        {
            return (rentalRepository.GetByProductId(product.Id.ToString())) == null ? false : true;
        }

        public bool HasRelationship(User user)
        {
            return (rentalRepository.GetByUserId(user.Id.ToString())) == null ? false : true;
        }
    }
}