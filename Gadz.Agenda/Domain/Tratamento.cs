using System.ComponentModel.DataAnnotations;

namespace Gadz.Agenda.Domain
{
    public class Tratamento : Entidade
    {
        public string Prazo { get; set; }
        [Display(Name = "Data do Envio")]
        public string DataEnvio { get; set; }
        public Diagnostico Diagnostico { get; set; }
        public StatusTratamento Status { get; set; } = StatusTratamento.Pendente;
        [Display(Name = "Observação")]
        public string Observacao { get; set; }
    }
}
