using NUnit.Framework;
using Onliner.Actions;
using Onliner.Pages;
using System.Threading;

namespace Onliner.Cases
{
    class BuyProduct
    {
        [OneTimeSetUp]
        public void InitializeComponent()
        {
            Initialize.InitializeComponents();
        }

        [Test]
        public void BuyProductTest()
        {
            NavigateTo.LoginForm();
            ActionsLogin.FillLoginForm();
            ActionsWait.WaitMethod(Menu.CATALOG_BUTTON);
            ActionsHomePage.ClickCatalogButton();
            NavigateTo.TvPage();
            ActionsWait.WaitMethod(TVPage.PRODUCT1);
            ActionsTvPage.ClickFirstProductButton();
            ActionsProductPage.ClickSellersOfeersButton();
            ActionsWait.WaitMethod(ProductPage.SELLER);
            ActionsProductPage.ClickSellerButton();
            ActionsWait.WaitMethod(ProductPage.CONFIRM_CITY_BUTTON);
            ActionsProductPage.ClickCityButton();
            ActionsWait.WaitMethod(ProductPage.CART);
            ActionsProductPage.ClickCratButton();
            ActionsWait.WaitMethod(CartPage.ORDER_BUTTON);
            ActionsCartPage.ClickOrderButton();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }



    }
}
