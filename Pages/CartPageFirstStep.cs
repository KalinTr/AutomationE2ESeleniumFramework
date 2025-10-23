using AutomationFrameworkE2E.Utilities.Base;
using OpenQA.Selenium;

namespace AutomationFrameworkE2E.Pages
{
    public class CartPageFirstStep(IWebDriver driver) : BasePage(driver)
    {
        private readonly By checkoutButton = By.LinkText("CHECKOUT");

        public CartPageSecondStep ClickCheckOutButton()
        {
            Driver.FindElement(checkoutButton).Click();
            return new CartPageSecondStep(Driver);
        }
    }
}
