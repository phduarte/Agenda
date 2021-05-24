using System.ComponentModel.DataAnnotations;

namespace Gadz.Agenda.Domain
{
    public enum StatusTratamento
    {
        Pendente,
        [Display(Name = "Concluído")]
        Concluido,
    }
}