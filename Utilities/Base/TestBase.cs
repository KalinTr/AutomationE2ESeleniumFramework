using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace AutomationFrameworkE2E.Utilities.Base
{
    public class TestBase
    {
        protected IWebDriver Driver = null!;
        private IConfiguration configuration;

        [SetUp]
        public void SetUp()
        {
            configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            string browserName = configuration["Browser"]!;
            string url = configuration["Url"]!;

            InitBrowser(browserName);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(url);
        }

        private void InitBrowser(string browserName)
        {
            switch (browserName.ToLower())
            {
                case "chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    Driver = new ChromeDriver();
                    break;
                case "firefox":
                    Driver = new FirefoxDriver();
                    break;
                case "edge":
                    Driver = new EdgeDriver();
                    break;
                default:
                    throw new ArgumentException($"Browser {browserName} is not supported!");
            }
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Quit();
            Driver.Dispose();
        }
    }
}
