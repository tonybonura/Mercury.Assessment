using System;

namespace SkillsTest.Lib
{
    /// <summary>
    /// Represents a student's enrollment in a course
    /// </summary>
    public class StudentEnrollment
    {
        /// <summary>
        /// The unique identifier of the student enrollment associated with this instance.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The id of the student enrolled in the course.
        /// </summary>
        public int StudentId { get; set; }

        /// <summary>
        /// The id of the course in which the student is enrolled
        /// </summary>
        public int CourseId { get; set; }
    }
}

