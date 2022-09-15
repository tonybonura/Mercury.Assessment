using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillsTest.Lib
{
    public interface IStudentApi
    {
        Student GetById(int id);
    }

    public class DbStudentApi : IStudentApi
    {
        public DataContext Db { get; set; }

        public Student GetById(int id)
        {
            return Db.Students.Where(student => student.Id == id).SingleOrDefault();
        }
    }
}
