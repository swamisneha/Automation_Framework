using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EmployeeManagement
{
    public class LoginUITest
    {

        [Test]
        public void ValidateTitleTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = ("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            string actualTitles = driver.Title;
            Assert.That(actualTitles, Is.EqualTo("OrangeHRM"));
        }
    }
}