using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace testFrameworkV0.Tests
{
    class Browser
    {
        private IWebDriver driver;

        private static string baseURL = ConfigurationManager.AppSettings["url"];
        private static string browser = ConfigurationManager.AppSettings["browser"];

        public IWebDriver Init()
        {
            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    break;
                case "IE":
                    driver = new InternetExplorerDriver( new InternetExplorerOptions { IgnoreZoomLevel = true } );
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    break;
            }
            driver.Manage().Window.Maximize();
            driver.Url = baseURL;
            return driver;
        }
    }
}
