using System;
using System.Collections.Generic;

namespace SkillsTest.Lib
{
    /// <summary>
    /// Represents a student that can be enrolled in courses.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The unique identifier of the student associated with this instance.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The last name of the student associated with this instance.
        /// </summary>
        public String LastName { get; set; }

        /// <summary>
        /// The first name of the student associated with this instance.
        /// </summary>
        public String FirstName { get; set; }

        /// <summary>
        /// The email address of the student associated with this instance.
        /// </summary>
        public String Email { get; set; }

        /// <summary>
        /// The list of courses in which the student associated with this instance is enrolled.
        /// </summary>
        public virtual ICollection<Course> Courses { get; set; }
    }
}