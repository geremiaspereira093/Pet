using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PetShop.Models;

namespace PetShop.Pages_Agendamento
{
    public class DetailsModel : PageModel
    {
        private readonly PetShop.Models.PetContext _context;

        public DetailsModel(PetShop.Models.PetContext context)
        {
            _context = context;
        }

        public Agendamento Agendamento { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Agendamento = await _context.Agendamento.FirstOrDefaultAsync(m => m.AgendamentoId == id);

            if (Agendamento == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
