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
    }
}
