using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tweakers.Models;

namespace Tweakers.HtmlHelperClasses
{
    public static class HtmlCategoryHelper
    {
        public static string CategoryTree(this HtmlHelper html, List<Category> categories)
        {
            string htmlOutput = string.Empty;

            if (categories.Count() > 0)
            {
                htmlOutput += "<ul>";

                foreach (Category c in categories)
                {
                    htmlOutput += "<li>";
                    htmlOutput += "@Html.ActionLink(" + c.Name + ", " + c.Name + ", \"Categories\"); ";
                    htmlOutput += html.CategoryTree(categories);
                    htmlOutput += "</li>";
                }

                htmlOutput += "</ul>";
            }
            return htmlOutput;
        }
    }
}