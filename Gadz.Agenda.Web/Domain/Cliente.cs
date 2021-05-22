namespace Gadz.Agenda.Web.Models
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