using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Pages
{
    public class PersonalDetailPage
    {
        private IWebDriver driver;
        public PersonalDetailPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GetAddEmployeeName(string firstName)
        {
            string headerLoctorXpath = "//h6[contains(normalize-space(),'@@@@@')]";
            headerLoctorXpath = headerLoctorXpath.Replace("@@@@@", firstName);
            Console.WriteLine(headerLoctorXpath);
            return driver.FindElement(By.XPath(headerLoctorXpath)).Text;
        }
    }
}
