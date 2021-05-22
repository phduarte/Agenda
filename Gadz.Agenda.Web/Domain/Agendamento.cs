﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Gadz.Agenda.Web.Domain
{
    public class Agendamento : Entidade
    {
        public Tarefa Tarefa { get; set; }
        public Cliente Cliente { get; set; }
        [Display(Name = "Responsável")]
        public Assistente Responsavel { get; set; }
        [Display(Name = "Data de início"), DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }
        [Display(Name = "Data de término")]
        public DateTime DataFim { get; set; }
        public int DuracaoHoras { get; set; }
        public int DuracaoMinutos { get; set; }
        public int PrazoHora { get; set; }
        public int PrazoMinutos { get; set; }
        public string Tipo { get; set; }
        [Display(Name = "Substituição")]
        public string Substituicao { get; set; }
        public string Motivo { get; set; }
    }
}
