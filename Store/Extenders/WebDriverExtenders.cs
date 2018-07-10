using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Store
{
    public static class WebDriverExtenders
    {
        
        public static T GetThisPage<T>(this IWebDriver webDriver) where T : BasePage, new()
        {
            T page = new T();
            webDriver.InitializePage(page);
            return page;
        }       

        public static void NavigateTo(this IWebDriver webDriver, string relativePath)
        {
            Uri pageUri = Utility.GetUri(relativePath);
            webDriver.NavigateToURL(pageUri);
        }

        public static void NavigateToURL(this IWebDriver webDriver, Uri url)
        {
            webDriver.Navigate().GoToUrl(url);
        }

        public static T NavigateToPage<T>(this IWebDriver webDriver)
            where T : BasePage, new()
        {
            T page = new T();
            webDriver.NavigateTo(page.RelativePath);
            webDriver.InitializePage(page);
            return page;
        }

        private static void VerifyPageUrl(this IWebDriver webDriver, string value)
        {
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.UrlMatches(value));
        }

        private static void InitializePage(this IWebDriver webDriver, BasePage page)
        {
            webDriver.InitializeElements(page);
            if (page.RelativePath != null)
            {
                webDriver.VerifyPageUrl(new Uri(Utility.HostUri, page.RelativePath).ToString());
            }
        }
    }
}
