using System.Threading.Tasks;
using VapeShop.Core.Models;

namespace VapeShop.Core.Abstractions.Users
{
    public interface IUsersRepository
    {
        Task<List<User>> Get();
        Task Create(User user);
    }
}
