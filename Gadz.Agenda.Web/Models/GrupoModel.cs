namespace Gadz.Agenda.Web.Models
{
    public class GrupoModel : Entidade
    {
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
