using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions options)
            :base(options)
        {
        }
 
        public DbSet<User> User { get; set; }
    }
}