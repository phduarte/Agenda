using System.ComponentModel.DataAnnotations;

namespace Gadz.Agenda.Web.Models
{
    public class NovaSenhaModel : Credencial
    {
        [Display(Name="Nova senha"), Required, DataType(DataType.Password), MaxLength(20)]
        public string NovaSenha { get; set; }
    }
}
