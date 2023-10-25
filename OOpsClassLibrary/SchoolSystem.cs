using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOpsClassLibrary
{
    public class SchoolSystem
    {
        private static SchoolSystem instance;
        public List<Student> Students { get; } = new List<Student>();
        public List<Teacher> Teachers { get; } = new List<Teacher>();
        public List<Subject> Subjects { get; } = new List<Subject>();



      


        private SchoolSystem() { }

        public static SchoolSystem GetInstance()
        {
            if (instance == null)
            {
                instance = new SchoolSystem();
            }
            return instance;
        }
    }
}
