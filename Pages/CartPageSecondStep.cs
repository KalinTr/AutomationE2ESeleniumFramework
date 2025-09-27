using AutomationFrameworkE2E.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkE2E.Pages
{
    public class CartPageSecondStep : BasePage
    {
        private readonly By _firstName = By.Id("first-name");
        private readonly By _lastName = By.Id("last-name");
        private readonly By _zipCode = By.Id("postal-code");
        private readonly By _continueButton = By.CssSelector(".btn_primary");

        public CartPageSecondStep(IWebDriver driver) : base(driver) { }

        public void EnterFirstName(string firstName)
        {
            var element = Driver.FindElement(_firstName);
            element.SendKeys(firstName);
        }
        public void EnterLastName(string lastName)
        {
            var element = Driver.FindElement(_lastName);
            element.SendKeys(lastName);
        }
        public void EnterZipCode(string zipCode)
        {
            var element = Driver.FindElement(_zipCode);
            element.Clear();
            element.SendKeys(zipCode);
        }
        public void ClickContinue()
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
