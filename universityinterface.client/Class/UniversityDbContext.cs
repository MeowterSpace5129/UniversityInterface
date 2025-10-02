using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UniversityInterface.Server.Identity;
using UniversityInterface.Server.Models;

namespace UniversityInterface.Server.Data;

public class UniversityDbContext : IdentityDbContext<ApplicationUser>
{
    public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options) { }

    public DbSet<Student> Students => Set<Student>();
}
