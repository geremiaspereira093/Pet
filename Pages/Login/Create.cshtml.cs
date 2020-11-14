using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PetShop.Models;

namespace PetShop.Pages_Login
{
    public class CreateModel : PageModel
    {
        private readonly PetShop.Models.PetContext _context;

        public CreateModel(PetShop.Models.PetContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Login Login { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Login.Add(Login);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
