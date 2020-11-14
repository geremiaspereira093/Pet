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
    public class IndexModel : PageModel
    {
        private readonly PetShop.Models.PetContext _context;

        public IndexModel(PetShop.Models.PetContext context)
        {
            _context = context;
        }

        public IList<Agendamento> Agendamento { get;set; }

        public async Task OnGetAsync()
        {
            Agendamento = await _context.Agendamento.ToListAsync();
        }
    }
}
