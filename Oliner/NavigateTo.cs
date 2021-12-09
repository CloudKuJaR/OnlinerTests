using Onliner.Pages;
using System.Threading;

namespace Onliner
{
    class NavigateTo
    {
        public static void LoginForm()
        {
            HomePage homePage = new HomePage();
            Thread.Sleep(800);
            homePage.authButton.Click();
            Thread.Sleep(2000);
        }

        public static void tvPage()
        {
            CatalogPage catalogPage = new CatalogPage();
            TVPage tvPage = new TVPage();
            ProductPage productPage = new ProductPage();
            CartPage cartPage = new CartPage();
            NavigateTo.LoginForm();
            Actions.FillLoginForm();
            Thread.Sleep(3000);
            Actions.ClickCatalogButton();
            
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
