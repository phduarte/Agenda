using Microsoft.AspNetCore.Mvc.Filters;

namespace Gadz.Agenda.Web.Filters
{
    public class BreadcrumbAttribute : ActionFilterAttribute
    {
        public string Previous { get; }
        public string Current { get; }

        public BreadcrumbAttribute(string current, string previous = "")
        {
            Current = current;
            Previous = previous;
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            string route = $"{Previous} > {Current}";
            if (string.IsNullOrEmpty(Previous))
            {
                route = Current;
            }

            context.HttpContext.Items.Add("breadcrumb", route);
        }
    }
}
