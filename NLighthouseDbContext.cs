using NLightHouse.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Npgsql.EntityFrameworkCore.PostgreSQL;

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
      if (true)
      {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=postgres;UID=postgres;");
      }
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {

      builder.Entity<ProjectPerson>()
       .HasKey(pp => pp.Id);

      builder.Entity<ProjectPerson>()
        .HasOne(pp => pp.Person)
        .WithMany(per => per.FundedProject)
        .HasForeignKey(pp => pp.PersonId);

      builder.Entity<ProjectPerson>()
        .HasOne(pp => pp.Project)
        .WithMany(pro => pro.Funders)
        .HasForeignKey(pp => pp.ProjectId);

      builder.Entity<Person>()
        .HasMany(p => p.Following);

      builder.Entity<Person>()
        .HasMany(p => p.Follower);

      builder.Entity<Person>()
        .HasMany(p => p.Blocked);

      /*
            builder.Entity<Person>()
              .HasMany(per => per.OwnedProject)
              .WithOne(pro => pro.Person)
              .HasForeignKey(pers => pers.ProjectId);

            builder.Entity<Person>()
              .HasMany(per => per.FundedProject)
              .WithOne(pro => pro.Person)
              .HasForeignKey(pers => pers.ProjectId);

            builder.Entity<Project>()
              .HasMany(pro => pro.Owners)
              .WithOne(per => per.Project)
              .HasForeignKey(proj => proj.PersonId);

            builder.Entity<Project>()
              .HasMany(proj => proj.Funders)
              .WithOne(pers => pers.Project)
              .HasForeignKey(proj => proj.PersonId);
              */
    }
  }
}
