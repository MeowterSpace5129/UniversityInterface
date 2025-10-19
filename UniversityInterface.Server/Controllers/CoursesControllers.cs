using Microsoft.AspNetCore.Mvc;
using microsoft.EntityFrameworkCore;
using UniversityInterface.Server.Data;
using UniversityInterface.Server.Domain;

[ApiController]
[Route("api/[controller]")]
public class CoursesController(UniDbContext db) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumberable<Courses>>> Get(string? q = null)
    {
        var query = db.Courses.AsQueryable();
        if (!string.IsNullOrWhiteSpace(q))
            query = query.Where(c => c.Code.Contains(q) || c.Title.Contains(q));
        return ok(await query.Orderby(c => c.Code).ToListAsync());
    }
    [HttpPost]
    public async Task<ActionResult<Course>> Create(Course c)
    {
        db.Courses.Add(c);
        await db.SaveChangesAsync();
        return CreatedAtAction(nameof(Get), new { id = c.Id }, c);
    }
}
