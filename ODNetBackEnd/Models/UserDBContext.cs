using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ODNetBackEnd.Models
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
    }
}
