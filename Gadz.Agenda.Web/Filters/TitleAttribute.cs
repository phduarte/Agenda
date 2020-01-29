using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;
using ViewResult = Microsoft.AspNetCore.Mvc.ViewResult;

namespace Gadz.Agenda.Web.Filters
{
    public class TitleAttribute : ActionFilterAttribute
    {
        public string Title { get; }

        public TitleAttribute(string title)
        {
            Title = title;
        }

        public override Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            ((ViewResult)context.Result).ViewData.Add("title", Title);
            return base.OnResultExecutionAsync(context, next);
        }
    }
}
