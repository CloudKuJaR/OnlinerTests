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
    class ProductComparison
    {

        [OneTimeSetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
        }

        [Test]
        public void ProductComparisonTest()
        {
            CatalogPage catalogPage = new CatalogPage();
            TVPage tvPage = new TVPage();
            ProductPage productPage = new ProductPage();
            Menu menu = new Menu();

            NavigateTo.Catalog();
            catalogPage.electronics.Click();
            catalogPage.tvAndVideo.Click();
            catalogPage.tv.Click();
            Thread.Sleep(1000);
            tvPage.product1.Click();
            productPage.comparisonButton.Click();
            Thread.Sleep(1000);
            productPage.tvCatalogButton.Click();
            Thread.Sleep(500);
            tvPage.product2.Click();
            Thread.Sleep(500);
            productPage.comparisonButton.Click();
            Thread.Sleep(1000);
            menu.compareButton.Click();
            Thread.Sleep(2000);
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }

    }
}
