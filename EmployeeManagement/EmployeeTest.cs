using EmployeeManagement.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class EmployeeTest : AutomationWrapper
    {
        [Test]
        public void AddValidEmployeeTest()
        {
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[text()=' Login ']")).Click();

            driver.FindElement(By.XPath("//span[text()='PIM']")).Click();
            driver.FindElement(By.XPath("//a[text()='Add Employee']")).Click();
            driver.FindElement(By.Name("firstName")).SendKeys("Neena");
            driver.FindElement(By.Name("middleName")).SendKeys("Jack");
            driver.FindElement(By.Name("lastName")).SendKeys("Kochar");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
        }
    }
}
