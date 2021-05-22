namespace Gadz.Agenda.Web.Models
{
    public class Diagnostico : Entidade
    {
        public string Descricao { get; set; }

        public override string ToString()
        {
            return Descricao;
        }
    }
}