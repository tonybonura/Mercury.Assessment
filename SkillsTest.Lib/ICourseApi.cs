using System.Collections.Generic;
using System.Linq;

namespace SkillsTest.Lib
{
    /// <summary>
    /// Provides methods get information about available courses.
    /// </summary>
    public interface ICourseApi
    {
        /// <summary>
        /// Gets the Courses at <paramref name="pageNumber"/> given the specified <paramref name="pageSize"/> after being ordered by course name then id.
        /// </summary>
        /// <param name="pageSize">The number of items per page.</param>
        /// <param name="pageNumber">The page of items to get.</param>
        /// <returns>A collection of <see cref="Course"/> objects that represents the courses in <paramref name="pageNumber"/> given the specified <paramref name="pageSize"/>.</returns>
        ICollection<Course> GetAll(int pageSize, int pageNumber);

        /// <summary>
        /// Gets the <see cref="Course"/> with the specified <paramref name="id"/>
        /// </summary>
        /// <param name="id">The id of the course to get.</param>
        /// <returns>a <see cref="Course"/> object that represents the course with the specified <paramref name="id"/>; or <c>null</c> if no record is found.</returns>
        Course GetById(int id);

        /// <summary>
        /// Gets the course with specified <paramref name="courseName"/>
        /// </summary>
        /// <param name="courseName">The name of the course to get.</param>
        /// <returns>A <see cref="Course"/> object that represents the course with the specified <paramref name="courseName"/>; or <c>null</c> if no course is found.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="courseName"/> is null.</exception>
        /// <exception cref="InvalidOperationException">Sequence contains more than one element.</exception>
        Course GetByName(string courseName);
    }
}