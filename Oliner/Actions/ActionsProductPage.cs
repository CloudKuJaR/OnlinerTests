using Onliner.Pages;

namespace Onliner.Actions
{
    public static class ActionsProductPage
    {
        public static ProductPage productPage = new ProductPage();
        public static void ClickSellersOfeersButton()
        {
            productPage.sellersOffers.Click();
        }

        public static void ClickSellerButton()
        {
            productPage.prodovec.Click();
        }

        public static void ClickCratButton()
        {
            productPage.cart.Click();
        }

        public static void ClickComparisonButton()
        {
            productPage.comparisonButton.Click();
        }

        public static void ClickTvCatalogButton()
        {
            productPage.tvCatalogButton.Click();
        }
    }
}
