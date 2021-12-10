using Onliner.Pages;
using System.Threading;

namespace Onliner
{
    class NavigateTo
    {
        public static CatalogPage catalogPage = new CatalogPage();
        public static TVPage tvPage = new TVPage();
        public static ProductPage  productPage = new ProductPage();
        public static Menu menu = new Menu();

        public static void LoginForm()
        {
            
            Thread.Sleep(800);
            menu.authButton.Click();
            Thread.Sleep(2000);
        }

        public static void TvPage()
        {
            catalogPage.electronics.Click();
            catalogPage.tvAndVideo.Click();
            catalogPage.tv.Click();
            Thread.Sleep(1000);

        }

        public static void Catalog()
        {
            Actions.ClickCatalogButton();
        }
    }
}
