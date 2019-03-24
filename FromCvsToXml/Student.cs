using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FromCvsToXml
{
    [Serializable]
    public class Student
    {
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string univercity { get; set; }
        public string faculty { get; set; }
        public int course { get; set; }
        public string department { get; set; }
        public int group { get; set; }
        public string city { get; set; }
        public int age { get; set; }

        public Student()
        {

        }

    //Создаем конструктор
    public Student(string firstName, string lastName, string univercity, string faculty, string department, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.univercity = univercity;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }

        public override string ToString()
        {
            return String.Format("{0,15}{1,15}{2,15}{3,15}{4,15}{5,15}{6,15}{7,5}{8,10}", firstName, lastName, univercity, faculty, department, age, course, group, city);
        }
    }
}
