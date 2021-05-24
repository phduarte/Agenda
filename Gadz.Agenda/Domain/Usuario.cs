namespace Gadz.Agenda.Web.Domain
{
    public class Usuario : Pessoa
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public bool Valida()
        {
            return Login.Equals("admin") && Senha.Equals("admi");
        }
    }
}