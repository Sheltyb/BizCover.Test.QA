using BizCover.Test.QA.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BizCover.Test.QA.Steps
{
    [Binding]
    public class LoginSteps : BaseStepDefinition
    {
        private NavigationPage NavigationPage = new NavigationPage();
        private HomePage HomePage = new HomePage();
        private SignInPage SignInPage = new SignInPage();   
        private MyAccountPage MyAccountPage = new MyAccountPage(); 
        private dynamic _ScenarioData;

        [Given(@"I am in the home page of the system")]
        public void GivenIAmInTheHomePageOfTheSystem()
        {
            NavigationPage.NavigateToHomePage();
        }
        [When(@"I select the Sign In option from the menu")]
        public void WhenISelectTheSignInOptionFromTheMenu()
        {
            HomePage.NavigateToSignInPage();
        }

        private ScenarioContext _scenarioContext;

        public void StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"I Sign In with my username and password")]
        public void WhenISignInWithMyUsernameAndPassword(Table table)
        {
            _ScenarioData = table.CreateDynamicInstance();
            SignInPage.SignIn((string)_ScenarioData.UserName, (string)_ScenarioData.Password);
        }

        [Then(@"I should be redirected to my Account Page")]
        public void ThenIShouldBeRedirectedToMyAccountPage()
        {
            MyAccountPage.AssertAccountName();
        }
    }
}
