using System.Collections.Generic;
using System.Linq;
using SkillsTest.Lib;
using Xunit;

namespace SkillsTest.Tests
{
    public class CoursesApiTests
    {
        private DbCourseApi api = new DbCourseApi
        {
            Db = DataContextHelper.GetMockDb(nameof(CoursesApiTests))
        };

        [Fact]
        public void Can_Get_Course_With_Id_1()
        {
            var course = api.GetById(1);

            Assert.NotNull(course);
        }

        [Theory]
        [InlineData(1,1,5)]
        public void Can_Get_All_Courses_With_Pagination(int pageSize, int pageNumber, int expectedCount)
        {
            var results = new List<Course>();

            var courses = api.GetAll(pageSize, pageNumber++);

            while(courses.Any())
            {
                results.AddRange(courses);
                courses = api.GetAll(pageSize, pageNumber++);
            }

            Assert.Equal(results.Count, expectedCount);
        }

        [Theory]
        [InlineData("Math for Liberal Arts Majors", true)]
        [InlineData("math for liberal arts majors", true)]
        [InlineData("No Course by This Name", false)]
        public void Can_Get_Get_Course_By_Name(string courseName, bool shouldFind)
        {
            var course = api.GetByName(courseName);

            if(shouldFind)
                Assert.NotNull(course);
            else
                Assert.Null(course);
        }
    }
}