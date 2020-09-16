using Microsoft.EntityFrameworkCore;
using Virto.Models;

namespace Virto.Persistence
{
    public class ViroDbContext : DbContext
    {
        public ViroDbContext(DbContextOptions<ViroDbContext> options) 
            : base(options) 
        {
        }
        public DbSet<Make> Makes { get; set; }
    
    }
}