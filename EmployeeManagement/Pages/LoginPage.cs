﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Pages
{
    
    public class LoginPage
    {
        private By _usernameLocator = By.Name("username");
        private By _passwordLocator = By.Name("password");
        private By _loginLocator = By.XPath("//button[text()=' Login ']");
        private By _ForgotPasswordLocator = By.XPath("//p[contains(normalize-space(),'Forgot')]");
        private By _ErrorLocator = By.XPath("//p[contains(normalize-space(),'cred')]");

        private IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {
            this.driver=driver;
        }
        public void EnterUsername(string username)
        {
            driver.FindElement(_usernameLocator).SendKeys(username);
        
        }
        public void EnterPassword(string password)
        {
            driver.FindElement(_passwordLocator).SendKeys(password);
        }
        public void ClickOnLogin()
        {
            driver.FindElement(_loginLocator).Click();
        }
        public void ClickOnForgotPassword()
        {
            driver.FindElement(_ForgotPasswordLocator).Click();
        }
        public string GetInvalidErrorMassage()
        {
            return driver.FindElement(_ErrorLocator).Text;
        }
        public string GetUserNamePlaceholder()
        {
            return driver.FindElement(_usernameLocator).GetAttribute("placeholder");
        }

        public string GetPasswordPlaceholder()
        {
            return driver.FindElement(_passwordLocator).GetAttribute("placeholder");
        }

    }
}
