using Onliner.WebElementExtension;
using OpenQA.Selenium;

namespace Onliner.Pages
{
    public class TVPage
    {
        public const string PRODUCT1 = "//span[text()='Телевизор LG 65UP75006LF']/..";
        public const string PRODUCT2 = "//span[text()='Телевизор LG 55NANO926PB']/..";

        public MyWebElement Product1 => new MyWebElement(By.XPath(PRODUCT1));
        public MyWebElement Product2 => new MyWebElement(By.XPath(PRODUCT2));

        public void ClickFirstProductButton()
        {
            Product1.Click();
        }

        public void ClickSecondProductButton()
        {
            Product2.Click();
        }
    }
}
