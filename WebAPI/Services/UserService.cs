using System.Threading;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.Services
{
    public class UserService : IUserService
    {
        IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public User Delete(string Id, CancellationToken cancellationToken)
        {
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