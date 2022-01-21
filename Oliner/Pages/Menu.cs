using Onliner.WebElementExtension;
using OpenQA.Selenium;

namespace Onliner.Pages
{
    public class Menu
    {
        private const string COMPARE_BUTTON = "//a[@class='compare-button__sub compare-button__sub_main']";
        private const string CATALOG_BUTTON = "//span[@class='b-main-navigation__text'][text()='Каталог']";
        private const string SEARCH_BAR = "//input[@tabindex='1']";
        private const string AUTH_BUTTON = "//div[@class='auth-bar__item auth-bar__item--text']";
        private const string USER_MENU = "//a[@href='https://profile.onliner.by']//div[contains(@class,'b-top-profile__image')]";
        private const string LOGOUT_BUTTON = "//div[contains(@class,'b-top-profile__logout')]/a";
        private const string CART_BANNER = "//*[@id='cart-desktop']//span[not(contains(@style,'none'))]";
        private const string CART_BUTTON = "//div[@id='cart-desktop']";
        private const string ACC_NAME = "//*[@class='b-top-profile__name']//*[contains(@href,'https://profile.onliner.by')]";
        private const string COMPARE_TEXT = "//*[@class='compare-button__sub compare-button__sub_main']//span";

        private MyWebElement UserMenu => new MyWebElement(By.XPath(USER_MENU));
        private MyWebElement CartBanner => new MyWebElement(By.XPath(CART_BANNER));
        private MyWebElement AccName => new MyWebElement(By.XPath(ACC_NAME));
        private MyWebElement CompareText => new MyWebElement(By.XPath(COMPARE_TEXT));
        private MyWebElement CompareButton => new MyWebElement(By.XPath(COMPARE_BUTTON));
        private MyWebElement CatalogButton => new MyWebElement(By.XPath(CATALOG_BUTTON));
        private MyWebElement SearchBar => new MyWebElement(By.XPath(SEARCH_BAR));
        private MyWebElement AuthButton => new MyWebElement(By.XPath(AUTH_BUTTON));
        private MyWebElement LogOutButton => new MyWebElement(By.XPath(LOGOUT_BUTTON));
        private MyWebElement CartButton => new MyWebElement(By.XPath(CART_BUTTON));

        public void FillSerachBar(string text) => SearchBar.SendKeys(text);

        public void OpenComparePage() => CompareButton.Click();

        public void OpenLoginForm() => AuthButton.Click();

        public void ClickUserMenuBatton() => UserMenu.Click();

        public void ClickLogOutButton() => LogOutButton.Click();

        public void OpenCartPage() => CartButton.Click();

        public bool IsUserMenuPresent() => UserMenu.IsPresent();

        public bool IsCartBannerPresent() => CartBanner.IsPresent();

        public string GetAccountNameText() => AccName.Text;

        public string GetCompareText() => CompareText.Text;

        public void OpenCatalogButton()
        {
            CatalogButton.WaitForElementIsDisplayed();
            CatalogButton.Click();
        }

        public bool IsSearchContainsItem(string searchItem)
        {
            bool isContains = true;
            var ListOfSeacrhResults = Driver.driver.FindElements(By.XPath("//a[@class='product__title-link']"));
            foreach (var item in ListOfSeacrhResults)
            {
                if (!item.Text.Contains(searchItem))
                {
                    isContains = false;
                    break;
                }
            }

            return isContains;
        }
    }
}
