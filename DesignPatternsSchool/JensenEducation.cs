using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSchool
{
    public class JensenEducation : IEducation
    {
        public int NumberOfStudents { get; set; }

        private JensenEducation _jensen = new JensenEducation {NumberOfStudents = 400};
    }
}
