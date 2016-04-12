using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Razor.TagHelpers;
using Demo7_MVC6.Models;
using Microsoft.Extensions.OptionsModel;

namespace Demo7_MVC6.TagHelpers
{
    [HtmlTargetElement("copyright")]
    public class WebSiteInformation : TagHelper
    {
        public WebSiteInformation(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        private AppSettings _appSettings;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "p";    // Replaces out tag helper with a paragraph tag
            output.Content.SetHtmlContent(
                    $"&copy; {DateTime.Today.Year} - {_appSettings.SiteTitle}"); 


            output.TagMode = TagMode.StartTagAndEndTag;
        }

    }
}
