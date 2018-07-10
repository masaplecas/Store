using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Store
{
    public class BaseComponent
    {
        public IWebDriver Driver
        {
            get { return Utility.Driver; }
        }
    }
}
