using AutomationFrameworkE2E.Utilities;
using OpenQA.Selenium;

namespace AutomationFrameworkE2E.Pages
{
    public class CartPageLastStep(IWebDriver driver) : BasePage(driver)
    {
        private readonly By finishButton = By.LinkText("FINISH");

        public ThankYouPage FinishOrder()
        {
            Driver.FindElement(finishButton).Click();
            return new ThankYouPage(Driver);
        }
    }
}
