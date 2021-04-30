using System;
using System.Collections.Generic;

namespace SchoolData_NunitTest
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string class_section { get; set; }

        public Student(int id, string name, string class_section)
        {
            this.id = id;
            this.name = name;
            this.class_section = class_section;
        }

        public static bool addstudents(List<Student> students, Student s)
        {
            students.Add(s);
            return true;
        }
        public static bool findbyid(List<Student> students, int id)
        {
            foreach (Student s in students)
            {
                if (s.id.Equals(id))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool findbyname(List<Student> students, string name)
        {
            foreach (Student s in students)
            {
                if (s.name.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool findbyeitherclassorsection(List<Student> students, string class_section)
        {
            foreach (Student s in students)
            {

                if (s.class_section.Contains(class_section))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool deletebyeitherclassorsection(List<Student> students, string class_section)
        {
            foreach (Student s in students)
            {
                if (s.class_section.Contains(class_section))
                {
                    students.Remove(s);
                    return true;
                }
            }
            return false;
        }

    }
}
