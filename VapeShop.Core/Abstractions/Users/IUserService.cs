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
        public Task<User> Get(string Phone);
        public Task Register(User user);
    }
}
