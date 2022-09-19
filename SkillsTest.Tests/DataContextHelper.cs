using Microsoft.EntityFrameworkCore;
using SkillsTest.Lib;
using System.Linq;

namespace SkillsTest.Tests
{
    internal class DataContextHelper
    {
        /// <summary>
        /// Returns an instance of the In-Memory db context for testing
        /// </summary>
        /// <returns></returns>
        public static DataContext GetMockDb(string name)
        {
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(name)
                .Options;

            var db = new DataContext(options);

            // Seed the database

            if (!db.Courses.Any())
            {
                db.Courses.AddRange(new[]
                {
                    new Course { Id = 1, Name = "Advanced Basketweaving" },
                    new Course { Id = 2, Name = "Math for Liberal Arts Majors" },
                    new Course { Id = 3, Name = "The Cosmos: An Introduction" },
                    new Course { Id = 4, Name = "Sociology and the Workplace" },
                    new Course { Id = 5, Name = "Advanced Gender Studies" },
                });

                db.SaveChanges();
            }

            if (!db.Students.Any())
            {
                foreach (var iteration in Enumerable.Range(1, 100))
                {
                    db.Students.Add(new Student
                    {
                        Id = iteration,
                        FirstName = "Test",
                        LastName = $"Student {iteration}",
                        Courses = db.Courses.Where(course => iteration % course.Id == 0).ToList()
                    });
                }

                db.SaveChanges();
            }

            if(!db.Enrollments.Any())
            {
                db.Enrollments.AddRange(new[]
                {
                    new StudentEnrollment { Id = 1, CourseId = 1, StudentId=1 },
                    new StudentEnrollment { Id = 2, CourseId = 1, StudentId=2 },
                    new StudentEnrollment { Id = 3, CourseId = 1, StudentId=3 },
                    new StudentEnrollment { Id = 4, CourseId = 2, StudentId=4 },
                    new StudentEnrollment { Id = 5, CourseId = 2, StudentId=5 },
                    new StudentEnrollment { Id = 6, CourseId = 2, StudentId=6 },
                });

                db.SaveChanges();
            }

            return db;
        }
    }
}