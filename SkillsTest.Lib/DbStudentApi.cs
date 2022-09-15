using System;
using System.Linq;

namespace SkillsTest.Lib
{
    public class DbStudentApi : IStudentApi
    {
        public DataContext Db { get; set; }

        public Student GetById(int id)
        {
            return Db.Students.Where(student => student.Id == id).SingleOrDefault();
        }
    }
}
