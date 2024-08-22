using System.Threading.Tasks;
using VapeShop.Core.Models;

namespace VapeShop.Core.Abstractions.Users
{
    public interface IUsersRepository
    {
        public Task<List<User>> GetList();
        public Task Add(User user);
        public Task<User> GetByPhone(string Phone);
        public Task<User> GetById(long UserId);
    }
}
