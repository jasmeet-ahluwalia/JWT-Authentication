using Microsoft.EntityFrameworkCore;

namespace JWT_Authentication.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)  : base(options)
        { }

        public DbSet<Users> UserTable { get; set; }

    }
}
