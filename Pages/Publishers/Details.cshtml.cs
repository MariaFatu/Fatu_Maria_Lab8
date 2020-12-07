using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Fatu_Maria_Lab8.Data;
using Fatu_Maria_Lab8.Models;

namespace Fatu_Maria_Lab8.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Fatu_Maria_Lab8.Data.Fatu_Maria_Lab8Context _context;

        public DetailsModel(Fatu_Maria_Lab8.Data.Fatu_Maria_Lab8Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);

            if (Publisher == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
