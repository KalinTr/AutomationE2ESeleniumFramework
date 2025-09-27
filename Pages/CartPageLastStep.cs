using AutomationFrameworkE2E.Utilities;
using OpenQA.Selenium;

namespace AutomationFrameworkE2E.Pages
{
    public class CartPageLastStep(IWebDriver driver) : BasePage(driver)
    {
        private readonly By _finishButton = By.LinkText("FINISH");

        public ThankYouPage FinishOrder()
        {
            Driver.FindElement(_finishButton).Click();
            return new ThankYouPage(Driver);
        }
    }
}
