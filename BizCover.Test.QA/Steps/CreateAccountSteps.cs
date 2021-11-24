using BizCover.Test.QA.Pages;
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

        [When(@"I Create An Account with an email")]
        public void WhenICreateAnAccountWithAnEmail(Table table)
        {
            _ScenarioData = table.CreateDynamicInstance();
            SignInPage.CreateAnAccount((string)_ScenarioData.EmailAddress);
        }

        [When(@"I Register my Personal Information")]
        public void WhenIRegisterMyPersonalInformation(Table table)
        {
            _ScenarioData = table.CreateDynamicInstance();
            CreateAnAccountPage.EnterYourPersonalInformation((string)_ScenarioData.title, (string)_ScenarioData.FirstName, (string)_ScenarioData.LastName);
        }

        [When(@"I Register my Address Details")]
        public void WhenIRegisterMyAddressDetails(Table table)
        {
            _ScenarioData = table.CreateDynamicInstance();
            CreateAnAccountPage.EnterYourAddressDetails((string)_ScenarioData.FirstName, (string)_ScenarioData.LastName, (string)_ScenarioData.Company, (string)_ScenarioData.Address1, (string)_ScenarioData.Address2, (string)_ScenarioData.City, (string)_ScenarioData.State, (string)_ScenarioData.PostCode, (string)_ScenarioData.Country);
        }

        [When(@"I click Create Account")]
        public void WhenIClickCreateAccount()
        {
            CreateAnAccountPage.ClickCreateAccountButton();
        }

        [Then(@"I should be redirected to My Account Page")]
        public void ThenIShouldBeRedirectedToMyAccountPage()
        {
            _scenarioContext.Pending();
        }

    }
}
