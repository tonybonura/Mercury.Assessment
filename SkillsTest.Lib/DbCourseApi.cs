using System;
using System.Linq;

namespace SkillsTest.Lib
{
    public class DbCourseApi : ICourseApi
    {
        public DataContext Db { get; set; }

        public Course GetById(int id)
        {
            return Db.Courses.Where(course => course.Id == id).SingleOrDefault();
        }
    }
}

