using System.ComponentModel.DataAnnotations;

namespace Gadz.Agenda.Web.Models
{
    public class Tratamento : Entidade
    {
        public string Prazo { get; set; }
        [Display(Name = "Data do Envio")]
        public string DataEnvio { get; set; }
        public Diagnostico Diagnostico { get; set; }
        public StatusTratamento Status { get; set; }
        [Display(Name = "Observação")]
        public string Observacao { get; set; }
    }
}
