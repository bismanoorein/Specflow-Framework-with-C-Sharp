using OpenQA.Selenium;
//using ReportingLibrary;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeFramework.PagesActions
{
    public class LoginPageActions
    {
        IWebDriver driver { get; }

        public LoginPageActions(IWebDriver _driver)
        {
            driver = _driver;

        }
        public void Click(IWebElement element)
        {
            if (element != null)
            {
                element.Click();
            }
        }
        public void ClearTextBox(IWebElement element)
        {
            if (element != null)
            {
                element.Clear();
            }
        }
        public void EnterTextInTextBox(IWebElement element, String? text)
        {
            ClearTextBox(element);
            if (element != null && !text.Equals(""))
            {
                element.SendKeys(text);
            }
        }
        public String GetInnerTextOfElement(IWebElement element)
        {
            String? returnedText = element.Text;
            return returnedText;
        }
        public void ApplyImplicitWait(int seconds)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }
       
    }
}