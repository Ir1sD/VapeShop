using Microsoft.EntityFrameworkCore;
using VapeShop.Data.Entities;

namespace VapeShop.Data.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
           : base(options)
        {
            
        }

        DbSet<User> Users { get; set; }

    }
}
