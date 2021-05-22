using System.ComponentModel.DataAnnotations.Schema;

namespace Gadz.Agenda.Web.Domain
{
    [Table("funcionarios")]
    public class Assistente : Usuario
    {
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}