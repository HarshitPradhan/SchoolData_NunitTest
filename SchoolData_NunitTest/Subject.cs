using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolData_NunitTest
{
    public class Subject
    {
        public int id { get; set; }
        public string name { get; set; }
        public Subject(int id, string name)
        {
            this.name = name;
            this.id = id;

        }
        public static bool addsubject(List<Subject> subjects, Subject s)
        {
            subjects.Add(s);
            return true;
        }
        public static bool findsubjectbyid(List<Subject> subjects, int id)
        {
            foreach (Subject s in subjects)
            {
                if (s.id == id)
                    return true;
            }
            return false;
        }
        public static bool findsubjectbyname(List<Subject> subjects, string id)
        {
            foreach (Subject s in subjects)
            {
                if (s.name.Equals(id))
                    return true;
            }
            return false;
        }
    }
}
