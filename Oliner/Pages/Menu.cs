using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Onliner.Pages
{
    public class Menu
    {
        public Menu()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = COMPARE_BUTTON)]
        public IWebElement compareButton { get; set; }

        [FindsBy(How = How.XPath, Using = CATALOG_BUTTON)]
        public IWebElement catalogButton { get; set; }

        [FindsBy(How = How.XPath, Using = SEARCH_BAR)]
        public IWebElement searchBar { get; set; }

        [FindsBy(How = How.XPath, Using = AUTH_BUTTON)]
        public IWebElement authButton { get; set; }

        public const string COMPARE_BUTTON = "//a[@class='compare-button__sub compare-button__sub_main']";
        public const string CATALOG_BUTTON = "//span[@class='b-main-navigation__text'][text()='Каталог']";
        public const string SEARCH_BAR = "//input[@tabindex='1']";
        public const string AUTH_BUTTON = "//div[@class='auth-bar__item auth-bar__item--text']";
        public const string SEARCH_WINDOW = "//div[@class='search__content-wrapper']";
    }
}
