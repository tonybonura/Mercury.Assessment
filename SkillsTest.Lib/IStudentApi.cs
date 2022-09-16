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
        /// Get the <see cref="Student"/> with the specified <paramref name="id"/>
        /// </summary>
        /// <param name="id">The id of the student to get</param>
        /// <returns>a <see cref="Student"/> object that represents the student with the specified <paramref name="id"/>; or <c>null</c> if no record is found.</returns>
        Student GetById(int id);
    }
}
