using EmployeeManagement.Base;
using EmployeeManagement.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EmployeeManagement
{
    public class LoginUITest : AutomationWrapper
    {

        [Test]
        public void ValidateTitleTest()
        {

            string actualTitles = driver.Title;
            Assert.That(actualTitles, Is.EqualTo("OrangeHRM"));
        }

        [Test]

        public void ValidatePlaceholderTesr()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = ("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            LoginPage loginPage = new LoginPage(driver);

            string actualUsernamePlaceholder = loginPage.GetUserNamePlaceholder();

            Assert.That(actualUsernamePlaceholder, Is.EqualTo("Username"));
            Assert.That(loginPage.GetPasswordPlaceholder(), Is.EqualTo("Password"));
        }
    }
}