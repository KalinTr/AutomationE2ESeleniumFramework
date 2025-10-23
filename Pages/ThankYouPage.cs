using AutomationFrameworkE2E.Utilities.Base;
using OpenQA.Selenium;

namespace AutomationFrameworkE2E.Pages
{
    public class ThankYouPage(IWebDriver driver) : BasePage(driver)
    {
        private readonly By thankYouText = By.ClassName("complete-header");

        public void CompareThankYouText(string expectedText = "THANK YOU FOR YOUR ORDER")
        {
            var actualText = Driver.FindElement(thankYouText).Text;
            Assert.That(actualText, Is.EqualTo(expectedText),
                $"Expected Thank You text to be '{expectedText}', but was '{actualText}'");
        }
    }
}
