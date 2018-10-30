using NLightHouse.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NLightHouse
{
  public partial class NLighthouseDbContext : DbContext
  {
    public NLighthouseDbContext()
    {
    }

    public NLighthouseDbContext(DbContextOptions<NLighthouseDbContext> options)
        : base(options)
    {
    }

    public DbSet<Person> Persons { get; set; }
    public DbSet<Project> Projects { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=postgres;UID=postgres;");
      }
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Person>()
       .HasOne(p => p.Name);

      builder.Entity<Person>()
        .HasMany(p => p.Following);

      builder.Entity<Person>()
        .HasMany(p => p.Follower);

      builder.Entity<Person>()
        .HasMany(p => p.Blocked);

      builder.Entity<Person>()
        .HasMany(p => p.OwnedProject);

      builder.Entity<Person>()
        .HasMany(p => p.FundedProject);

      builder.Entity<Project>()
        .HasMany(p => p.Owners);

      builder.Entity<Project>()
        .HasMany(p => p.Funders);

      builder.Entity<Project>()
        .HasOne(p => p.Owners);

      builder.Entity<Project>()
        .HasOne(p => p.Purpose);
    }
  }
}
