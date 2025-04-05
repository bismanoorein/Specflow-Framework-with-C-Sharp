//using ReportingLibrary;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeFramework.PagesActions;
using SeFramework.PageAssembly;

namespace SeFramework.Pages
{
    public class Signin : Drivers
    {
        
        LoginPageActions loginPageActions;
        public Signin(IWebDriver _driver )
        {
            driver = _driver;
           
            loginPageActions = new LoginPageActions(_driver);
        }
        IWebElement loginLink => driver.FindElement(By.XPath("//li[@class='authorization-link']//a[1]"));
        IWebElement emailBox => driver.FindElement(By.XPath("//div//*[@name='login[username]' and @id='email']"));
        IWebElement passwordBox => driver.FindElement(By.XPath("//div//*[@name='login[password]' and @id='pass']"));
        IWebElement loginButton => driver.FindElement(By.XPath("//div//button[@type='submit' and @id='send2'][1]"));
        
       
        public void EnterLoginCredentialsInInputBoxes(String? email = null, String? passWord = null)
        {
            loginPageActions.ApplyImplicitWait(15);
            loginPageActions.EnterTextInTextBox(emailBox, email);
            loginPageActions.EnterTextInTextBox(passwordBox, passWord);
        }
        public void Clicklogin()
        {
            loginPageActions.ApplyImplicitWait(10);
            loginPageActions.Click(loginLink);
        }

        public void clickLoginButton()
        { 
          loginPageActions.Click(loginButton);
           
          
        }
      
       
    }
}