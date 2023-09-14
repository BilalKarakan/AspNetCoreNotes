using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Mvc.TagHelpers
{
    [HtmlTargetElement("description")]
    public class DescriptionTagHelper : TagHelper
    {
        public string FontType { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Content.SetHtmlContent($"<mark> Custom Tag Helper Works : {FontType} </mark>");
        }
    }
}
