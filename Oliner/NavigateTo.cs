using Onliner.Actions;
using Onliner.Pages;

namespace Onliner
{
    class NavigateTo
    {
        public static CatalogPage catalogPage = new CatalogPage();
        public static TVPage tvPage = new TVPage();
        public static ProductPage productPage = new ProductPage();
        public static Menu menu = new Menu();

        public static void LoginForm()
        {
            Menu menu = new Menu();
            menu.authButton.Click();
        }

        public static void TvPage()
        {
            catalogPage = new CatalogPage();
            catalogPage.electronics.Click();
            catalogPage.tvAndVideo.Click();
            catalogPage.tv.Click();

        }

        public static void Catalog()
        {
            ActionsHomePage.ClickCatalogButton();
        }
    }
}
