using System.Threading;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.Services
{
    public class UserService : IUserService
    {
        IUserRepository userRepository;
        IRentalService rentalService;

        public UserService(IUserRepository userRepository, IRentalService rentalService)
        {
            this.userRepository = userRepository;
            this.rentalService = rentalService;
        }

        public User Delete(string Id, CancellationToken cancellationToken)
        {
            if (rentalService.HasRelationship(GetById(Id, cancellationToken)))
                return null;
            return userRepository.Delete(Id);
        }

        public User[] GetAll(CancellationToken cancellationToken)
        {
            return userRepository.GetAll();
        }

        public User GetById(string Id, CancellationToken cancellationToken)
        {
            return userRepository.GetById(Id);
        }

        public User Post(User user, CancellationToken cancellationToken)
        {
            return userRepository.Post(user);
        }
    }
}