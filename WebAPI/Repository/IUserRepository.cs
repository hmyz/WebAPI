using WebAPI.Models;

namespace WebAPI.Repository
{
    public interface IUserRepository
    {
        User Delete(string Id);
        User[] GetAll();
        User GetById(string Id);
        User Post(User user);
    }
}