using Microsoft.EntityFrameworkCore;

namespace PetShop.Models
{
    public class PetContext : DbContext
    {
        public PetContext(DbContextOptions<PetContext> options)
            : base(options)
        {

        }
        public DbSet<Login> Login {get;set;}
        public DbSet<Agendamento> Agendamento{get;set;}     
        public DbSet<Cadastro> Cadastro{get;set;}
        
        public int MyProperty { get; set; }
    }

}