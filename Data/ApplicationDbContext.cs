using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Province>? Provinces {get; set;}
    public DbSet<City>? Cities {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Replace the path with your SQLite database file location
        optionsBuilder.UseSqlite("Data Source=Community.sqlite");
    }

    
    protected override void OnModelCreating(ModelBuilder builder)
{
    base.OnModelCreating(builder);
    // builder.Entity<City>().Property(c => c.CityId).IsRequired();

    // builder.Entity<Province>().Property(p => p.ProvinceName).HasMaxLength(30);

    builder.Entity<Province>().ToTable("Province");
    builder.Entity<City>().ToTable("City");

    builder.Seed();
}

}
