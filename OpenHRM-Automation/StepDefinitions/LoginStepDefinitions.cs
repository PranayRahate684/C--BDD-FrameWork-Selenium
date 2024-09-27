using System;
using TechTalk.SpecFlow;

namespace OpenHRMAutomation.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {

        [Given(@"I have a browser open with OrangeHRM Website loaded")]
        public void GivenIHaveABrowserOpenWithOrangeHRMWebsiteLoaded()
        {
            Console.WriteLine( "ORANGE HRM");
        }

        [When(@"I enter valid username as '(.*)'")]
        public void WhenIEnterValidUsernameAs(string username)
        {
            Console.WriteLine( "username : "+username);
        }

        [When(@"I enter valid password as '(.*)'")]
        public void WhenIEnterValidPasswordAs(string password)
        {
            Console.WriteLine("password : "+password);
        }

        [When(@"I click on login button")]
        public void WhenIClickOnLoginButton()
        {
            Console.WriteLine("login button");
        }

        [Then(@"I should get access to Dashboard page with '(.*)' text")]
        public void ThenIShouldGetAccessToDashboardPageWithText(string expectedText)
        {
            Console.WriteLine("Quick launch");
        }
        [Then(@"I should not get access to Dashboard page with error message as '([^']*)' text")]
        public void ThenIShouldNotGetAccessToDashboardPageWithErrorMessageAsText(string expectedError)
        {
            Console.WriteLine( "Error message : "+ "Invalid Credentials");
        }

    }
}
