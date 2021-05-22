namespace Gadz.Agenda.Web.Models
{
    public class ClienteModel : Entidade
    {
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}