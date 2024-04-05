using System;
using System.Text.StringBuilder;

namespace ClassesAndRecords
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CourseRecord classroomCourse = new TimedCourseRecord(
                "Working with C# Records",
                "Roland Guijt",
                Duration: 90
            );

            Console.WriteLine(classroomCourse);
        }

        public record CourseRecord(string Name, string Author)
        {

        }

        public record TimedCourseRecord(string Name, string Author, int Duration)
            : CourseRecord(Name, Author)
        {
            public string Venue { get; init; }

            //public override string ToString()
            //{
            //    return $"{Name} - {Author}";
            //} -> o este método, o el PrintMembers, pero no ambos

            protected override bool PrintMembers(StringBuilder builder)
            {
                if (base.PrintMembers(builder))
                {
                    builder.Append(", ");
                }
                builder.Append("Duration");
                builder.Append(" = ");
                builder.Append(this.Duration.ToString());
                builder.Append(", ");
                builder.Append("Venue");
                builder.Append(" = ");
                builder.Append((object)this.Venue);
                builder.Append("Title");
                builder.Append(" = ");
                builder.Append($"{Name} - {Author}");
                return true;
            }
        }

    }
}