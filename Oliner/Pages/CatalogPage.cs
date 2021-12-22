using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Onliner.Pages
{
    public class CatalogPage
    {

        public CatalogPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = TV)]
        public IWebElement tv { get; set; }

        [FindsBy(How = How.XPath, Using = ELECTRONICS)]
        public IWebElement electronics { get; set; }

        [FindsBy(How = How.XPath, Using = TV_AND_VIDEO)]
        public IWebElement tvAndVideo { get; set; }

        public const string TV = "//a[@href='https://catalog.onliner.by/tv']";
        public const string ELECTRONICS = "//li[@data-id='1']";
        public const string TV_AND_VIDEO = "//a[@href='https://catalog.onliner.by/tv']/../../..";

    }
}
