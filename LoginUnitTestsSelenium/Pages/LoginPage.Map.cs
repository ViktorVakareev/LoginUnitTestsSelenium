using OpenQA.Selenium;

namespace LoginUnitTestsSelenium
{
    public partial class LoginPage
    {
        public IWebElement EmailTextBox => _driver.FindElement(By.Id("email"));       

        public IWebElement PasswordTextBox => _driver.FindElement(By.Id("password"));
        
        public IWebElement LoginButton => _driver.FindElement(By.XPath("//input[@type='submit']"));

        public IWebElement EmailValidationMessage => _driver.FindElement(By.XPath("//span[@class='error'][1]"));               

        public IWebElement PasswordValidationMessage => _driver.FindElement(By.XPath("//span[@class='error'][2]"));
    }
}
