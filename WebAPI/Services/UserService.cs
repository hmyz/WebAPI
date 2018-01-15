using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public User[] GetAll(CancellationToken cancellationToken)
        {
            return userRepository.GetAll();
        }

        public User GetById(string Id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public bool Post(User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}