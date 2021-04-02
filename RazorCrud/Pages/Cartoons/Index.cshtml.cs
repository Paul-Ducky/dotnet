using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RAZORCRUD.Models;

namespace RAZORCRUD.Pages_Cartoons
{
    public class IndexModel : PageModel
    {
        private readonly RAZORCRUDCartoonContext _context;

        public IndexModel(RAZORCRUDCartoonContext context)
        {
            _context = context;
        }

        public IList<Cartoon> Cartoon { get;set; }

        public async Task OnGetAsync()
        {
            Cartoon = await _context.Cartoon.ToListAsync();
        }
    }
}
