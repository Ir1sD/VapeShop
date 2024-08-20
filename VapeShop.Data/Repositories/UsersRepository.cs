using VapeShop.Data.Context;
using System.Threading.Tasks;
using VapeShop.Core.Models;
using Microsoft.EntityFrameworkCore;
using VapeShop.Data.Entities;
using VapeShop.Core.Abstractions.Users;

namespace VapeShop.Data.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private ApplicationContext _context;

        public UsersRepository(ApplicationContext context) 
        {
            _context = context;
        }

        /// <summary>
        /// Возвращает список пользователей
        /// </summary>
        public async Task<List<User>> Get()
        {
            var users = await _context.Users
                .AsNoTracking()
                .Select(c => User.New(c.Id, c.FirstName, c.Name, c.Email, c.Password, c.DateBithDay))
                .ToListAsync();

            return users;
        }

        /// <summary>
        /// Добавляет нового пользователя
        /// </summary>
        /// <param name="user">Объект юзера</param>
        public async Task Create(User user)
        {
            var usr = new UserEntity
            {
                Id = user.Id,
                FirstName = user.FirstName,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password,
                DateBithDay = user.DateBithDay
            };

            await _context.Users.AddAsync(usr);
            await _context.SaveChangesAsync();
        }

    }
}
