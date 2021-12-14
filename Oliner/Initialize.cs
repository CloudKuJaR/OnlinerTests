using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Onliner
{
    public static class Initialize
    {
        public static void InitializeComponents()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.baseUrl);
            Driver.wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
        }
    }
}
