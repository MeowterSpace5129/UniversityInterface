
using Microsoft.EntityFrameworkCore;
using UniversityInterface.server.Data;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<UniDbContext>(opt =>
    opt.UseSqlServer(builder.configuration.GetConnectionString("Defualt")));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(o=>
    o.AddPolicy("http://localhost:5173")
        .WithOrigins("Http://localhost:5173")
        .AllowAnyHeader().AllowAnyMethod()));

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("Vite");
app.MapControllers();



using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<UniDbContext>();
    db.Database.Migrate();
    if(!db.Courses.Any())
            db.Courses.AddRange(
            new () { Code = "CS101", Title = "Introduction to CS", Credits = 3 },
            new () { Code = "MATH201", Title = "Calculus I", Credits = 4 });
    if (!dbContext.Terms.Any())
        db.Terms.Add(new() { name = "Fall 2025", StartDate = new DateTime(2025, 9, 1), EndDate = new DateTime(2025, 12, 15) });
    await db.SaveChangesAsync();
}


app.Run();
