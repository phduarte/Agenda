using System.Collections.Generic;

namespace Gadz.Agenda.Web.Domain
{
    public class Perfil : Entidade
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public List<Categoria> Categorias { get; set; }
        public List<Cliente> Clientes { get; set; }
    }
}
