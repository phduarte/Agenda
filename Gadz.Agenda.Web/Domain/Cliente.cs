namespace Gadz.Agenda.Web.Domain
{
    public class Cliente : Entidade
    {
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}