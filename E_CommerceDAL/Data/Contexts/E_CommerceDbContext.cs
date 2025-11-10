using E_CommerceDAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace E_CommerceDAL.Data.Contexts
{
    public class E_CommerceDbContext : DbContext
    {
        // dbcontextOptions contains some information about DB from DI container like ConnectionString and
        // another information. 
        public E_CommerceDbContext(DbContextOptions<E_CommerceDbContext> dbContextOptions) : base(dbContextOptions) // Pass dbContextOptions to the base class
        {

        }

        #region DbSets

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        #endregion
    }
}
