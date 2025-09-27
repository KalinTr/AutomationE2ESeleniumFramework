using AutomationFrameworkE2E.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkE2E.Pages
{
    public class CartPageFirstStep : BasePage
    {
        private readonly By _checkoutButton = By.LinkText("CHECKOUT");
        public CartPageFirstStep(IWebDriver driver) : base(driver) { }

        public CartPageSecondStep ClickCheckOutButton()
        {
            Driver.FindElement(_checkoutButton).Click();
            return new CartPageSecondStep(Driver);
        }
    }
}
