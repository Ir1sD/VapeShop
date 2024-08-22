using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VapeShop.Core.Abstractions.Users;
using VapeShop.Core.Models;

namespace VapeShop.Core.Services
{
    public class UserService : IUserService
    {
        private IUsersRepository usersRepository;

        public UserService(IUsersRepository repository) 
        { 
            usersRepository = repository;
        }

        public async Task<User> Get(string Phone)
        {
            return await usersRepository.Get(Phone);
        }

        public async Task Register(User user)
        {
            await usersRepository.Register(user);
        }
    }
}
