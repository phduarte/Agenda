using System.Collections.Generic;

namespace Gadz.Agenda.Web.Models
{
    public class PerfilModel : Entidade
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public List<GrupoModel> Grupos { get; set; }
        public List<ClienteModel> Clientes { get; set; }
    }
}
