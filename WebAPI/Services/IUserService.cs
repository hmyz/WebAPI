using System.Threading;
using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IUserService
    {
        User[] GetAll(CancellationToken cancellationToken);
        User GetById(string Id, CancellationToken cancellationToken);
        User Delete(string Id, CancellationToken cancellationToken);
        User Post(User user, CancellationToken cancellationToken);
    }
}