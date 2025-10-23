using AutomationFrameworkE2E.Utilities.Base;
using OpenQA.Selenium;

namespace AutomationFrameworkE2E.Pages
{
    public class LoginPage(IWebDriver driver) : BasePage(driver)
    {
        private readonly By usernameInput = By.Id("user-name");
        private readonly By passwordInput = By.Id("password");
        private readonly By loginButton = By.Id("login-button");

        private void EnterUsername(string username)
        {
            var element = Driver.FindElement(usernameInput);
            element.Clear();
            element.SendKeys(username);
        }

        private void EnterPassword(string password)
        {
            var element = Driver.FindElement(passwordInput);
            element.Clear();
            element.SendKeys(password);
        }

        private void ClickLogin()
        {
            Driver.FindElement(loginButton).Click();
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
