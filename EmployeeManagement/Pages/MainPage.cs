using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Pages
{
    public class MainPage
    {
        private IWebDriver driver;
        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetMainPageUrl()
        {
            return driver.Url;
        }
        public void ClickOnPIMMenu()
        {
            driver.FindElement(By.XPath("//span[text()='PIM']")).Click();
        }

    }
}
