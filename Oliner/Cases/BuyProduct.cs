using NUnit.Framework;
using Onliner.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
            TVPage tvPage = new TVPage();
            ProductPage productPage = new ProductPage();
            CartPage cartPage = new CartPage();

            NavigateTo.tvPage();
            tvPage.product1.Click();
            productPage.sellersOffers.Click();
            Thread.Sleep(1000);
            productPage.prodovec.Click();
            Thread.Sleep(2000);
            productPage.cart.Click();
            Thread.Sleep(2000);
            cartPage.orderButton.Click();
            Thread.Sleep(10000);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }



    }
}
