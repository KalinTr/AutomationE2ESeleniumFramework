using AutomationFrameworkE2E.Utilities;
using OpenQA.Selenium;

namespace AutomationFrameworkE2E.Pages
{
    public class CartPageSecondStep(IWebDriver driver) : BasePage(driver)
    {
        private readonly By _firstName = By.Id("first-name");
        private readonly By _lastName = By.Id("last-name");
        private readonly By _zipCode = By.Id("postal-code");
        private readonly By _continueButton = By.CssSelector(".btn_primary");

        private void EnterFirstName(string firstName)
        {
            var element = Driver.FindElement(_firstName);
            element.SendKeys(firstName);
        }

        private void EnterLastName(string lastName)
        {
            var element = Driver.FindElement(_lastName);
            element.SendKeys(lastName);
        }

        private void EnterZipCode(string zipCode)
        {
            var element = Driver.FindElement(_zipCode);
            element.Clear();
            element.SendKeys(zipCode);
        }

        private void ClickContinue()
        {
            Driver.FindElement(_continueButton).Click();
        }
        public void FillFormAndContinue(string firstName, string lastName, string zipCode)
        {
            EnterFirstName(firstName);
            EnterLastName(lastName);
            EnterZipCode(zipCode);
            ClickContinue();
        }
    }
}
