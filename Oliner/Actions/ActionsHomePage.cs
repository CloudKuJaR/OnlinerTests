using Onliner.Pages;

namespace Onliner.Actions
{
    public static class ActionsHomePage
    {
        public static Menu menu = new Menu();
        public static void FillSerachBar()
        {

            menu.searchBar.SendKeys(Config.SearchInformation.searchItem);
        }

        public static void ClickCatalogButton()
        {
            menu.catalogButton.Click();
        }

        public static void ClickCompareButton()
        {
            menu.compareButton.Click();
        }
    }
}
