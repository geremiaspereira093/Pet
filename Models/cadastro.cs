using System;


namespace PetShop.Models
{
    public class Cadastro
    {
         public int CadastroId { get; set; }
         public string email { get; set; }
         public string NomeTutor { get; set; }
         public long CPF { get; set; }
         public long Telefone{ get; set; }
         public string endereco { get; set; }
         public string NomePet{get;set;}
         public bool Especie { get; set; }
         public string senha  { get; set; }
         public string confirmaSenha { get; set; }



    }
   
    
}