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
    public class EmployeeTest : AutomationWrapper
    {
        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.AddValidEmployeeTestData))]
        public void AddValidEmployeeTest(string username, string password, string firstName, string middleName, string lastName,  string expetedresult)
        {      
            LoginPage loginpage = new LoginPage(driver);
            loginpage.EnterUsername("Admin");
            loginpage.EnterPassword("admin123");
            loginpage.ClickOnLogin();

            //Main page
            MainPage mainPage = new MainPage(driver);
            mainPage.ClickOnPIMMenu();

            //PIMPage
            PIMPage pIMPage = new PIMPage(driver);
            pIMPage.ClickOnAddEmployeePage();

            AddEmployeePage addEmployeePage = new AddEmployeePage(driver);
            addEmployeePage.EnterfirstName(firstName);
            addEmployeePage.EnterMiddleName(middleName);
            addEmployeePage.EnterlastName(lastName);
            addEmployeePage.ClickOnSave();

            PersonalDetailPage personalDetailPage = new PersonalDetailPage(driver);
            string nameValidation = personalDetailPage.GetAddEmployeeName(firstName);
            
            Assert.That(nameValidation, Is.EqualTo(expetedresult));
        }
    }
}
