using NUnit.Framework;
using SchoolData_NunitTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolData_NunitTest.Tests
{
    [TestFixture()]
    public class StudentTests
    {

        List<Student> students = new List<Student>();
        [SetUp]
        public void Setup()
        {
        }
        [Test()]
        public void addstudentsTest()
        {
            Student s = new Student(001, "Harshit Pradhan", "10 A");
            bool result = Student.addstudents(students, s);
            Assert.AreEqual(result, true);
        }

        [Test()]
        [TestCase(001, ExpectedResult = true)]
        public bool findbyidTest(int id)
        {
            bool result = Student.findbyid(students, id);
            return result;
        }

        [Test()]
        [TestCase("Harshit Pradhan", ExpectedResult = true)]
        public bool findbynameTest(string name)
        {
            bool result = Student.findbyname(students, name);
            return result;
        }

        [Test()]
        [TestCase("A", ExpectedResult = true)]
        public bool findbyeitherclassorsectionTest(string class_section)
        {
            bool result = Student.findbyeitherclassorsection(students, class_section);
            return result;
        }

    }
}