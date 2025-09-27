using AngleSharp.Text;
using AutomationFrameworkE2E.Utilities;
using OpenQA.Selenium;

namespace AutomationFrameworkE2E.Pages
{
    public class LoginPage : BasePage
    {
        // Locators as an fields, set only for reading, because we are 
        // only going to read them without setting them
        private readonly By _usernameInput = By.Id("user-name");
        private readonly By _passwordInput = By.Id("password");
        private readonly By _loginButton = By.Id("login-button");

        public LoginPage(IWebDriver driver) : base(driver) { }

        public void EnterUsername(string username)
        {
            var element = Driver.FindElement(_usernameInput);
            element.Clear();
            element.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            var element = Driver.FindElement(_passwordInput);
            element.Clear();
            element.SendKeys(password);
        }

        public void ClickLogin()
        {
            Driver.FindElement(_loginButton).Click();
        }
        public InventoryPage Login(string username, string password)
        {
            EnterUsername(username);
            EnterPassword(password);
            ClickLogin();
            var inventoryPage = new InventoryPage(Driver);
            string headerText = inventoryPage.GetInventoryHeaderText();
            Assert.That(headerText, Is.EqualTo("Products"));
            return inventoryPage;
        }
    }
}
