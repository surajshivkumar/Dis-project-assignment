namespace SchoolProject.Models
{
    public class HighSchool : School
    {
        public string SportsFieldName { get; set; }

        public HighSchool(string name, string principal, int studentCount, string sportsFieldName)
            : base(name, principal, studentCount)
        {
            SportsFieldName = sportsFieldName;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Sports Field Name: {SportsFieldName}");
        }
    }
}
