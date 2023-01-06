using EmployeeManagement.Base;
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
        [Test]
        public void ValidLoginTest()
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[text()=' Login ']")).Click();

            String actualUrl = driver.Url;
            Assert.That(actualUrl, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index"));
        }

        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidLoginTestData2))]
        //[TestCase("john", "john123", "Invalid credential")]
        //[TestCase("peter", "peter234", "Invalid credential")]
        //[TestCase("saul", "saul123", "Invalid credential")]
        public void InvalidLoginTest(string username, string password, string expectedError)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);           
            driver.FindElement(By.XPath("//button[text()=' Login ']")).Click();

            string actualError = driver.FindElement(By.XPath("//p[contains(normalize-space(),'cred')]")).Text;
            Console.WriteLine(actualError.ToUpper());

            //Assert the error 
            Assert.That(actualError.Contains(expectedError), "Assertion on error msg");
        }
    }
}
