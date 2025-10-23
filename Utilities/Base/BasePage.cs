using OpenQA.Selenium;

namespace AutomationFrameworkE2E.Utilities.Base
{
    public abstract class BasePage(IWebDriver driver)
    {
        protected IWebDriver Driver { get; } = driver;
    }
}
