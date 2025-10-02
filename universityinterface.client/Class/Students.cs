namespace UniversityInterface.Server.Student
{
    public class Students
    {
        private DateTime dateOfBirth;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
    }
}