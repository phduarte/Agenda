using System;
using System.ComponentModel.DataAnnotations;

namespace Gadz.Agenda.Web.Domain
{
    public class Tarefa : Entidade
    {
        [MaxLength(50)]
        public string Nome { get; set; }
        [Display(Name = "Data de solicitação"), DataType(DataType.DateTime)]
        public DateTime DataSolicitacao { get; set; }
        [Display(Name = "Observação")]
        public string Observacao { get; set; }
        public Categoria Categoria { get; set; }
        public Funcionario Responsavel { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
