using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Onliner.Pages
{
    public class CatalogPage
    {

        public CatalogPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//a[@href='https://catalog.onliner.by/tv']")]
        public IWebElement tv { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@data-id='1']")] //"//span[text()='Электроника']/../.."
        public IWebElement electronics { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='https://catalog.onliner.by/tv']/../../..")]
        public IWebElement tvAndVideo { get; set; }
    }
}
