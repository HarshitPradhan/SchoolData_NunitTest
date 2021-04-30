using NUnit.Framework;
using SchoolData_NunitTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolData_NunitTest.Tests
{
    [TestFixture()]
    public class TeacherTests
    {
        List<Teacher> teachers = new List<Teacher>();

        [Test()]
        public void addteacherTest()
        {
            Teacher s = new Teacher(001, "Lalit Kane", "3,4,5");
            bool result = Teacher.addteacher(teachers, s);
            Assert.AreEqual(result, true);
        }

        [Test()]
        [TestCase(001, ExpectedResult = true)]
        public bool findbyidTest(int id)
        {
            bool result = Teacher.findbyid(teachers, id);
            return result;
        }

        [Test()]
        [TestCase("Lalit Kane", ExpectedResult = true)]
        public bool findbynameTest(string name)
        {
            bool result = Teacher.findbyname(teachers, name);
            return result;
        }

        [Test()]
        [TestCase("4", ExpectedResult = true)]
        public bool findbyclassestaughtTest(string classestaught)
        {
            bool result = Teacher.findbyclassestaught(teachers, classestaught);
            return result;
        }
    }
}