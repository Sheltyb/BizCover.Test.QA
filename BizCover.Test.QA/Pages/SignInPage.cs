using BizCover.Test.QA.Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BizCover.Test.QA.Pages
{
    public class SignInPage : BasePage
    {
        private IWebElement Email => Driver.FindControl(By.Id("email"), true);

        private IWebElement Password => Driver.FindControl(By.Id("passwd"));

        private IWebElement LoginButton => Driver.FindControl(By.Id("SubmitLogin"));

        private IWebElement CreateAnAccountEmail => Driver.FindControl(By.Id("email_create"), true);

        private IWebElement CreateAnAccountButton => Driver.FindControl(By.Id("SubmitCreate"));

        private IWebElement CreateAnAccountTitle => Driver.FindControl(By.XPath("//form[@id='create-account_form']/h3"));
        
        public void AssertSignInPage()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual("CREATE AN ACCOUNT", CreateAnAccountTitle.Text);
 
            });
        }
        public void SignIn(string email = null, string password = null)
        {
            Email.Clear();
            Email.SendKeys(email);
            Password.Clear();
            Password.SendKeys(password);
            LoginButton.Click();
        }

        public void CreateAnAccount(string email = null)
        {
            CreateAnAccountEmail.Clear();
            CreateAnAccountEmail.SendKeys(email);
            CreateAnAccountButton.Click();
        }
    }
}
