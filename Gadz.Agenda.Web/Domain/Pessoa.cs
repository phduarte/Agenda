namespace Gadz.Agenda.Web.Domain
{
    public class Pessoa : Entidade
    {
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
