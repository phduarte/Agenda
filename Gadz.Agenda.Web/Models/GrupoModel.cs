using System.ComponentModel.DataAnnotations.Schema;

namespace Gadz.Agenda.Web.Models
{
    [Table("grupos")]
    public class GrupoModel : Entidade
    {
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
