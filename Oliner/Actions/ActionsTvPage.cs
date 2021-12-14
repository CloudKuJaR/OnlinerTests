using Onliner.Pages;

namespace Onliner.Actions
{
    public static class ActionsTvPage
    {
        public static TVPage tvPage = new TVPage();
        public static void ClickFirstProductButton()
        {
            tvPage.product1.Click();
        }

        public static void ClickSecondProductButton()
        {
            tvPage.product2.Click();
        }
    }
}
