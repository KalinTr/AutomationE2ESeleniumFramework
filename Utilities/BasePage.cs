using OpenQA.Selenium;

namespace AutomationFrameworkE2E.Utilities
{
    public abstract class BasePage(IWebDriver driver)
    {
        protected IWebDriver Driver { get; } = driver;
    }
}
