using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeFramework.PageAssembly;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeFramework.PageActions
{
    public class CreateAccountActions : Drivers
    {
        WebDriverWait wait;
        public CreateAccountActions(IWebDriver _driver)
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
       
       
        public void RefreshPage()
        {
            driver.Navigate().Refresh();
        }
       
        public void IsVisible(IWebElement element)
        {
            if (element.Displayed)
            {
                Assert.That(true, "element is visible");
            }
        }
    }
}
