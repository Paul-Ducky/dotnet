using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.WebEncoders.Testing;
using ontheweb.Models;


namespace ontheweb.Pages
{
    public class StudentsModel : PageModel
    {
        public List<Student> StudentList;
        
        public void OnGet()
        {
            StudentList = Student.CreateStudents();
        }

    }
}