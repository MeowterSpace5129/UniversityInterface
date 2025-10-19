using Microsoft.EntityFrameworkCore;
using UniversityInterface.Server.Models;

namespace UniversityInterface.Server.Data;

public class UniversityDbContext : DbContext
{
    public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options) { }

    public DbSet<Student> Students => Set<Student>();
    public DbSet<Term> Terms => Set<Term>();
    public DbSet<Section>> Sections => Set<Section>();

    protected override void OnModelCreating(ModelBuilder b)
    {
        b.Entity<Course>().HasIndex(x => x.Code).IsUnique();\
        b.Entity<Section>().Property(x => x.Capacity).HasDefaultValue(30);
    }
}
