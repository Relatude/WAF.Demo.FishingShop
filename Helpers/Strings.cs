using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FrameworkMVCRazor.Helpers
{

    public static class Strings
    {
        public static HtmlString HtmlString(this IHtmlHelper helper, string encodedString)
        {
            return new HtmlString(encodedString);
        }
    }

}