using OpenQA.Selenium;
using System;

namespace LoginUnitTestsSelenium
{
    public partial class LoginPage
    {
        private IWebDriver _driver;

        public string Url => "https://login.bluehost.com/hosting/webmail"; 

        public LoginPage(IWebDriver driver) => _driver = driver;

        public void Open()
        {
            _driver.Navigate().GoToUrl(Url);
        }

        public void Login(string email, string password)
        {
            EmailTextBox.Clear();
            EmailTextBox.SendKeys(email);
            PasswordTextBox.Clear();
            PasswordTextBox.SendKeys(password);
            LoginButton.Click();        
        }        
    }
}
