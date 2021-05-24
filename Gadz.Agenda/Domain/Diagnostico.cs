namespace Gadz.Agenda.Web.Domain
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