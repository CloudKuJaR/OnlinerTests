using Onliner.ActionsWaits;
using Onliner.WebElementExtension;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Onliner.Pages
{
    public class Menu
    {
        public const string COMPARE_BUTTON = "//a[@class='compare-button__sub compare-button__sub_main']";
        public const string CATALOG_BUTTON = "//span[@class='b-main-navigation__text'][text()='Каталог']";
        public const string SEARCH_BAR = "//input[@tabindex='1']";
        public const string AUTH_BUTTON = "//div[@class='auth-bar__item auth-bar__item--text']";
        public const string SEARCH_WINDOW = "//div[@class='search__content-wrapper']";
        public const string USER_MENU = "//a[@href='https://profile.onliner.by']//div[contains(@class,'b-top-profile__image')]";
        public const string LOGOUT_BUTTON = "//div[contains(@class,'b-top-profile__logout')]/a";
        public const string CART_BANNER = "//*[contains(@class,'auth-bar__counter') or contains(@class,'profile__counter')]";
        public const string CART_BUTTON = "//div[@id='cart-desktop']";

        public MyWebElement CompareButton => new MyWebElement(By.XPath(COMPARE_BUTTON));
        public MyWebElement CatalogButton => new MyWebElement(By.XPath(CATALOG_BUTTON));
        public MyWebElement SearchBar => new MyWebElement(By.XPath(SEARCH_BAR));
        public MyWebElement AuthButton => new MyWebElement(By.XPath(AUTH_BUTTON));
        public MyWebElement UserMenu => new MyWebElement(By.XPath(USER_MENU));
        public MyWebElement LogOutButton => new MyWebElement(By.XPath(LOGOUT_BUTTON));
        public MyWebElement CartBanner => new MyWebElement(By.XPath(CART_BANNER));
        public MyWebElement CartButton => new MyWebElement(By.XPath(CART_BUTTON));

        public void FillSerachBar()
        {
            SearchBar.SendKeys(TestSettings.SearchItem);
        }

        public void OpenCatalogButton()
        {
            CatalogButton.Click();
        }

        public void OpenCompareButton()
        {
            CompareButton.Click();
        }

        public void ClickLoginForm()
        {
            AuthButton.Click();
        }

        public void ClickUserMenuBatton()
        {
            UserMenu.Click();
        }

        public void ClickLogOutButton()
        {
            LogOutButton.Click();
        }

        public void ClickCartButton()
        {
            CartButton.Click();
        }

        public bool IsLoggedIn()
        {
            bool isLogged = false;
            try
            {
                if (UserMenu.Enabled == true)
                {
                    isLogged = true;
                }
            }
            catch { }

            return isLogged;
        }

        public bool IsCartContains()
        {
            bool IsContains = false;
            try
            {
                if (CartBanner.Enabled == true)
                {
                    IsContains = true;
                }
            }
            catch { }
            return IsContains;
        }
    }
}
