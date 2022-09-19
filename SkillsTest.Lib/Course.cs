using System;

namespace SkillsTest.Lib
{
    /// <summary>
    /// Represents a course available for students to enroll in.
    /// </summary>
    public class Course
    {
        /// <summary>
        /// The unique identifier of the course associated with this instance.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the course associated with this instance.
        /// </summary>
        public String Name { get; set; }
    }
}