using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Store
{
    public class CommentErrorPage: BasePage
    {
        #region Fields

        [FindsBy(How = How.CssSelector, Using = "#error-page p:nth-child(2)")]
        private IWebElement errorText;

        [FindsBy(How = How.LinkText, Using = "« Back")]
        private IWebElement backLink;

        #endregion

        #region Ctor

        public CommentErrorPage() : base("/wp-comments-post.php")
        {

        }

        #endregion

        #region Properties

        public string ErrorText
        {
            get { return errorText.Text; }
        }


        #endregion

        #region Methods

        public bool ErrorMessageIsCorrect()
        {
            if (ErrorText.Equals("ERROR: please enter a valid email address."))
            {
                return true;
            }
            return false;
        }

        public SamplePage ClickOnBack()
        {
            backLink.Click();
            return new SamplePage();
        }
        #endregion
    }
}
