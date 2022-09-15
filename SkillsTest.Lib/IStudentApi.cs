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
}
