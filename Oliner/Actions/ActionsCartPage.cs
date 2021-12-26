using Onliner.Pages;

namespace Onliner.Actions
{
    public static class ActionsCartPage
    {
        //public static CartPage cartPage = new CartPage();
        public static void ClickOrderButton()
        {
            CartPage cartPage = new CartPage();
            cartPage.orderButton.Click();
        }
    }
}
