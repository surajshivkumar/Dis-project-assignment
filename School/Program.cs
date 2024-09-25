using System;
namespace SchoolProject.Models
{
    public class Program{
        static void Main(){
            MiddleSchool middleSchool = new MiddleSchool("Ryan International School", "Mr. Pinto", 9000, 6, 8);
            HighSchool highSchool = new HighSchool("Reva School","Ms. Anita",300,"VNS ground");

            highSchool.DisplayInfo();
            Console.WriteLine("\n");
            middleSchool.DisplayInfo();

        }
    }
}