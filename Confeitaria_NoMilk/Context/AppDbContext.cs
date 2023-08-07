using Confeitaria_NoMilk.Models;
using Microsoft.EntityFrameworkCore;

namespace Confeitaria_NoMilk.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }

        public DbSet<CATEGORIA> CATEGORIAs { get; set; }
        public DbSet<LANCHE> LANCHEs { get; set; }
    }
}

