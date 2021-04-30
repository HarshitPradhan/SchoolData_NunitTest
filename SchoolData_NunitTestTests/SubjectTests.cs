using NUnit.Framework;
using SchoolData_NunitTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolData_NunitTest.Tests
{
    [TestFixture()]
    public class SubjectTests
    {

        List<Subject> subjects = new List<Subject>();
        [Test()]
        public void addsubjectTest()
        {
            Subject s = new Subject(001, "Maths");
            bool result = Subject.addsubject(subjects, s);
            Assert.AreEqual(result, true);
        }

        [Test()]
        [TestCase(001, ExpectedResult = true)]
        public bool findsubjectbyidTest(int id)
        {
            bool result = Subject.findsubjectbyid(subjects, id);
            return result;
        }

        [Test()]
        [TestCase("Maths", ExpectedResult = true)]
        public bool findsubjectbynametest(string name)
        {
            bool result = Subject.findsubjectbyname(subjects, name);
            return result;
        }
    }
}