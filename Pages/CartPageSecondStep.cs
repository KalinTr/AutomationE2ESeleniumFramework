using AutomationFrameworkE2E.Utilities;
using OpenQA.Selenium;

namespace AutomationFrameworkE2E.Pages
{
    public class CartPageSecondStep(IWebDriver driver) : BasePage(driver)
    {
        private readonly By firstName = By.Id("first-name");
        private readonly By lastName = By.Id("last-name");
        private readonly By zipCode = By.Id("postal-code");
        private readonly By continueButton = By.CssSelector(".btn_primary");

        private void EnterFirstName(string fName)
        {
            var element = Driver.FindElement(firstName);
            element.SendKeys(fName);
        }

        private void EnterLastName(string lName)
        {
            var element = Driver.FindElement(lastName);
            element.SendKeys(lName);
        }

        private void EnterZipCode(string zip)
        {
            var element = Driver.FindElement(zipCode);
            element.Clear();
            element.SendKeys(zip);
        }

        private void ClickContinue()
        {
            Driver.FindElement(continueButton).Click();
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
