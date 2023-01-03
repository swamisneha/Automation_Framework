using EmployeeManagement.Base;
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

            string actualUsernamePlaceholder = driver.FindElement(By.Name("username")).GetAttribute("placeholder");
            string actualPasswordPlaceholder = driver.FindElement(By.Name("password")).GetAttribute("placeholder");

            Assert.That(actualUsernamePlaceholder, Is.EqualTo("Username"));
            Assert.That(actualPasswordPlaceholder, Is.EqualTo("Password"));
        }
    }
}