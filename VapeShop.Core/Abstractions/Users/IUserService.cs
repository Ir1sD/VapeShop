using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VapeShop.Core.Models;

namespace VapeShop.Core.Abstractions.Users
{
    public interface IUserService
    {
        public Task<User> GetByPhone(string Phone);
        public Task<User> GetById(long Id);
        public Task Add(User user);
        public Task Authorization(User user);
        public Task<User> GetUser();
    }
}
