using System.Threading.Tasks;
using VapeShop.Core.Models;

namespace VapeShop.Core.Abstractions.Users
{
    public interface IUsersRepository
    {
        public Task<List<User>> GetList();
        public Task Register(User user);
        public Task<User> Get(string Phone);
    }
}
