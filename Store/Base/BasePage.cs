using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace Store
{
    public class BasePage : BaseComponent
    {
        public string RelativePath { get; protected set; }

        public string Title
        {
            get
            {
                return Driver.Title;
            }


        }
        public string Url
        {
            get
            {
                return Driver.Url;
            }
        }
     


        protected BasePage(string relativePath)
        {
            Driver.InitializeElements(this);
            RelativePath = relativePath;

        }

       

    }
}
