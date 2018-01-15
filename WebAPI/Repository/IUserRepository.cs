using WebAPI.Models;

namespace WebAPI.Repository
{
    public interface IUserRepository
    {
        User[] GetAll();
    }
}