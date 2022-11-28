using EFCore_CodeFirst_Example.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_CodeFirst_Example;

public interface ISchoolDbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
}
