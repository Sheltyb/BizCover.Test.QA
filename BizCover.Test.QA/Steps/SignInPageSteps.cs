using BizCover.Test.QA.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BizCover.Test.QA.Steps
{
    [Binding]
    public class SignInPageSteps : BaseStepDefinition
    {
        private NavigationPage NavigationPage = new NavigationPage();
        private HomePage HomePage = new HomePage();
        private SignInPage SignInPage = new SignInPage();
        private MyAccountPage MyAccountPage = new MyAccountPage();
        private dynamic _ScenarioData;

        [Given(@"I am in the Sign In Page")]
        public void GivenIAmInTheSignInPage()
        {
            NavigationPage.NavigateToHomePage();
            HomePage.NavigateToSignInPage();
            SignInPage.AssertSignInPage();
        }

        [When(@"I Sign In with my username and password")]
        public void WhenISignInWithMyUsernameAndPassword(Table table)
        {
            _ScenarioData = table.CreateDynamicInstance();
            SignInPage.SignIn((string)_ScenarioData.UserName, (string)_ScenarioData.Password);
        }

        //private ScenarioContext _scenarioContext;

        //public void StepDefinitions(ScenarioContext scenarioContext)
        //{
        //    _scenarioContext = scenarioContext;
        //}
        
        [Then(@"I should see the Sign In Page")]
        public void ThenIShouldSeeTheSignInPage()
        {
            SignInPage.AssertSignInPage();
        }


    }
}
