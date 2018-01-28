namespace Gadz.Agenda.Web.Models {
    public class Credencial : ICredencial {

        public string Login { get; set; }
        public string Senha { get; set; }

        public bool Valida() {
            return Login.Equals("admin") && Senha.Equals("admin");
        }
    }
}
