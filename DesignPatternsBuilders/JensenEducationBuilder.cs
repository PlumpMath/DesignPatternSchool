﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsBuilders
{
    public class JensenEducationBuilder : EducationBuilder
    {
        Education _education = new Education();

        //public new void AssignTeacher()
        //{
        //    _education.Teacher = "Asplund";
        //}

        //public new void InviteStudents()
        //{
        //    _education.NumberOfStudents = 400;
        //}

        //public new void ProcessStudentFeedback()
        //{
        //    _education.FeedBack = "Blaha";
        //}
    }
}
