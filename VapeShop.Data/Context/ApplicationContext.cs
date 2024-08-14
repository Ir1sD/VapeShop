using Microsoft.EntityFrameworkCore;

namespace VapeShop.Data.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
           : base(options)
        {
            
        }


    }
}
