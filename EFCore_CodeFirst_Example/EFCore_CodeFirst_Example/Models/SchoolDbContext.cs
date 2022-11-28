using Microsoft.EntityFrameworkCore;

namespace EFCore_CodeFirst_Example.Models;

public class SchoolDbContext : DbContext, ISchoolDbContext
{
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Course> Courses { get; set; } = null!;
    public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.HasDefaultSchema("MireroStudy");

        builder.Entity<Student>().HasData(
            new Student { Name = "BeomBeomJoJo1", StudentId = 1 },
            new Student { Name = "BeomBeomJoJo2", StudentId = 2 },
            new Student { Name = "BeomBeomJoJo3", StudentId = 3 }
            );
    }
}