using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;

namespace Onliner
{
    public static class Initialize
    {
        public static IWebDriver InitializeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = Config.baseUrl;
            return driver;
        }

        public static void InitializeWait(IWebDriver driver)
        {
            Driver.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public static string InitializePath()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().Location;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            return projectPath;
        }

        public static void InitializeReporter(string projectPath, string testName)
        {
            Reporter.htmlReporter = new ExtentHtmlReporter(projectPath + "Reports\\"+ testName + "\\" + testName + ".html");
            Reporter.htmlReporter.Config.DocumentTitle = "Test Report";
            Reporter.htmlReporter.Config.ReportName = " Artem ";
            Reporter.extent = new ExtentReports();

            Reporter.extent.AttachReporter(Reporter.htmlReporter);
        }

    }
}
