using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Store;

namespace Store
{
    public class FooterMenu: BaseComponent
    {
        #region Fields

        [FindsBy(How = How.LinkText, Using = "Sample Page")]
        private IWebElement samplePageLink;

        #endregion

        #region Methods

        public SamplePage ClickOnSamplePageLink()
        {
            samplePageLink.Click();
            return new SamplePage();
        }
        

        #endregion


    }
}
