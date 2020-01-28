using System;
using System.ComponentModel.DataAnnotations;

namespace Gadz.Agenda.Web.Models
{
    public class TarefaModel : Entidade
    {
        [MaxLength(50)]
        public string Nome { get; set; }
        [Display(Name = "Data de solicitação"), DataType(DataType.DateTime)]
        public DateTime DataSolicitacao { get; set; }
        [Display(Name = "Observação")]
        public string Observacao { get; set; }
        public string Grupo { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
