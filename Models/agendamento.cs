using System;

namespace PetShop.Models{
    public class Agendamento{
        public int AgendamentoId { get; set; }
        public DateTime DataAgendamento { get; set; }
        public int Serviços { get; set; }
        public bool Petivery { get; set; }
    }


}