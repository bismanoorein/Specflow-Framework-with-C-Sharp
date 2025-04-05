using System;
using OpenQA.Selenium;
using Reqnroll;
using SeFramework.PageAssembly;
using SeFramework.Pages;

namespace SeFramework.StepDefinitions
{
    [Binding]


    public class SigninStepDefinitions
    {

        public class SignInSteps : Drivers
        {
            Drivers drivers = new Drivers();
            Signin signin;
            IWebDriver driver;
            public void GivenINavigateToGivenWebsite()
            {
                drivers.Init();
                driver = drivers.SetDriver;
                signin = new Signin(driver);
            }
            [Then("I click on Log In button")]
            public void ThenIClickOnLogInButton()
            {
                signin.Clicklogin();
            }

            [Then("I enter email as {string} and password as {string}")]
            public void ThenIEnterEmailAsAndPasswordAs(string p0, string p1)
            {
                signin.EnterLoginCredentialsInInputBoxes(p0, p1);
            }

            [Then("I click on Login button")]
            public void ThenIClickOnLoginButton()
            {
                signin.clickLoginButton();
                driver.Quit();
            }
        }
    }
}
