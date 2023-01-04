using EmployeeManagement.Base;
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
            Assert.That(actualUrl, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login"));
        }

        public static object[] InvalidLoginData()
        {
            string[] dataSet1 = new string[2];
            dataSet1[0] = "john";
            dataSet1[1] = "john123";

            string[] dataSet2 = new string[2];
            dataSet2[0] = "peter";
            dataSet2[1] = "peter123";

            string[] dataSet3 = new string[2];
            dataSet3[0] = "saul";
            dataSet3[1] = "saul123";

            object[] allDataSet = new object[3]; // Number of test cases
            allDataSet[0] = dataSet1;
            allDataSet[1] = dataSet2;
            allDataSet[2] = dataSet3;
            return allDataSet;
        }
        [Test, TestCaseSource(nameof(InvalidLoginData))]

        //[Test]
        //[TestCase("john", "john123", "Invalid credentials")]
        //[TestCase("peter", "peter234", "Invalid credentials")]
        //[TestCase("saul", "saul123", "Invalid credentials")]
        public void InvalidLoginTest(string usename, string password, string expectedError)
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[text()=' Login ']")).Click();

            string actualError = driver.FindElement(By.XPath("p[contains(normalize-space(),'cred')]")).Text;


            //Assert the error 
            Assert.That(actualError.Contains(expectedError), "Assertion on error msg");
        }
    }
}
