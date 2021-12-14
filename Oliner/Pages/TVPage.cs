using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Onliner.Pages
{
    public class TVPage
    {
        public TVPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = PRODUCT1)]
        public IWebElement product1 { get; set; }

        [FindsBy(How = How.XPath, Using = PRODUCT2)]
        public IWebElement product2 { get; set; }

        public const string PRODUCT1 = "//span[text()='Телевизор Samsung QE65QN90AAU']/..";
        public const string PRODUCT2 = "//span[text()='Телевизор LG 55NANO926PB']/..";
    }
}
