using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using TaskManagement.API.Models;
using TaskManagement.API.Seed;

namespace TaskManagement.API.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<ProjectTask> ProjectTasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(warnings =>
            warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        builder.Entity<ProjectTask>()
            .Property(t => t.Status)
            .HasConversion<string>();

        builder.Entity<ProjectTask>()
            .HasData(FakeTaskGenerator.GenerateProjectTaskList());
    }
}
