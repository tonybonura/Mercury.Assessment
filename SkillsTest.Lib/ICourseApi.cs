using System.Linq;

namespace SkillsTest.Lib
{
    public interface ICourseApi
    {
        Course GetById(int id);
    }
}