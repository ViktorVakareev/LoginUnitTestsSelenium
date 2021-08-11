using NUnit.Framework;

namespace LoginUnitTestsSelenium
{
    public partial class LoginPage
    {
        public void AssertLoginValidation()
        {
            Assert.AreEqual("Invalid login attempt. That account doesn't seem to be available.", EmailValidationMessage.Text);
        }

        public void AssertEmptyEmailValidation()
        {
            Assert.AreEqual("Email is required.", EmailValidationMessage.Text);
        }

        public void AssertEmptyPasswordValidation()
        {
            Assert.AreEqual("Password is required.", PasswordValidationMessage.Text);
        }
    }
}
