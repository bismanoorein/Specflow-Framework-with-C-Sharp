using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SeFramework.PageAssembly
{
    public class Drivers
    {
        public IWebDriver? driver;
              
        public String? webAddress;
             
        
        public Drivers()        
        {        
                 
            webAddress = "https://magento.softwaretestingboard.com/";
        }
        public void Init()
        {          
                      

            driver = new ChromeDriver();
           
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
           
            driver.Manage().Window.Maximize();
         
        }
        public IWebDriver SetDriver
        {
            get { return driver; }
        }
        public void Close()
        {
            driver.Quit();
                
        }
    }
}