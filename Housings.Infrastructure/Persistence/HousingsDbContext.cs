using Housings.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Housings.Infrastructure.Persistence
{
    internal class HousingsDbContext(DbContextOptions<HousingsDbContext> options) : DbContext(options)
    {
        internal DbSet<Housing> Housing { get; set; }
        internal DbSet<Furnitures> Furnitures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Housing>()
                .OwnsOne(a => a.Address);

            modelBuilder.Entity<Housing>()
                .HasMany(a => a.Furnitures)
                .WithOne()
                .HasForeignKey(d => d.HousingsId);
        }
    }
}
