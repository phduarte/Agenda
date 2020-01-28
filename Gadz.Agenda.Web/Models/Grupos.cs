using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Gadz.Agenda.Web.Models
{
    public class Grupos
    {
        public List<SelectListItem> Lista { get; set; } = new List<SelectListItem>
        {
            new SelectListItem{Value="1", Text="Planejamento"},
            new SelectListItem{Value="2", Text="Operação"},
            new SelectListItem{Value="3", Text="Qualidade"},
        };
    }
}
