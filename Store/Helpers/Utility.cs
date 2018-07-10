using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Store
{
    public static class Utility
    {
        public static IWebDriver Driver { get;  private set; }
        public static Uri HostUri { get; private set; }
        public static bool DriverIsStarted { get; private set; }

        public static void StartChromeDriver(Uri hostUri)
        {
            Driver= new ChromeDriver();
            DriverIsStarted = true;
            HostUri = hostUri;
            Driver.Manage().Window.Maximize();
                
        }

        public static void Quit()
        {
            Driver.Quit();
            DriverIsStarted = false;
        }

        public static Uri GetUri(string relativePath)
        {
            return new Uri(HostUri, new Uri(relativePath, UriKind.Relative));
        }
        public static T NavigateToPage<T>()
            where T : BasePage, new()
        {
            return Driver.NavigateToPage<T>();
        }

        public static T GetThisPage<T>() where T : BasePage, new()
        {
            return Driver.GetThisPage<T>();
        }

    }
}
