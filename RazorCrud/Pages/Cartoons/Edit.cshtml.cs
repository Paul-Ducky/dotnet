using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RAZORCRUD.Models;

namespace RAZORCRUD.Pages_Cartoons
{
    public class EditModel : PageModel
    {
        private readonly RAZORCRUDCartoonContext _context;

        public EditModel(RAZORCRUDCartoonContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cartoon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CartoonExists(Cartoon.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CartoonExists(int id)
        {
            return _context.Cartoon.Any(e => e.Id == id);
        }
    }
}
