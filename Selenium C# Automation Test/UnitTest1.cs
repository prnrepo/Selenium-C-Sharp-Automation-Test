using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Selenium_C__Automation_Test
{
    public class SeleniumTests
    {
        private IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void ValidateTheMessageIsDisplayed()
        {
            driver.Navigate().GoToUrl("https://www.lambdatest.com/selenium-playground/simple-form-demo");
            driver.FindElement(By.Id("user-message")).SendKeys("LambdaTest rules");
            driver.FindElement(By.Id("showInput")).Click();
            Assert.IsTrue(driver.FindElement(By.Id("message")).Text.Equals("LambdaTest rules"),
                          "The expected message was not displayed.");
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }
    }
}