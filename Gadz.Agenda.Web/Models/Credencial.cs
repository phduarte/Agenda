using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Gadz.Agenda.Web.Models
{
    public class Credencial
    {
        [DisplayName("Usuário"), Required, MaxLength(20)]
        public string Login { get; set; }
        [DisplayName("Senha"), Required, MaxLength(10), DataType(DataType.Password)]
        public string Senha { get; set; }

        public bool Valida()
        {
            return Login.Equals("admin") && Senha.Equals("admin");
        }
    }
}