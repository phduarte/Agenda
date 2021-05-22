using System.ComponentModel.DataAnnotations.Schema;

namespace Gadz.Agenda.Web.Domain
{
    public class Grupo : Entidade
    {
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
