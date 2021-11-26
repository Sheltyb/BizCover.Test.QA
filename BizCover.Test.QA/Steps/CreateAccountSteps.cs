using BizCover.Test.QA.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BizCover.Test.QA.Steps
{
    [Binding]
    public class CreateAccountSteps : BaseStepDefinition
    {
        private NavigationPage NavigationPage = new NavigationPage();
        private HomePage HomePage = new HomePage();
        private SignInPage SignInPage = new SignInPage();
        private CreateAnAccountPage CreateAnAccountPage = new CreateAnAccountPage();
        private MyAccountPage MyAccountPage = new MyAccountPage();
        private dynamic _ScenarioData;
        private ScenarioContext _scenarioContext;
        private FeatureContext _featureContext;
        public string uniqueEmail;
        public void CreateAccountFeatureContext(FeatureContext featureContext)
        {
            _featureContext = featureContext;
        }

        public void StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I am in the Sign In Page")]
        public void GivenIAmInTheSignInPage()
        {
            NavigationPage.NavigateToHomePage();
            HomePage.NavigateToSignInPage();
            SignInPage.AssertSignInPage();
        }

        [When(@"I Create An Account with a unique email")]
        public void WhenICreateAnAccountWithAnEmail(Table table)
        {
            _ScenarioData = table.CreateDynamicInstance();
            uniqueEmail = (string)_ScenarioData.EmailAddress + string.Format("{0:d9}", DateTime.Now.Ticks / 10 % 1000000000);

            SignInPage.CreateAnAccount(uniqueEmail);
        }

        [When(@"I Register my Personal Information")]
        public void WhenIRegisterMyPersonalInformation(Table table)
        {
            _ScenarioData = table.CreateDynamicInstance();
            CreateAnAccountPage.EnterYourPersonalInformation((string)_ScenarioData.Title, (string)_ScenarioData.FirstName, (string)_ScenarioData.LastName, (string)_ScenarioData.EmailAddress, (string)_ScenarioData.Password);
        }

        [When(@"I Register my Address Details")]
        public void WhenIRegisterMyAddressDetails(Table table)
        {
            dynamic _ScenarioData = table.CreateDynamicInstance();
            string postCode = _ScenarioData.PostCode.ToString();

            CreateAnAccountPage.EnterYourAddressDetails((string)_ScenarioData.FirstName, (string)_ScenarioData.LastName, (string)_ScenarioData.Company, (string)_ScenarioData.Address1, (string)_ScenarioData.Address2, (string)_ScenarioData.City, (string)_ScenarioData.State, postCode, (string)_ScenarioData.Country);
        }

        [When(@"I click Create Account")]
        public void WhenIClickCreateAccount()
        {
            CreateAnAccountPage.ClickCreateAccountButton();

        }

        [Then(@"I should be redirected to My Account Page")]
        public void ThenIShouldBeRedirectedToMyAccountPage()
        {
            MyAccountPage.AssertAccountName();
        }

        [Then(@"I should see the Sign In Page")]
        public void ThenIShouldSeeTheSignInPage()
        {
            SignInPage.AssertSignInPage();
        }

 
        [When(@"I sign in using a Newly Created Account")]
        public void WhenISignInUsingANewlyCreatedAccount(Table table)
        {
            _scenarioContext.Pending();
        }
    }
}
