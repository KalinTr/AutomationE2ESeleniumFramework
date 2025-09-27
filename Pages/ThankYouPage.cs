using AutomationFrameworkE2E.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkE2E.Pages
{
    public class ThankYouPage: BasePage
    {
        private readonly By _thankYouText = By.ClassName("complete-header");
        public ThankYouPage(IWebDriver driver) : base(driver)
        {
                
        }
        public void CompareThankYouText(string expectedText = "THANK YOU FOR YOUR ORDER")
        {
            var actualText = Driver.FindElement(_thankYouText).Text;
            Assert.That(actualText, Is.EqualTo(expectedText),
                $"Expected Thank You text to be '{expectedText}', but was '{actualText}'");
        }
    }
}
