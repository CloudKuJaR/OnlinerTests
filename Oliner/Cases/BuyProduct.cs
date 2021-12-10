using NUnit.Framework;
using Onliner.Pages;
using System.Threading;

namespace Onliner.Cases
{
    class BuyProduct
    {
        

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void BuyProductTest()
        {
            NavigateTo.LoginForm();
            Actions.FillLoginForm();
            Thread.Sleep(3000);
            Actions.ClickCatalogButton();
            NavigateTo.TvPage();
            Actions.ClickFirstProductButton();
            Actions.ClickSellersOfeersButton();
            Thread.Sleep(1000);
            Actions.ClickSellerButton();
            Thread.Sleep(2000);
            Actions.ClickCratButton();
            Thread.Sleep(2000);
            Actions.ClickOrderButton();
            Thread.Sleep(10000);
        }



        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }



    }
}
