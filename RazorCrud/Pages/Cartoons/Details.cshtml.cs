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
    public class DetailsModel : PageModel
    {
        private readonly RAZORCRUDCartoonContext _context;

        public DetailsModel(RAZORCRUDCartoonContext context)
        {
            _context = context;
        }

        public Cartoon Cartoon { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cartoon = await _context.Cartoon.FirstOrDefaultAsync(m => m.Id == id);

            if (Cartoon == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
