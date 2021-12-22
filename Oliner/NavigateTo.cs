using Onliner.Actions;
using Onliner.Pages;
using OpenQA.Selenium;

namespace Onliner
{
    class NavigateTo
    {
        public static CatalogPage catalogPage;
        public static Menu menu;

        public static void LoginForm(IWebDriver driver)
        {
            menu = new Menu(driver);
            menu.authButton.Click();
        }

        public static void TvPage(IWebDriver driver)
        {
            catalogPage = new CatalogPage(driver);
            catalogPage.electronics.Click();
            catalogPage.tvAndVideo.Click();
            catalogPage.tv.Click();

        }

        public static void Catalog(IWebDriver driver)
        {
            ActionsHomePage.ClickCatalogButton(driver);
        }
    }
}
