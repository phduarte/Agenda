using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Gadz.Agenda.Web.Models
{
    public class Clientes
    {
        public static List<SelectListItem> Lista { get; } = new List<SelectListItem>
            {
                new SelectListItem{ Value="1", Text="TIM"},
                new SelectListItem{ Value="2", Text="NEXTEL"},
                new SelectListItem{ Value="3", Text="OI"},
            };
    }
}
