using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace Onliner
{
    public class Waits
    {
        public static IWebElement element;
        public void WaitMethod(string locator)
        {
            element = Driver.wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
        }
    }
}
