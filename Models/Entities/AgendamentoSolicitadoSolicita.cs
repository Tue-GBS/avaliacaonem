using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication04.Models.Entities
{
    public class AgendamentoSolicitadoSolicita
    {
        public int Id { get; set; }
        public int QtdeSolicitada { get; set; }
        public DateTime DataHoraDeRetirada { get; set; }
        public DateTime DataHoraEntrega { get; set; }
        public int FkIdUsuario { get; set; }
        public Usuario? Usuario { get; set; }
        public int FkIdUtensilio { get; set; }
        public Utensilio? Utensilio { get; set; }
    }
}