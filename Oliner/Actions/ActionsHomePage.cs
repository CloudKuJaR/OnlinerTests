using Onliner.Pages;
using OpenQA.Selenium;

namespace Onliner.Actions
{
    public static class ActionsHomePage
    {
        public static Menu menu;
        public static void FillSerachBar(IWebDriver driver)
        {
            menu = new Menu(driver);
            menu.searchBar.SendKeys(Config.SearchInformation.searchItem);
        }

        public static void ClickCatalogButton(IWebDriver driver)
        {
            menu = new Menu(driver);
            menu.catalogButton.Click();
        }

        public static void ClickCompareButton(IWebDriver driver)
        {
            menu = new Menu(driver);
            menu.compareButton.Click();
        }
    }
}
