using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Store
{
    public static class WebElementExtenders
    {
        public static string GetValue(this IWebElement webElement)
        {
            return webElement.GetAttribute("value");
        }

        public static void SetText(this IWebElement webElement, string text)
        {
            webElement.Clear();
            webElement.SendKeys(text);
        }
    }
}
