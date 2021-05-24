namespace Gadz.Agenda.Domain
{
    public class Categoria : Entidade
    {
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
