using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetShop.Models;

namespace PetShop.Pages_Cadastro
{
    public class EditModel : PageModel
    {
        private readonly PetShop.Models.PetContext _context;

        public EditModel(PetShop.Models.PetContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Cadastro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CadastroExists(Cadastro.CadastroId))
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

        private bool CadastroExists(int id)
        {
            return _context.Cadastro.Any(e => e.CadastroId == id);
        }
    }
}
