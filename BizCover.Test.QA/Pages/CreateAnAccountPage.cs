using BizCover.Test.QA.Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BizCover.Test.QA.Pages
{
    public class CreateAnAccountPage : BasePage
    {
        private IWebElement FirstName => Driver.FindControl(By.Id("customer_firstname"), true);

        private IWebElement LastName => Driver.FindControl(By.Id("customer_lastname"), true);

        private IWebElement YourPersonalInformationTitle => Driver.FindControl(By.XPath("//form[@id='account-creation-form'/div[1]/h3]"));

        private IWebElement RegisterButton => Driver.FindControl(By.Id("submitAccount"));
        public void AssertCreateAccountPage()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual("Your personal information", YourPersonalInformationTitle.Text);

            });
        }

        public void EnterYourPersonalInformation(string title = null, string firstName = null, string lastName = null)
        {
            FirstName.Clear();
            FirstName.SendKeys(firstName);
            LastName.Clear();
            LastName.SendKeys(lastName);
            RegisterButton.Click();
        }
    }
}
