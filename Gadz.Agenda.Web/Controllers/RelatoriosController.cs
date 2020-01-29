using Gadz.Agenda.Web.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Gadz.Agenda.Controllers
{
    public class RelatoriosController : Controller
    {
        [Breadcrumb("Relatórios")]
        public IActionResult Index()
        {
            return View();
        }

        [Breadcrumb("Acompanhamento de SLAs")]
        public IActionResult AcompanhamentoSLA()
        {
            return View();
        }

        [Breadcrumb("Comparativo de ocupação")]
        public IActionResult ComparativoOcupacao()
        {
            return View();
        }

        [Breadcrumb("Cumprimento de SLAs")]
        public IActionResult CumprimentoSLAs()
        {
            return View();
        }

        [Breadcrumb("Dashboard")]
        public IActionResult DashboardSLAs()
        {
            return View();
        }

        [Breadcrumb("Demandas por funcionário")]

        public IActionResult DemandasFuncionario()
        {
            return View();
        }

        [Breadcrumb("Entregas por cliente")]
        public IActionResult EntregasMISCliente()
        {
            return View();
        }

        [Breadcrumb("Entregas dentro do prazo")]
        public IActionResult EntregaDentroPrazo()
        {
            return View();
        }

        [Breadcrumb("Evolução da aderência")]
        public IActionResult EvolucaoAderencia()
        {
            return View();
        }

        [Breadcrumb("Gantt")]
        public IActionResult Gantt()
        {
            return View();
        }

        [Breadcrumb("Motivos de atrasos")]

        public IActionResult MotivosAtraso()
        {
            return View();
        }

        [Breadcrumb("Status das entregas")]

        public IActionResult StatusEntregas()
        {
            return View();
        }

        [Breadcrumb("Timeline")]
        public IActionResult TimeLine()
        {
            return View();
        }
    }
}