using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PetShop.Models;

namespace PetShop.Pages_Login
{
    public class DeleteModel : PageModel
    {
        private readonly PetShop.Models.PetContext _context;

        public DeleteModel(PetShop.Models.PetContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Login Login { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Login = await _context.Login.FirstOrDefaultAsync(m => m.LoginId == id);

            if (Login == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Login = await _context.Login.FindAsync(id);

            if (Login != null)
            {
                _context.Login.Remove(Login);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
