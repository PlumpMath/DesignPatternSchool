using System;
using DesignPatternsBuilders;
using DesignPatternsSchool;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IEducation = DesignPatternsBuilders.IEducation;

namespace FactoryTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestNumberOfStudentsOnNackademin()
        {
            NackademinEducation education = new NackademinEducation();
            int numberOfStudents = education.NumberOfStudents;

            const int expected = 500;

            var actual = numberOfStudents;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNumberOfStudentsOnJensen()
        {
            JensenEducation education = new JensenEducation();
            int numberOfStudents = education.NumberOfStudents;

            const int expected = 400;

            int actual = numberOfStudents;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestIfTeacherOnTheBuildersAreCorrect()
        {
             // ARRANGE
            var builder = new NackademinEducationBuilder();
            EducationDirector director = new EducationDirector();

            // ACT
            IEducation actual = director.Build(builder);

            // ASSERT
            const string expected = "Mattias";
            Assert.AreEqual(expected, actual.AssignTeacher());
        }
    }
}
