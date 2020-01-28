using System.ComponentModel.DataAnnotations;

namespace Gadz.Agenda.Web.Models
{
    public class PedidoRecuperacaoSenhaModel
    {
        [Display(Name = "Usuário"), Required]
        public string Usuario { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
