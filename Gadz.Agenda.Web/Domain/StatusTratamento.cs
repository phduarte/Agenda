using System.ComponentModel.DataAnnotations;

namespace Gadz.Agenda.Web.Domain
{
    public enum StatusTratamento
    {
        Pendente,
        [Display(Name = "Concluído")]
        Concluido,
    }
}