using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Less_11.Views.Helpers
{
    public static class ListHelper
    {
        public static MvcHtmlString CreateList(this HtmlHelper html, List<int> items)
        {
            TagBuilder ul = new TagBuilder("ul");
            foreach (int item in items)
            {
                TagBuilder li = new TagBuilder("li");
                li.SetInnerText(item.ToString());
                ul.InnerHtml += li.ToString();
            }
            return new MvcHtmlString(ul.ToString());
        }

    }
}