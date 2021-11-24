using BizCover.Test.QA.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BizCover.Test.QA.Steps
{
    [Binding]
    public class HomePageSteps : BaseStepDefinition
    {
        private NavigationPage NavigationPage = new NavigationPage();
        private HomePage HomePage = new HomePage();


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
    }
}
