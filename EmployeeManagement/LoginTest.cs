using EmployeeManagement.Base;
using EmployeeManagement.Pages;
using EmployeeManagement.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class LoginTest : AutomationWrapper
    {
        [Test, Retry(2)]
        public void ValidLoginTest()
        {
            //driver.FindElement(By.Name("username")).SendKeys("Admin");

            LoginPage loginpage = new LoginPage(driver);
            loginpage.EnterUsername("Admin");
            loginpage.EnterPassword("admin123");
            loginpage.ClickOnLogin();

            string actualUrl = driver.Url;
            Assert.That(actualUrl, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index"));
        }

        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidLoginTestData2))]
     
        public void InvalidLoginTest(string username, string password, string expectedError)
        {
            LoginPage loginpage = new LoginPage(driver);

            loginpage.EnterUsername("Admin");
            loginpage.EnterPassword("admin123");
            loginpage.ClickOnLogin();

            string actualError = loginpage.GetInvalidErrorMassage();
            Assert.That(actualError.Contains(expectedError), "Assertion on error msg");
        }
    }
}
