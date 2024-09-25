namespace SchoolProject.Models
{
    public class School : ISchoolOperations
    {
        public string Name { get; set; }
        public string Principal { get; set; }
        public int StudentCount { get; set; }

        public School(string name, string principal, int studentCount)
        {
            Name = name;
            Principal = principal;
            StudentCount = studentCount;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"School Name: {Name}");
            Console.WriteLine($"Principal: {Principal}");
            Console.WriteLine($"Student Count: {StudentCount}");
        }
    }
}
