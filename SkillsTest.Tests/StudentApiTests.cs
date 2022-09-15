using SkillsTest.Lib;
using Xunit;

namespace SkillsTest.Tests
{
    public class StudentApiTests
    {
        private DbStudentApi api = new DbStudentApi
        {
            Db = DataContextHelper.GetMockDb(nameof(StudentApiTests))
        };

        [Fact]
        public void Can_Get_Student_With_Id_1()
        {
            var student = api.GetById(1);

            Assert.NotNull(student);
        }
    }
}