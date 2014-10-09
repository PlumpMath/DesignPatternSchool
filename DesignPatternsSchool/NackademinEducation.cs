using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSchool
{
    public class NackademinEducation : IEducation
    {
        public int NumberOfStudents { get; set; }

        private NackademinEducation _nackademin = new NackademinEducation {NumberOfStudents = 500};
    }
}
