using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillsTest.Lib
{
    public class DbStudentApi : IStudentApi
    {
        public DataContext Db { get; set; }

        public ICollection<Student> GetAll(int pageSize, int pageNumber)
        {
            return Db
                .Students
                .OrderBy(s => s.LastName ?? "" + s.Id)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }

        public ICollection<Student> GetByCourseId(int courseId)
        {
            return Db
                .Students
                .Join(Db.Enrollments, s => s.Id, e => e.StudentId, (s, e) => s)
                .ToList();
        }

        public Student GetById(int id)
        {
            return Db
                .Students
                .Where(student => student.Id == id)
                .SingleOrDefault();
        }

        public ICollection<Student> GetByLastName(string lastName)
        {
            lastName = lastName?.Trim() ?? throw new ArgumentNullException(nameof(lastName));

            return Db
                .Students
                .Where(s => lastName.Equals(s.LastName, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
