using BizCover.Test.QA.Core;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BizCover.Test.QA.Pages
{
    public class CreateAnAccountPage : BasePage
    {
        //Personal Information Section
        private IWebElement FirstName => Driver.FindControl(By.Id("customer_firstname"), true);

        private IWebElement LastName => Driver.FindControl(By.Id("customer_lastname"), true);
        private IWebElement Email => Driver.FindControl(By.Id("email"));
        private IWebElement Password => Driver.FindControl(By.Id("passwd"));

        //Your Address Section
        private IWebElement YourPersonalInformationTitle => Driver.FindControl(By.XPath("//form[@id='account-creation-form'/div[1]/h3]"));
        private IWebElement AddressFirstName => Driver.FindControl(By.Id("firstname"));
        private IWebElement AddressLastName => Driver.FindControl(By.Id("lastname"));
        private IWebElement Company => Driver.FindControl(By.Id("company"));

        private IWebElement Address1=> Driver.FindControl(By.Id("address1"));
        private IWebElement Address2 => Driver.FindControl(By.Id("address2"));

        private IWebElement City => Driver.FindControl(By.Id("city"));
        private IWebElement State => Driver.FindControl(By.Id("id_state"));
        private IWebElement PostCode => Driver.FindControl(By.Id("postcode"));
        private IWebElement Country => Driver.FindControl(By.Id("country"));
        

        private IWebElement RegisterButton => Driver.FindControl(By.Id("submitAccount"));

        public void AssertCreateAccountPage()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual("Your personal information", YourPersonalInformationTitle.Text);

            });
        }

        public void EnterYourPersonalInformation(string title = null, string firstName = null, string lastName = null, string email = null, string password = null)
        {
            FirstName.Clear();
            FirstName.SendKeys(firstName);
            LastName.Clear();
            LastName.SendKeys(lastName);
            //Email.Clear();
            //Email.SendKeys(email);
            //Assert.AreEqual(email,Email.Text); //Email should be preset from previous screen
            Password.Clear();
            Password.SendKeys(password);
        }

        public void EnterYourAddressDetails(string firstName = null, string lastName = null, string company = null, string address1 = null, string address2 = null, string city = null, string state = null, string postcode = null, string country = null)
        {
            AddressFirstName.Clear();
            AddressFirstName.SendKeys(firstName);
            AddressLastName.Clear();
            AddressLastName.SendKeys(lastName);
            Company.Clear();
            Company.SendKeys(company);
            Address1.Clear();
            Address1.SendKeys(address1);
            Address2.Clear();
            Address2.SendKeys(address2);
            City.Clear();
            City.SendKeys(city);
            
            //State.Clear();
            State.SendKeys(state);

            PostCode.Clear();
            PostCode.SendKeys(postcode.ToString());
            //Country.Clear();
            Country.SendKeys(country);



        }

        public void ClickCreateAccountButton()
        {
            RegisterButton.Click();
        }

        public void CheckForValidationErrors()
        {

        }
    }
}
