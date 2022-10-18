using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class LogoutStepDefinitions
    {
        [When(@"User LogOut from the Application")]
        public void WhenUserLogOutFromTheApplication()
        {
            Console.WriteLine($"{nameof(WhenUserLogOutFromTheApplication)}");
            //throw new PendingStepException();
        }

        [Then(@"Successful LogOut message should display")]
        public void ThenSuccessfulLogOutMessageShouldDisplay()
        {
            Console.WriteLine("Successfully logout");
            // throw new PendingStepException();
        }
    }
}
