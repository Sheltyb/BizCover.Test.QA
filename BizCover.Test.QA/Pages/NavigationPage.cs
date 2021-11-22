using BizCover.Test.QA.Core;
using OpenQA.Selenium;
using System.Configuration;

namespace BizCover.Test.QA.Pages
{
    public class NavigationPage : BasePage
    {
        public void NavigateToHomePage()
        {
            Driver.Navigate().GoToUrl(ConfigSettings.TestCaseURL);
        }

        private IWebElement SignInButton => Driver.FindControl(By.XPath("//a[@class='login']"));

        public void NavigateToLoginPage()
        {
            SignInButton.Click();
        }
    }
}
