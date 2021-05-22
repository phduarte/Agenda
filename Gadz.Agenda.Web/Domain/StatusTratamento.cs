using System.ComponentModel.DataAnnotations;

namespace Gadz.Agenda.Web.Models
{
    public enum StatusTratamento
    {
        Pendente,
        [Display(Name = "Concluído")]
        Concluido,
    }
}