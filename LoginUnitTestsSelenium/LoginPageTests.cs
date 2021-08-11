using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace LoginUnitTestsSelenium
{
    public class LoginPageTests
    {
        private IWebDriver _driver;
        private LoginPage _loginPage;

        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
            _loginPage = new LoginPage(_driver);  
        }

        [TearDown]
        public void CleanUp()
        {
            _driver.Quit();
        }
        
        [Test]
        public void LoginAttempt_When_IncorrectEmailAndPasswordEntered()
        {
            _loginPage.Open();

            _loginPage.Login("wrongEmail@", "12");

            _loginPage.AssertLoginValidation();
        }

        [Test]
        public void LoginAttempt_When_EmptyEmailField()
        {
            _loginPage.Open();

            _loginPage.Login(string.Empty, "12");

            _loginPage.AssertEmptyEmailValidation();            
        }

        [Test]
        public void LoginAttempt_When_EmptyPasswordField()
        {           
            _loginPage.Open();

            _loginPage.Login("wrongEmail@", string.Empty);

            _loginPage.AssertEmptyPasswordValidation();
        }

        [Test]
        public void LoginAttempt_When_EmptyEmailAndPasswordFields()
        {
            _loginPage.Open();

            _loginPage.Login(string.Empty,string.Empty);          

            _loginPage.AssertEmptyEmailValidation();
            _loginPage.AssertEmptyPasswordValidation();
        }
    }
}