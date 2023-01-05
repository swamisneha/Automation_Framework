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
    public class EmployeeTest : AutomationWrapper
    {
        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.AddValidEmployeeTestData))]
        public void AddValidEmployeeTest(string username, string password, string firstName, string middleName, string lastName,  string expetedresult)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[text()=' Login ']")).Click();

            driver.FindElement(By.XPath("//span[text()='PIM']")).Click();
            driver.FindElement(By.XPath("//a[normalize-space()='Add Employee']")).Click();
            driver.FindElement(By.Name("firstName")).SendKeys(firstName) ;
            driver.FindElement(By.Name("middleName")).SendKeys(middleName) ;
            driver.FindElement(By.Name("lastName")).SendKeys(lastName) ;

            driver.FindElement(By.XPath("//button[@type='submit']")).Click();


            string headerLoctorXpath = "//h6[contains(normalize-space(),'@@@@@')]";
            headerLoctorXpath = headerLoctorXpath.Replace("@@@@@", firstName);
            Console.WriteLine(headerLoctorXpath);
            string nameValidation = driver.FindElement(By.XPath(headerLoctorXpath)).Text;
            
            Console.WriteLine(nameValidation);
           
            Assert.That(nameValidation, Is.EqualTo(expetedresult));
        }
    }
}
