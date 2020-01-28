using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Gadz.Agenda.Web.Models
{
    public class DefaultValues
    {
        public static List<SelectListItem> Diagnosticos { get; } = new List<SelectListItem>
        {
            new SelectListItem{ Value="1", Text = "Enviado" },
            new SelectListItem{ Value="2", Text = "Falhou no teste" },
            new SelectListItem{ Value="3", Text = "Homologado" },
        };
    }
}
