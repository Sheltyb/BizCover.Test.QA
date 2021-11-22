using BizCover.Test.QA.Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BizCover.Test.QA.Pages
{
    public class MyAccountPage:BasePage
    {
        private IWebElement AccountName => Driver.FindControl(By.XPath("//a[@title='View my customer account']"));
        private IWebElement MyAccountTab => Driver.FindControl(By.XPath("//span[@class='navigation_page']"));

        public void AssertAccountName()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual("Test BizCover", AccountName.Text);
                Assert.AreEqual("My account", MyAccountTab.Text);
            });
        }
    }
}
