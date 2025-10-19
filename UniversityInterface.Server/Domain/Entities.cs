namespace UniversityInterface.Server.Domain;

public class Course
{
    public int Id { get; set; }
    public string Code { get; set; } = "";
    public string Title { get; set; } = "";
    public int Credits { get; set; } = 3;
}

public class Term
{
    public int Id { get; set; }
    public string Name { get; set; } = "Fall 2025";
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}

public class Section
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; } = null!;
    public int TermId { get; set; }
    public Term Term { get; set; } = null!;
    public string Number { get; set; } = "001";
    public int Capacity { get; set; } = 30;
}