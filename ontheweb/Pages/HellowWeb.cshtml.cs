using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ontheweb.Models;


namespace ontheweb.Pages
{
    public class HellowWebModel : PageModel
    {
        public string Message { get; set; } = "In page model: ";
        public string[] Names =
        {
           "Sicco", "Randy", "Kyle", "Cartman", "Kenny", "Sarah", "Rogers", "Stan", "Token", "Clyde", "Manbearpig"
        };
        public List<Student> CreateStudents()
        {
            List<Student> Students = new List<Student>();
            for (uint i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    uint classid = 1;
                    Students.Add(new Student(i, Names[i], classid));
                }
                else
                {
                    uint classid = 2;
                    Students.Add(new Student(i, Names[i], classid));
                }
                
            }
            return Students;
        }
        
        public void OnGet()
        {
            
        }
    }
}