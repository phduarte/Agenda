namespace Gadz.Agenda.Web.Models
{
    public class Usuario : Entidade
    {
        public string Nome { get; private set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public bool Valida()
        {
            return Login.Equals("admin") && Senha.Equals("admi");
        }
    }
}