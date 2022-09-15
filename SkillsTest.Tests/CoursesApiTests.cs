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
    }
}