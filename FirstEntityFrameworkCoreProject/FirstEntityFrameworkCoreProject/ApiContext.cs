using FirstEntityFrameworkCoreProject.DbModels;
using Microsoft.EntityFrameworkCore;

namespace FirstEntityFrameworkCoreProject
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
            :base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
