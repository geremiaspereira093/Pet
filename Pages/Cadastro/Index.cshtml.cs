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
    public class IndexModel : PageModel
    {
        private readonly PetShop.Models.PetContext _context;

        public IndexModel(PetShop.Models.PetContext context)
        {
            _context = context;
        }

        public IList<Cadastro> Cadastro { get;set; }

        public async Task OnGetAsync()
        {
            Cadastro = await _context.Cadastro.ToListAsync();
        }
    }
}
