using OpenQA.Selenium;
using SeFramework.PageActions;
using SeFramework.PageAssembly;
namespace SeFramework.Pages
{
    public class CreateAccount : Drivers
    {
        CreateAccountActions createAccountActions;
        public CreateAccount(IWebDriver _driver)
        {
            driver = _driver;
            createAccountActions = new CreateAccountActions(_driver);
        }
        IWebElement createAccountLink => driver.FindElement(By.XPath("(//a[normalize-space(.)='Create an Account'])[1]"));
        IWebElement firstNameField => driver.FindElement(By.XPath("//input[@id='firstname']"));
        IWebElement lastNameField => driver.FindElement(By.XPath("//input[@id='lastname']"));
        IWebElement emailField => driver.FindElement(By.XPath("//input[@id='email_address']"));
        IWebElement passwordField => driver.FindElement(By.XPath("//input[@id='password']"));
        IWebElement confirmPasswordField => driver.FindElement(By.XPath("//input[@id='password-confirmation']"));
        IWebElement createAccountButton => driver.FindElement(By.XPath("(//button[@type='submit'])[2]"));
        IWebElement myaccounttextVerification => driver.FindElement(By.XPath("(//span[normalize-space(.)='My Account'])"));

        IWebElement dublicateAccountError => driver.FindElement(By.XPath("//div[@data-bind='html: $parent.prepareMessageForHtml(message.text)']"));

        IWebElement invalidEmail => driver.FindElement(By.XPath("//div[@id='email_address-error']"));
        IWebElement passwordmismatch => driver.FindElement(By.XPath("//div[@for='password-confirmation' and @id='password-confirmation-error']"));

        public void ClickCreateAccountLink()
        {
            createAccountActions.Click(createAccountLink);
        }
        public void EnterFirstName(string firstName)
        {
            createAccountActions.EnterTextInTextBox(firstNameField, firstName);
        } 
        public void EnterLastName(string lastName)
        {
            createAccountActions.EnterTextInTextBox(lastNameField, lastName);
        }
        public void EnterEmail(string eMail)
        {
            createAccountActions.EnterTextInTextBox(emailField, eMail);
        }
        public void EnterPassword(string passWord)
        {
            createAccountActions.EnterTextInTextBox(passwordField, passWord);
        }
        public void EnterConfirmPassword(string confirmPassWord)
        {
            createAccountActions.EnterTextInTextBox(confirmPasswordField, confirmPassWord);
        }

        public void ClickCreateAccountButton()
        {
            createAccountActions.Click(createAccountButton);
        }
        public void IsVisible()
        {
            createAccountActions.IsVisible(myaccounttextVerification);
        }

        public void DublicateAccountErrorVisible()
        {
            createAccountActions.IsVisible(dublicateAccountError);
        }

        public void InvalidEmailVisible()
        {
            createAccountActions.IsVisible(invalidEmail);
        }
        public void passwordMistmatch()
        {
            createAccountActions.IsVisible(passwordmismatch);
        }
    }
}