using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBuilders
{
    public class EducationBuilder : IEducation
    {
        public Education Education { get; set; }

        public void AssignTeacher()
        {            
            NackademinEducationBuilder nackademinEducation = new NackademinEducationBuilder();
            nackademinEducation.AssignTeacher();

            JensenEducationBuilder jensenEducation = new JensenEducationBuilder();
            jensenEducation.AssignTeacher();
        }

        public void InviteStudents()
        {
            NackademinEducationBuilder nackademinEducation = new NackademinEducationBuilder();
            nackademinEducation.InviteStudents();

            JensenEducationBuilder jensenEducation = new JensenEducationBuilder();
            jensenEducation.InviteStudents();
        }

        public void ProcessStudentFeedback()
        {
            NackademinEducationBuilder nackademinEducation = new NackademinEducationBuilder();
            nackademinEducation.ProcessStudentFeedback();

            JensenEducationBuilder jensenEducation = new JensenEducationBuilder();
            jensenEducation.ProcessStudentFeedback();
        }
    }
}
