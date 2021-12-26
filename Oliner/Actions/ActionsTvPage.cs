using Onliner.Pages;

namespace Onliner.Actions
{
    public static class ActionsTvPage
    {
        //public static TVPage tvPage = new TVPage();
        public static void ClickFirstProductButton()
        {
            TVPage tvPage = new TVPage();
            tvPage.product1.Click();
        }

        public static void ClickSecondProductButton()
        {
            TVPage tvPage = new TVPage();
            tvPage.product2.Click();
        }
    }
}
