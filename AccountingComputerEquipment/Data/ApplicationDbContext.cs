using AccountingComputerEquipment.Models;
using Microsoft.EntityFrameworkCore;

namespace AccountingComputerEquipment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Subdivision> Subdivisions { get; set; }

    }
}
