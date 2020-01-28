using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Gadz.Agenda.Web.Models
{
    public class Tarefas
    {
        public static List<SelectListItem> Lista { get; set; } = new List<SelectListItem>
        {
            new SelectListItem{ Value="1", Text="Enviar arquivo mensal"},
            new SelectListItem{ Value="2", Text="Enviar resultado diário"},
            new SelectListItem{ Value="3", Text="Validar informações do cliente"},
        };
    }
}
