using AutomationFrameworkE2E.Utilities;
using OpenQA.Selenium;

namespace AutomationFrameworkE2E.Pages
{
    public class CartPageFirstStep(IWebDriver driver) : BasePage(driver)
    {
        private readonly By _checkoutButton = By.LinkText("CHECKOUT");

        public CartPageSecondStep ClickCheckOutButton()
        {
            Driver.FindElement(_checkoutButton).Click();
            return new CartPageSecondStep(Driver);
        }
    }
}
