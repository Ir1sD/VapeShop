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
        public async Task<List<User>> GetList()
        {
            var users = await _context.Users
                .AsNoTracking()
                .Select(c => User.New(c.Id, c.FirstName, c.Name, c.LastName, c.Phone , c.DateBithDay , c.DateReg))
                .ToListAsync();

            return users;
        }

        /// <summary>
        /// Добавляет нового пользователя
        /// </summary>
        /// <param name="user">Объект юзера</param>
        public async Task Register(User user)
        {
            var usr = new UserEntity
            {
                Id = user.Id,
                FirstName = user.FirstName,
                Name = user.Name,
                LastName = user.LastName,
                Phone = user.Phone,
                DateBithDay = user.DateBithDay,
                DateReg = user.DateReg
            };

            await _context.Users.AddAsync(usr);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Возвращает пользователя по номеру телефона или null
        /// </summary>
        /// <param name="Phone">Номер телефона</param>
        public async Task<User> Get(string Phone)
        {
            var user = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Phone.Equals(Phone));

            if (user is null) return null;

            var usr = User.New(
                user.Id,
                user.FirstName,
                user.Name,
                user.LastName,
                user.Phone,
                user.DateBithDay,
                user.DateReg);

            return usr;
        }

    }
}
