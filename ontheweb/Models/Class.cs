using System;
using System.Collections.Generic;

namespace ontheweb.Models
{
    public class Classroom
    {
        private string _name;
        private string _subject;
        private Teacher _teacher;
        private List<Student> _students;
        
        public Classroom(string name, string subject, Teacher teacher, List<Student> students)
        {
            _name = name;
            _subject = subject;
            _teacher = teacher;
            _students = students;
        }
        
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        
        public string Subject
        {
            get => _subject;
            set => _subject = value;
        }

        public Teacher Teacher
        {
            get => _teacher;
            set => _teacher = value;
        }

        public List<Student> Students
        {
            get => _students;
            set => _students = value;
        }

        public static List<List<Student>> SplitStudents(List<Student>students)
        {
            List<Student> lamarr = new List<Student>();
            List<Student> giertz = new List<Student>();
            List<List<Student>> groups = new List<List<Student>>();
            foreach (var student in students)
            {
                if (student.ClassId == 1)
                {
                     lamarr.Add(student);
                    
                }else if (student.ClassId == 2)
                {
                    giertz.Add(student);
                }
            }
            groups.Add(lamarr);
            groups.Add(giertz);
            return groups;
        } 
        
        
        
        
        
        
        
        
        
    }
}