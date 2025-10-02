using Microsoft.EntityFrameworkCore;
using UniversityInterface.Server.Models;

namespace UniversityInterface.Server.Data;

public class UniversityDbContext : DbContext
{
    public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options) { }

    public DbSet<Student> Students => Set<Student>();
}
