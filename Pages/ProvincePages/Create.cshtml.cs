using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CommunityApp.Data;

namespace CommunityApp.Pages_ProvincePages
{
    public class CreateModel : PageModel
    {
        private readonly CommunityApp.Data.ApplicationDbContext _context;

        public CreateModel(CommunityApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Province Province { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Provinces.Add(Province);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
