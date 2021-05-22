using System;
using System.ComponentModel.DataAnnotations;

namespace Gadz.Agenda.Web.Models
{
    public class Tarefa : Entidade
    {
        [MaxLength(50)]
        public string Nome { get; set; }
        [Display(Name = "Data de solicitação"), DataType(DataType.DateTime)]
        public DateTime DataSolicitacao { get; set; }
        [Display(Name = "Observação")]
        public string Observacao { get; set; }
        public string Grupo { get; set; }
        public string Responsavel { get; set; }
        public int ResponsavelId { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
