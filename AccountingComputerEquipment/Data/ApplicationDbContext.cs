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

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Users>()
        //        .HasMany(c => c.Computers)
        //        .WithRequired(u => u.User)
        //        .HasForeignKey(u => u.UserId)
        //        .WillCascadeOnUpdate(true);
        //}

        public DbSet<Computer> Computers { get; set; }
        public DbSet<PCMonitor> Monitors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Subdivision> Subdivisions { get; set; }
        //public DbSet<Branch> Branches { get; set; }
        //public DbSet<Software> Softwares { get; set; }
        public DbSet<UserOperatingSystem> UserOperatingSystems { get; set; }
    }
}
