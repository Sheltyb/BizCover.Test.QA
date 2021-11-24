using BizCover.Test.QA.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BizCover.Test.QA.Steps
{
    [Binding]
    public class MyAccountSteps : BaseStepDefinition
    {
        private MyAccountPage MyAccountPage = new MyAccountPage();
 
        [Then(@"I should be redirected to my Account Page")]
        public void ThenIShouldBeRedirectedToMyAccountPage()
        {
            MyAccountPage.AssertAccountName();
        }
    }
}
