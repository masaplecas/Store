using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Store
{
    public static class SearchContextExtenders
    {
        public static void InitializeElements(this ISearchContext searchContext, object page)
        {
            PageFactory.InitElements(searchContext, page);
        }

    }
}
