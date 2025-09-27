using OpenQA.Selenium;

namespace AutomationFrameworkE2E.Utilities
{
    public abstract class BasePage(IWebDriver driver)
    {
        protected IWebDriver Driver { get; } = driver;
        
        //protected IWebElement FindElement(By locator)
        //{
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            //return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
        //}
    }
}
