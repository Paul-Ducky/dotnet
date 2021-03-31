using System.Collections.Generic;
using System;

namespace ontheweb.Models
{
    public class Student
    {
        private uint _id;
        private string _name;
        private uint _classId;

        public uint Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public uint ClassId
        {
            get => _classId;
            set => _classId = value;
        }

        public Student(uint id, string name, uint classId)
        {
            _id = id;
            _name = name;
            _classId = classId;
        }
        
        public static string Message { get; set; } = "In page model: ";
        
        public static string[] Names =
        {
            "Sicco", "Randy", "Kyle", "Cartman", "Kenny", "Sarah", "Rogers", "Stan", "Token", "Clyde", "Manbearpig"
        };
        
        public static List<Student> CreateStudents()
        {
            List<Student> students = new List<Student>();
            for (uint i = 1; i < Names.Length; i++)
            {
                if (i % 2 == 0)
                {
                    uint classid = 1;
                    students.Add(new Student(i, Names[i], classid));
                }
                else
                {
                    uint classid = 2;
                    students.Add(new Student(i, Names[i], classid));
                }
                
            }
            return students;
        }
        
    }
}