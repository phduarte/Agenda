using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace Gadz.Agenda.Web.TagHelpers
{
    [HtmlTargetElement("email")]
    public class EmailTagHelper : TagHelper
    {
        public string To { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";                                 // Replaces <email> with <a> tag
            var content = await output.GetChildContentAsync();
            var name = content.GetContent();
            output.Attributes.SetAttribute("href", $"mailto:{To}@gadesi.com.br");
            output.Content.SetContent(name);
        }
    }
}
