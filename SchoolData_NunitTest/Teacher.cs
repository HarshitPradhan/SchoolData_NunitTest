using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolData_NunitTest
{
    public class Teacher
    {
        public int id { get; set; }
        public string name { get; set; }
        public string classestaught { get; set; }

        public Teacher(int id, string name, string classestaught)
        {
            this.id = id;
            this.name = name;
            this.classestaught = classestaught;
        }

        public static bool addteacher(List<Teacher> teachers, Teacher t)
        {
            teachers.Add(t);
            return true;
        }
        public static bool findbyid(List<Teacher> teachers, int id)
        {
            foreach (Teacher s in teachers)
            {
                if (s.id.Equals(id))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool findbyname(List<Teacher> teachers, string name)
        {
            foreach (Teacher s in teachers)
            {
                if (s.name.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool findbyclassestaught(List<Teacher> teachers, string classestaught)
        {
            foreach (Teacher s in teachers)
            {

                if (s.classestaught.Contains(classestaught))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
