using OpenQA.Selenium;
using Reqnroll;
using SeFramework.PageAssembly;
using SeFramework.Pages;
namespace SeFramework.StepDefinitions
{
    [Binding]
    public class CreateAccountSteps
    {
        Drivers drivers = new Drivers();
        CreateAccount createAccount;
        
        IWebDriver driver;

        [Given("I navigate to given website")]
        public void GivenINavigateToGivenWebsite()
        {
            drivers.Init();
            driver = drivers.SetDriver;
            createAccount = new CreateAccount(driver);
           
        }

        [Given("I click on Create an Account Link")]
        public void GivenIClickOnCreateAnAccountLink()
        {
            createAccount.ClickCreateAccountLink();
        }

        [Given("I Enter First Name as {string}")]
        public void GivenIEnterFirstNameAs(string fName)
        {
            createAccount.EnterFirstName(fName);
        }

        [Given("I Enter Last Name as {string}")]
        public void GivenIEnterLastNameAs(string lName)
        {
            createAccount.EnterLastName(lName);
        }

        [Given("I Enter Email as {string}")]
        public void GivenIEnterEmailAs(string eMail)
        {
            string[] texts = eMail.Split('@');
            eMail = texts[0] + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss").Replace("/", "").Replace(":", "").Replace(" ", "") + $"@{texts[1]}";
            createAccount.EnterEmail(eMail);
            // createAccount.EnterEmail(eMail);
        }

        [Given("I Enter Password as {string}")]
        public void GivenIEnterPasswordAs(string passWord)
        {
            createAccount.EnterPassword(passWord);
        }

        [Given("I Enter Confirm Password as {string}")]
        public void GivenIEnterConfirmPasswordAs(string passWord)
        {
            createAccount.EnterConfirmPassword(passWord);
        }

        [Then("I Click on Create an Account button")]
        public void ThenIClickOnCreateAnAccountButton()
        {
            createAccount.ClickCreateAccountButton();
        }

        [Then("I see My Account text")]
        public void ThenISeeMyAccountText()
        {
            createAccount.IsVisible();
            driver.Quit();
        }
        [Then("I see error text")]
        public void ThenISeeErrorText()
        {
            createAccount.InvalidEmailVisible();
            driver.Quit();
        }

        [Given("I Enter duplicate Email as {string}")]
        public void GivenIEnterDuplicateEmailAs(string p0)
        {
            createAccount.EnterEmail(p0);
        }

        [Then("I see message error duplcate email error text")]
        public void ThenISeeMessageErrorDuplcateEmailErrorText()
        {
            createAccount.DublicateAccountErrorVisible();
            driver.Quit();
        }

        [Then("I see password mismatch error")]
        public void ThenISeePasswordMismatchError()
        {
            createAccount.passwordMistmatch();
            driver.Quit();
        }
        


    }
}
