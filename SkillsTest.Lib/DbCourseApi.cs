using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillsTest.Lib
{
    public class DbCourseApi : ICourseApi
    {
        public DataContext Db { get; set; }

        public ICollection<Course> GetAll(int pageSize, int pageNumber)
        {
            return Db
                .Courses
                .OrderBy(c => c.Name ?? "" + c.Id)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public Course GetById(int id)
        {
            return Db
                .Courses
                .Where(course => course.Id == id)
                .SingleOrDefault();
        }

        public Course GetByName(string courseName)
        {
            courseName = courseName?.Trim() ?? throw new ArgumentNullException(nameof(courseName));
            
            return Db
                .Courses
                .SingleOrDefault(c => courseName.Equals(c.Name, StringComparison.OrdinalIgnoreCase));
        }
    }
}

