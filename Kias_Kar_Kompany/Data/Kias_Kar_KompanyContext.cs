using Microsoft.EntityFrameworkCore;
using Kias_Kar_Kompany.Models;

namespace Kias_Kar_Kompany.Data
{
    public class Kias_Kar_KompanyContext : DbContext
    {
        public Kias_Kar_KompanyContext(DbContextOptions<Kias_Kar_KompanyContext> options)
            : base(options)
        { 
        }

        public DbSet<Kias_Kar_Kompany.Models.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<Kias_Kar_Kompany.Models.Manufacturer> Manufacturer { get; set; } = default!;
        public DbSet<Kias_Kar_Kompany.Models.Owner> Owner { get; set; } = default!;

    }
}
