using System;

namespace CursoRecords
{
    class Program
    {
        static void PrintCourse(Course course)
        {
            Console.WriteLine(course.Name);
        }
        static void Main(string[] args)
        {
            var pluralsightCourse = new Course();
            pluralsightCourse.Name = "Working with C# Records";
            pluralsightCourse.Author = "roland Guijt";

            PrintCourse(pluralsightCourse);

            var anotherCourse = pluralsightCourse;

            Console.WriteLine(pluralsightCourse.Name);
            Console.WriteLine(anotherCourse.Name);
        }
    }

    public class Course
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }
}