using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOpsClassLibrary
{
    public class SchoolFactory
    {
        public Student CreateStudent(string name, string classSection)
        {
            return new Student { Name = name, ClassAndSection = classSection };
        }

        public Teacher CreateTeacher(string name, string classSection)
        {
            return new Teacher { Name = name, ClassAndSection = classSection };
        }

        public Subject CreateSubject(string name, string subjectCode, Teacher teacher)
        {
            return new Subject { Name = name, SubjectCode = subjectCode, Teacher = teacher };
        }
    }
}
