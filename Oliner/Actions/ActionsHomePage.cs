using Onliner.Pages;

namespace Onliner.Actions
{
    public static class ActionsHomePage
    {

        public static void FillSerachBar()
        {
            Menu menu = new Menu();
            menu.searchBar.SendKeys(Config.SearchInformation.searchItem);
        }

        public static void ClickCatalogButton()
        {
            Menu menu = new Menu();
            menu.catalogButton.Click();
        }

        public static void ClickCompareButton()
        {
            Menu menu = new Menu();
            menu.compareButton.Click();
        }
    }
}
