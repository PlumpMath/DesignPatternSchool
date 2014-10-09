using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBuilders
{
    public interface IEducation
    {
        void AssignTeacher();
        void InviteStudents();
        void ProcessStudentFeedback();
    }
}
