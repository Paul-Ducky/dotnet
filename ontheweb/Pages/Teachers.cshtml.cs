using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.WebEncoders.Testing;
using ontheweb.Models;


namespace ontheweb.Pages
{
    public class TeachersModel : PageModel
    {
        public Teacher _koen;
        public Teacher _tim;
        public List<Teacher> Teachers;
        
        public void OnGet()
        {
            _koen = new Teacher("Koen", 1, 1);
            _tim = new Teacher("Tim", 2, 2);
            Teachers = new List<Teacher>(){ _koen, _tim };
        }
    }
}