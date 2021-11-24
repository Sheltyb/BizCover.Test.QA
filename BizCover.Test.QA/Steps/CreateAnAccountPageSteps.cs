using BizCover.Test.QA.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BizCover.Test.QA.Steps
{
    [Binding]
    public class CreateAnAccountPageSteps : BaseStepDefinition
    {
        private NavigationPage NavigationPage = new NavigationPage();
        private HomePage HomePage = new HomePage();
        private SignInPage SignInPage = new SignInPage();
        private CreateAnAccountPage CreateAnAccountPage= new CreateAnAccountPage();
        private dynamic _ScenarioData;

 
        [Given(@"I am in the Create An Account Page")]
        public void GivenIAmInTheCreateAnAccountPage()
        {
            NavigationPage.NavigateToHomePage();
            HomePage.NavigateToSignInPage();
            CreateAnAccountPage.AssertCreateAccountPage();
        }

        [Then(@"I should see the Create An Account Page")]
        public void ThenIShouldSeeTheCreateAccountPage()
        {
            CreateAnAccountPage.AssertCreateAccountPage();
        }


        //	| Title | FirstName | LastName | EmailAddressUserName   | EmailAddressDomain | Password |
        [When(@"I Register my Personal Information")]
        public void WhenIRegisterMyPersonalInformation(Table table)
        {
            _ScenarioData = table.CreateDynamicInstance();
            CreateAnAccountPage.EnterYourPersonalInformation((string)_ScenarioData.FirstName, (string)_ScenarioData.LastName);

        }


    }
}
