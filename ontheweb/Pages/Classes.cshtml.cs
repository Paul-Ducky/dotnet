using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.WebEncoders.Testing;
using ontheweb.Models;


namespace ontheweb.Pages
{
    public class ClassesModel : PageModel
    {
        public List<Student> StudentList;
        public Teacher _koen;
        public Teacher _tim;
        public List<Teacher> Teachers;
        public Classroom Lamarr;
        public Classroom Giertz;
        public List<Classroom> Classrooms;

        public void OnGet()
        {
            StudentList = Student.CreateStudents();
            _koen = new Teacher("Koen", 1, 1);
            _tim = new Teacher("Tim", 2, 2);
            Teachers = new List<Teacher>(){_koen,_tim};
            Lamarr = new Classroom("Lamarr", "webdev", _koen, Classroom.SplitStudents(StudentList)[0]);
            Giertz = new Classroom("Giertz", "TBD", _tim, Classroom.SplitStudents(StudentList)[1]);
            Classrooms = new List<Classroom>() {Lamarr, Giertz};
            
        }

    }
}