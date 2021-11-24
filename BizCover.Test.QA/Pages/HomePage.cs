using BizCover.Test.QA.Core;
using OpenQA.Selenium;
using System.Configuration;

namespace BizCover.Test.QA.Pages
{
    public class HomePage : BasePage
    {

        private IWebElement SignInButton => Driver.FindControl(By.XPath("//a[@class='login']"));

        public void NavigateToSignInPage()
        {
            SignInButton.Click();
        }
    }
}
