using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBuilders
{
    public class EducationDirector
    {
        private readonly EducationBuilder _educationBuilder;

        public IEducation Build(EducationBuilder builder)
        {
            _educationBuilder.AssignTeacher();
            _educationBuilder.InviteStudents();
            _educationBuilder.ProcessStudentFeedback();

            return _educationBuilder;
        }
    }
}
