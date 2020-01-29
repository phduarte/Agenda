using System.ComponentModel.DataAnnotations.Schema;

namespace Gadz.Agenda.Web.Models
{
    [Table("funcionarios")]
    public class AssistenteModel : Usuario
    {
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}