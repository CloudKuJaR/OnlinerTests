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
        private const string SEARCH_WINDOW = "//div[@class='search__content-wrapper']";
        private const string USER_MENU = "//a[@href='https://profile.onliner.by']//div[contains(@class,'b-top-profile__image')]";
        private const string LOGOUT_BUTTON = "//div[contains(@class,'b-top-profile__logout')]/a";
        private const string CART_BANNER = "//*[@id='cart-desktop']//span[not(contains(@style,'none'))]"; //*[contains(@class,'auth-bar__counter') or contains(@class,'profile__counter')]
        private const string CART_BUTTON = "//div[@id='cart-desktop']";
        private const string ACC_NAME = "//*[@class='b-top-profile__name']//*[contains(@href,'https://profile.onliner.by')]";
        private const string COMPARE_TEXT = "//*[@class='compare-button__sub compare-button__sub_main']//span";

        public MyWebElement CompareButton => new MyWebElement(By.XPath(COMPARE_BUTTON));
        public MyWebElement CatalogButton => new MyWebElement(By.XPath(CATALOG_BUTTON));
        public MyWebElement SearchBar => new MyWebElement(By.XPath(SEARCH_BAR));
        public MyWebElement AuthButton => new MyWebElement(By.XPath(AUTH_BUTTON));
        public MyWebElement UserMenu => new MyWebElement(By.XPath(USER_MENU));
        public MyWebElement LogOutButton => new MyWebElement(By.XPath(LOGOUT_BUTTON));
        public MyWebElement CartBanner => new MyWebElement(By.XPath(CART_BANNER));
        public MyWebElement CartButton => new MyWebElement(By.XPath(CART_BUTTON));
        public MyWebElement AccName => new MyWebElement(By.XPath(ACC_NAME));
        public MyWebElement CompareText => new MyWebElement(By.XPath(COMPARE_TEXT));

        public void FillSerachBar() => SearchBar.SendKeys(TestSettings.SearchItem);

        public void OpenComparePage() => CompareButton.Click();

        public void OpenLoginForm() => AuthButton.Click();

        public void ClickUserMenuBatton() => UserMenu.Click();

        public void ClickLogOutButton() => LogOutButton.Click();

        public void OpenCartPage() => CartButton.Click();

        public void OpenCatalogButton()
        {
            CatalogButton.WaitForElementIsDisplayed();
            CatalogButton.Click();
        }

        public bool IsSearchItemContains(string searchItem)
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
