using System.Linq;

namespace SkillsTest.Lib
{
    /// <summary>
    /// Provides methods get information about available courses.
    /// </summary>
    public interface ICourseApi
    {
        /// <summary>
        /// Gets the <see cref="Course"/> with the specified <paramref name="id"/>
        /// </summary>
        /// <param name="id">The id of the course to get.</param>
        /// <returns>a <see cref="Course"/> object that represents the course with the specified <paramref name="id"/>; or <c>null</c> if no record is found.</returns>
        Course GetById(int id);
    }
}