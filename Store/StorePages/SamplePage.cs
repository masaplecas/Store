using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Store
{
    public class SamplePage : BaseAppPage
    {
        #region Fields

        [FindsBy(How = How.Id, Using = "comment")]
        private IWebElement commentText;

        [FindsBy(How = How.Id, Using = "author")]
        private IWebElement authorName;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement email;

        [FindsBy(How = How.Id, Using = "url")]
        private IWebElement website;

        [FindsBy(How = How.Id, Using = "submit")]
        private IWebElement postCommentButton;


        #endregion

        #region Ctor

        public SamplePage() : base("/sample-page")
        {
           
        }

        #endregion

        #region Properties

        public string CommentText
        {
            get { return commentText.GetValue(); }
            set
            {
                commentText.SetText(value);
            }
        }

        public string Author
        {
            get
            {
                return authorName.GetValue();

            }
            set
            {
                authorName.SetText(value);
            }
        }

        public string Email
        {
            get { return email.GetValue(); }
            set
            {
               email.SetText(value);
            }
        }

        public string Website
        {
            get { return website.GetValue(); }
            set
            {
               website.SetText(value);
            }
        }


        #endregion

        #region Methods

        public void ClickOnPostComment()
        {
            postCommentButton.Click();
        }

        public bool CommentHasBeenPosted(string author, string commentText)
        {
            IReadOnlyCollection<IWebElement> commentBoxes = Driver.FindElements(By.CssSelector(".comment_container.group"));

            foreach (IWebElement commentBox in commentBoxes)
            {
                IWebElement commentBody = commentBox.FindElement(By.ClassName("comment-body"));
                if (commentBody.Text.Equals(commentText))
                {
                    string authorName=commentBox.FindElement(By.CssSelector(".comment-author.vcard")).Text;
                    if (authorName.Equals(author))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool UrlContainsComment()
        {
            if (Driver.Url.Contains("#comment-"))
            {
                return true;
            }
            return false;
        }
           

        #endregion

    }
}
