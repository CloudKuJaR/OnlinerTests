using Onliner.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Onliner
{
    public static class Actions
    {
        public static LoginForm loginForm = new LoginForm();
        public static TVPage tvPage = new TVPage();
        public static ProductPage productPage = new ProductPage();
        public static Menu menu = new Menu();
        public static CartPage cartPage = new CartPage();

        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.baseUrl);
        }

        public static void FillLoginForm()
        {

            loginForm.UsernameField.SendKeys(Config.Credentials.userMail);
            loginForm.PasswordField.SendKeys(Config.Credentials.userPassword);
            loginForm.loginButton.Click();

        }

        public static void FillSerachBar()
        {

            menu.searchBar.SendKeys(Config.SearchInformation.searchItem);
        }

        public static void ClickCatalogButton()
        {
            menu.catalogButton.Click();
        }

        public static void ClickFirstProductButton()
        {
            tvPage.product1.Click();
        }

        public static void ClickSecondProductButton()
        {
            tvPage.product2.Click();
        }

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

        public static void ClickOrderButton()
        {
            cartPage.orderButton.Click();
        }

        public static void ClickComparisonButton()
        {
            productPage.comparisonButton.Click();
        }

        public static void ClickTvCatalogButton()
        {
            productPage.tvCatalogButton.Click();
        }
        public static void ClickCompareButton()
        {
            menu.compareButton.Click();
        }
    }
}
