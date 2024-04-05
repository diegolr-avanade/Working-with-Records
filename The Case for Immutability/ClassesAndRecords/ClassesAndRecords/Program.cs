using System;

namespace ClassesAndRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            var pluralsightCourse = new Course();
            pluralsightCourse.Name = "Working with C# Records";
            pluralsightCourse.Author = "Roland Guijt";

            var classroomCourse = new CourseRecord(pluralsightCourse.Name, pluralsightCourse.Author);

            classroomCourse.Name = "Another title"; // It doesn't work: it's immutable.
        }
    }

    public class Course
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }

    public record CourseRecord(string Name, string Author)
    {

    }
}
