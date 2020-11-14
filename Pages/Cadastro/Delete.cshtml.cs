using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PetShop.Models;

namespace PetShop.Pages_Cadastro
{
    public class DeleteModel : PageModel
    {
        private readonly PetShop.Models.PetContext _context;

        public DeleteModel(PetShop.Models.PetContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Cadastro Cadastro { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cadastro = await _context.Cadastro.FirstOrDefaultAsync(m => m.CadastroId == id);

            if (Cadastro == null)
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

            Cadastro = await _context.Cadastro.FindAsync(id);

            if (Cadastro != null)
            {
                _context.Cadastro.Remove(Cadastro);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
