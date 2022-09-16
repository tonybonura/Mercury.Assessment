using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillsTest.Lib
{
    /// <summary>
    /// Provides methods to get information about students.
    /// </summary>
    public interface IStudentApi
    {
        /// <summary>
        /// Gets the students at <paramref name="pageNumber"/> given the specified <paramref name="pageSize"/> after being ordered by last nane then id.
        /// </summary>
        /// <param name="pageSize">The number of items per page.</param>
        /// <param name="pageNumber">The page of items to get.</param>
        /// <returns>A collection of <see cref="Student"/> objects that represents the students in <paramref name="pageNumber"/> given the specified <paramref name="pageSize"/>.</returns>
        ICollection<Student> GetAll(int pageSize, int pageNumber);

        /// <summary>
        /// Gets the students enrolled in the course specified by <paramref name="courseId"/>.
        /// </summary>
        /// <param name="courseId">The id of the course to get students for.</param>
        /// <returns>A collection of <see cref="Student"/> objects that represents the students enrolled in the course specified by <paramref name="courseId"/>.</returns>
        ICollection<Student> GetByCourseId(int courseId);

        /// <summary>
        /// Get the <see cref="Student"/> with the specified <paramref name="id"/>
        /// </summary>
        /// <param name="id">The id of the student to get</param>
        /// <returns>a <see cref="Student"/> object that represents the student with the specified <paramref name="id"/>; or <c>null</c> if no record is found.</returns>
        Student GetById(int id);

        /// <summary>
        /// Gets all students with the specified <paramref name="lastName"/>.
        /// </summary>
        /// <param name="lastName">The last name to filter by.</param>
        /// <returns>A collection of <see cref="Student"/> objects that represents all students with the specified <paramref name="lastName"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="lastName"/> is null.</exception>
        ICollection<Student> GetByLastName(string lastName);
    }
}
