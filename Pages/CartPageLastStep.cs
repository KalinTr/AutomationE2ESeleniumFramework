using AutomationFrameworkE2E.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V137.Network;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkE2E.Pages
{
    public class CartPageLastStep : BasePage
    {
        private readonly By _finishButton = By.LinkText("FINISH");
        public CartPageLastStep(IWebDriver driver) : base(driver)
        {
        }

        public ThankYouPage FinishOrder()
        {
            Driver.FindElement(_finishButton).Click();
            return new ThankYouPage(Driver);
        }
    }
}
